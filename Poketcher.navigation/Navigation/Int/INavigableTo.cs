using Poketcher.navigation.Navigation.Imp;

namespace Poketcher.navigation.Navigation.Int;

public interface INavigableTo
{
    Task OnNavigatedTo(object? parameters);
    Task Pop(object? data = null);
    Task<T?> ShowPopupAsync<T, TViewModel>(object? data = null) where T : class where TViewModel : MauiPopupViewModel;
}