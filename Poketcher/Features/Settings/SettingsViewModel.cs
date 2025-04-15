using System.Collections.ObjectModel;
using CommunityToolkit.Maui.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Poketcher.database.DBContext;
using Poketcher.database.Dtos.User;
using Poketcher.database.Entities.Poketcher.Pokemons;
using Poketcher.database.Services.User.Int;
using Poketcher.Features.Base;
using Poketcher.navigation.Navigation.Int;
using Poketcher.Services;

namespace Poketcher.Features.Settings;
public partial class SettingsViewModel : BaseViewModel
{

    [ObservableProperty]
    private ObservableCollection<Pokemon> _pokemons = new ObservableCollection<Pokemon>
        {
            new Pokemon{Number="#0001",Name="Bulbasaur",Sprite="https://img.pokemondb.net/sprites/home/normal/bulbasaur.png",Type=new List<string>{"Erba" }},
            new Pokemon{Number="#0004",Name="Charmander",Sprite="https://img.pokemondb.net/sprites/home/normal/charmander.png",Type=new List<string>{"Fuoco"}},
            new Pokemon{Number="#0257",Name="Blaziken",Sprite="https://img.pokemondb.net/sprites/home/normal/blaziken.png",Type=new List<string>{"Fuoco", "Lotta"}},
            new Pokemon{Number="#0376",Name="Metagross",Sprite="https://img.pokemondb.net/sprites/home/normal/metagross.png",Type=new List<string>{"Acciaio", "Psico"}},
        };

    [ObservableProperty]
    private string _number;

    [ObservableProperty]
    private string _name;

    [ObservableProperty]
    private string _sprite;

    [ObservableProperty]
    private List<string> _type;

    [ObservableProperty]
    private string _typeColorOne;

    [ObservableProperty]
    private string _typeColorTwo;

    private readonly IUserPokemonService _userPokemonService;
    private readonly IFileSaver _fileSaver;
    private readonly CancellationTokenSource _cancellationTokenSource = new();
    private readonly UserDbService _userDbService;

    [ObservableProperty]
    private bool _isLoading;

    [ObservableProperty]
    private int _pokemonNumber;

    [ObservableProperty]
    private int _game;

    [ObservableProperty]
    private bool _isShiny;

    [ObservableProperty]
    private bool _isMale;

    [ObservableProperty]
    private bool _isCaught;

    [ObservableProperty]
    public ObservableCollection<UserPokemonDto> _caughtPokemons = new();
    [ObservableProperty]
    public ObservableCollection<UserPokemonDto> _uncaughtPokemons = new();

    public SettingsViewModel(
        IUserPokemonService userPokemonService,
        INavigationService navigationService,
        ILogger<BaseViewModel> logger,
        IAlertService alertService,
        IFileSaver fileSaver,
        UserDbService userDbService)
        : base(navigationService, logger, alertService)
    {
        _userPokemonService = userPokemonService;
        _fileSaver = fileSaver;
        _userDbService = userDbService;
    }

    protected override async Task Appearing()
    {
        foreach (var pokemon in Pokemons)
        {
            pokemon.TypeColorOne = SetTypeColor(pokemon.Type[0]);
            if (pokemon.Type.Count > 1)
                pokemon.TypeColorTwo = SetTypeColor(pokemon.Type[1]);
            else
                pokemon.TypeColorTwo = pokemon.TypeColorOne;
        }
    }

    public string SetTypeColor(string type)
    {
        var typeColors = new Dictionary<string, string>
            {
                {"Erba", "#7AC74C"},
                {"Fuoco", "#EE8130"},
                {"Lotta", "#C22E28"},
                {"Acciaio", "#B7B7CE"},
                {"Psico", "#F95587" }
            };

        string color = typeColors[type];

        return color;
    }

