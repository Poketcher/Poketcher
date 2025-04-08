using CommunityToolkit.Maui.Core;
using Poketcher.navigation.Navigation.Int;

namespace Poketcher.navigation.Navigation.Imp;

public class NavigationService : INavigationService
{
    private readonly IPopupService _popupService;

    public NavigationService(IPopupService popupService)
    {
        _popupService = popupService;
    }

    public async Task GoBackAsync(object? parameters = null)
    {
        await Shell.Current.GoToAsync("..", animate: true);

        if (Shell.Current.CurrentPage.BindingContext is INavigableBack navigableBack)
        {
            await navigableBack.OnNavigatedBack(parameters);
        }
    }

    public async Task GoToAsync<T>(object? parameters = null, bool? mantainFlyout = null) where T : Page
    {

        string route = typeof(T).Name;

        if (mantainFlyout == true)
            route = $"//{route}";

        await Shell.Current.GoToAsync(route, animate: true);

        await Task.Delay(1);

        if (Shell.Current.CurrentPage.BindingContext is INavigableTo navigableTo)
        {
            await navigableTo.OnNavigatedTo(parameters);
        }
    }

    public async Task<TReturn?> ShowPopupAsync<TReturn, TViewModel>(object? dataToPass = null)
        where TReturn : class where TViewModel : MauiPopupViewModel
    {
        var a = await _popupService.ShowPopupAsync((TViewModel vm) =>
        {
            if (vm is IPopupNavigableTo navigableTo)
                navigableTo.OnNavigatedTo(dataToPass);
        });

        return a as TReturn;
    }
}