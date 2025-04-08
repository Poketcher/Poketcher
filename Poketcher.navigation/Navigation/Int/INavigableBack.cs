namespace Poketcher.navigation.Navigation.Int;

public interface INavigableBack
{
    Task OnNavigatedBack(object? parameters);
    Task Push<T>(object? data = null, bool? mantainFlyout = null) where T : Page;
}