    [RelayCommand]
    public async Task ExportDatabaseAsync()
    {
        var dbPath = _userDbService.GetUserDbPath();

        if (!File.Exists(dbPath))
        {
            await Application.Current.MainPage.DisplayAlert("Error", "The database file does not exist.", "OK");
            return;
        }

        try
        {
            using var stream = new MemoryStream();
            using (var fileStream = new FileStream(dbPath, FileMode.Open, FileAccess.Read))
            {
                await fileStream.CopyToAsync(stream);
            }

            stream.Position = 0;

            var fileName = "user.db";
            var path = await _fileSaver.SaveAsync(fileName, stream, _cancellationTokenSource.Token);

            if (path != null)
            {
                await Application.Current.MainPage.DisplayAlert("Success", $"The database has been exported to: {path}", "OK");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Cancelled", "The save operation was cancelled.", "OK");
            }
        }
        catch (Exception ex)
        {
            await Application.Current.MainPage.DisplayAlert("Error", $"An error occurred while saving the database: {ex.Message}", "OK");
        }


        //using var stream = new MemoryStream(System.Text.Encoding.Default.GetBytes("Ciao"));
        //var path = await _fileSaver.SaveAsync("user.data", stream, _cancellationTokenSource.Token);

    }

    [RelayCommand]
    public async Task ImportDatabaseAsync()
    {
        var result = await FilePicker.Default.PickAsync(new PickOptions
        {
            PickerTitle = "Select file to import"
        });

        if (result != null)
        {
            string importPath = result.FullPath;
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "user.db");

            if (IsValidDatabase(dbPath))
            {
                bool confirm = await Application.Current.MainPage.DisplayAlert(
                    "Confirm",
                    "Importing this database the current data will be overwritten. Do you want to proceed?",
                    "Yes",
                    "No");

                if (confirm)
                {
                    await _userDbService.ImportDbAsync(importPath);
                    await Application.Current.MainPage.DisplayAlert("Success", "Data imported successfully!", "OK");
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "The selected file is not a valid database.", "OK");
            }
        }
    }

    private bool IsValidDatabase(string dbPath)
    {
        try
        {
            var options = new DbContextOptionsBuilder<UserDbContext>()
                .UseSqlite($"Data Source={dbPath}")
                .Options;

            using var dbContext = new UserDbContext(dbPath, options);

            if (!dbContext.Database.CanConnect())
                return false;

            var tables = dbContext.Model.GetEntityTypes().Select(t => t.GetTableName()).ToList();

            return tables.Contains("UserPokemon");
        }
        catch
        {
            return false;
        }
    }

    [RelayCommand]
    private void AddTestPokemons()
    {
        _userPokemonService.AddPokemon(new CreateUserPokemonDto { PokemonNumber = 1, Game = 1, IsShiny = false, IsMale = true, IsCaught = true });
        _userPokemonService.AddPokemon(new CreateUserPokemonDto { PokemonNumber = 4, Game = 1, IsShiny = false, IsMale = false, IsCaught = true });
        _userPokemonService.AddPokemon(new CreateUserPokemonDto { PokemonNumber = 7, Game = 1, IsShiny = true, IsMale = true, IsCaught = false });
        _userPokemonService.AddPokemon(new CreateUserPokemonDto { PokemonNumber = 25, Game = 1, IsShiny = false, IsMale = true, IsCaught = false });

        Application.Current.MainPage.DisplayAlert("Pokémon Aggiunti", "4 Pokémon sono stati aggiunti per test!", "OK");
    }

    [RelayCommand]
    private async Task LoadPokemonDataAsync()
    {
        try
        {
            IsLoading = true;

            var caught = await _userPokemonService.PokemonCaughtAndUncaught(0, 50, true);
            var unCaught = await _userPokemonService.PokemonCaughtAndUncaught(0, 50, false);

            CaughtPokemons = new ObservableCollection<UserPokemonDto>(caught);
            UncaughtPokemons = new ObservableCollection<UserPokemonDto>(unCaught);

            await Application.Current.MainPage.DisplayAlert("Dati Caricati", "I Pokémon sono stati caricati correttamente.", "OK");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Errore: {ex.Message}");
            await Application.Current.MainPage.DisplayAlert("Errore", "Non è stato possibile caricare i dati dei Pokémon.", "OK");
        }
        finally
        {
            IsLoading = false;
        }
    }

}

public class Pokemon
{
    public string Number { get; set; }
    public string Name { get; set; }
    public string Sprite { get; set; }
    public List<string> Type { get; set; }
    public string TypeColorOne { get; set; }
    public string TypeColorTwo { get; set; }
}

