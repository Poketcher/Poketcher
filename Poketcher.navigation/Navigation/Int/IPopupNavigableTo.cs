namespace Poketcher.navigation.Navigation.Int;

public interface IPopupNavigableTo
{
    Task OnNavigatedTo(object? parameters);
    Task Opened();
    Task Closed();
}