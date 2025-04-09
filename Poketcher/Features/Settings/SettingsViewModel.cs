using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Maui.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Logging;
using Poketcher.database.Dtos.User;
using Poketcher.database.Services.User.Int;
using Poketcher.Features.Base;
using Poketcher.navigation.Navigation.Int;

namespace Poketcher.Features.Settings;
public partial class SettingsViewModel : BaseViewModel
{
    private readonly IUserPokemonService _userPokemonService;
    private readonly IFileSaver _fileSaver;
    private readonly CancellationTokenSource _cancellationTokenSource = new();

    [ObservableProperty]
    public ObservableCollection<UserPokemonDto> _caughtPokemons = new();
    [ObservableProperty]
    public ObservableCollection<UserPokemonDto> _uncaughtPokemons = new();

    public SettingsViewModel(
        IUserPokemonService userPokemonService,
        INavigationService navigationService,
        ILogger<BaseViewModel> logger,
        IAlertService alertService,
        IFileSaver fileSaver)
        : base(navigationService, logger, alertService)
    {
        _userPokemonService = userPokemonService;
        _fileSaver = fileSaver;

        // Inizializza RelayCommand
        AddPokemonsCommand = new RelayCommand(AddTestPokemons);
        LoadPokemonDataCommand = new RelayCommand(async () => await LoadPokemonDataAsync());
    }

    // RelayCommand per aggiungere 4 Pokémon (per test)
    public ICommand AddPokemonsCommand { get; }

    // RelayCommand per caricare Pokémon catturati e non catturati
    public ICommand LoadPokemonDataCommand { get; }

    // Metodo per aggiungere 4 Pokémon di esempio
    private async void AddTestPokemons()
    {
        _userPokemonService.AddPokemon(new CreateUserPokemonDto { Number = 1, Generation = 1, IsShiny = false, IsMale = true, IsCaught = true });
        _userPokemonService.AddPokemon(new CreateUserPokemonDto { Number = 4, Generation = 1, IsShiny = false, IsMale = false, IsCaught = true });
        _userPokemonService.AddPokemon(new CreateUserPokemonDto { Number = 7, Generation = 1, IsShiny = true, IsMale = true, IsCaught = false });
        _userPokemonService.AddPokemon(new CreateUserPokemonDto { Number = 25, Generation = 1, IsShiny = false, IsMale = true, IsCaught = false });

        await Application.Current.MainPage.DisplayAlert("Pokémon Aggiunti", "4 Pokémon sono stati aggiunti per test!", "OK");
    }

    // Metodo per caricare Pokémon catturati e non catturati
    private async Task LoadPokemonDataAsync()
    {
        try
        {
            UncaughtPokemons.Clear();
            CaughtPokemons.Clear();
            // Ottieni Pokémon catturati
            var caught = (await _userPokemonService.PokemonCaughtAndUncaught(0,50,true)).ToList();
            var unCaught = (await _userPokemonService.PokemonCaughtAndUncaught(0, 50, false)).ToList();

            foreach (var pokemon in caught)
            {
                CaughtPokemons.Add(pokemon);
            }

            foreach (var pokemon in unCaught)
            {
                UncaughtPokemons.Add(pokemon);
            }

            await Application.Current.MainPage.DisplayAlert("Dati Caricati", "I Pokémon sono stati caricati correttamente.", "OK");
        }
        catch (Exception ex)
        {
            await Application.Current.MainPage.DisplayAlert("Errore", "Non è stato possibile caricare i dati dei Pokémon.", "OK");
        }
    }
}

