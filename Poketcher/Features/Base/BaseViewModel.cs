using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Poketcher.navigation.Navigation.Imp;
using Poketcher.navigation.Navigation.Int;
using Microsoft.Extensions.Logging;

namespace Poketcher.Features.Base;

public partial class BaseViewModel : ObservableObject, INavigableBack, INavigableTo
{
    public readonly INavigationService _navigationService;
    protected ILogger<BaseViewModel> _logger;
    protected IAlertService AlertService;
    
    public BaseViewModel(INavigationService navigationService, ILogger<BaseViewModel> logger, IAlertService alertService)
    {
        _navigationService = navigationService;
        _logger = logger;
        AlertService = alertService;
    }

    public virtual async Task OnNavigatedBack(object? parameters)
    {
        await Task.CompletedTask;
    }

    public virtual async Task OnNavigatedTo(object? parameters)
    {
        await Task.CompletedTask;
    }

    public async Task Push<T>(object? data = null, bool? mantainFlyout = null) where T : Page
    {
        await _navigationService.GoToAsync<T>(data, mantainFlyout);
    }

    public async Task Pop(object? data = null)
    {
        await _navigationService.GoBackAsync(data);
    }

    public async Task<T?> ShowPopupAsync<T, TViewModel>(object? data = null) where T : class where TViewModel : MauiPopupViewModel
    {
        return await _navigationService.ShowPopupAsync<T, TViewModel>(data);
    }

    [RelayCommand(AllowConcurrentExecutions = false)]
    protected virtual Task Appearing()
    {
        return Task.CompletedTask;
    }

    [RelayCommand(AllowConcurrentExecutions = false)]
    protected virtual Task Disappearing()
    {
        return Task.CompletedTask;
    }

    protected async Task<bool> ManageExceptionAsync(Exception ex)
    {
        
        return false;
    }

    protected async Task<bool> CheckInternetConnectionAsync()
    {
        if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
        {
            await AlertService.DisplayAlert("Nessuna Connessione", "L'app non funziona senza connessione a internet", "OK");
            return false;
        }
        return true;
    }
}