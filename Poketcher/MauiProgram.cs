using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Storage;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Poketcher.database.DBContext;
using Poketcher.database.Profiles.User;
using Poketcher.database.Repositories.User.Imp;
using Poketcher.database.Repositories.User.Int;
using Poketcher.database.Services.User.Imp;
using Poketcher.database.Services.User.Int;
using Poketcher.Features.Settings;
using Poketcher.navigation.Navigation.Imp;
using Poketcher.navigation.Navigation.Int;

namespace Poketcher;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();


        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
            .RegisterPageAndViewModel()
            .RegisterServices()
            .RegisterDbServices()
            .RegisterDbRepositories()
            .RegisterRoutes();

        builder.Services.AddSingleton<IFileSaver>(FileSaver.Default);

#if DEBUG
        builder.Logging.AddDebug();
#endif
        var app = builder.Build();

        //CopyDatabaseIfNotExists("poketcher.db");
        CopyDatabaseIfNotExists("user.db");

        return app;
    }
    private static void CopyDatabaseIfNotExists(string dbName)
    {
        var destinationPath = Path.Combine(FileSystem.AppDataDirectory, dbName);

        if (File.Exists(destinationPath))
        {
            File.Delete(destinationPath);
        }

        if (!File.Exists(destinationPath))
        {
            using var stream = File.OpenWrite(destinationPath);
            var assembly = typeof(MauiProgram).Assembly;
            using var resourceStream = assembly.GetManifestResourceStream($"Poketcher.Resources.Raw.{dbName}");
            resourceStream?.CopyTo(stream);
        }
    }
    private static MauiAppBuilder RegisterPageAndViewModel(this MauiAppBuilder builder)
    {

        builder.Services.AddTransientWithShellRoute<SettingsPage, SettingsViewModel>(nameof(SettingsPage));
        return builder;
    }
    private static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<INavigationService, NavigationService>();
        builder.Services.AddSingleton<IAlertService, AlertService>();
        return builder;
    }

    private static MauiAppBuilder RegisterRoutes(this MauiAppBuilder builder)
    {
        Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
        return builder;
    }

    private static MauiAppBuilder RegisterDbServices(this MauiAppBuilder builder)
    {
        var dbPath = Path.Combine(FileSystem.AppDataDirectory, "user.db");

        builder.Services.AddScoped<UserDbContext>(provider =>
        {
            var options = provider.GetRequiredService<DbContextOptions<UserDbContext>>();
            return new UserDbContext(dbPath, options);
        });

        builder.Services.AddDbContext<UserDbContext>(options =>
        {
            options.UseSqlite($"Data Source={dbPath}");
        });

        builder.Services.AddScoped<IUserPokemonService, UserPokemonService>();

        builder.Services.AddAutoMapper(typeof(UserPokemonProfile));

        return builder;
    }

    private static MauiAppBuilder RegisterDbRepositories(this MauiAppBuilder builder)
    {
        builder.Services.AddScoped<IUserPokemonRepository, UserPokemonRepository>();
        return builder;
    }
}