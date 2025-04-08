using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using Poketcher.navigation.Navigation.Int;

namespace Poketcher.navigation.Navigation.Imp;

public class MauiPopupViewModel: ObservableObject ,IPopupNavigableTo
{
    public Popup Popup { get; set; }
    public virtual Task Opened()
    {
        return Task.CompletedTask;
    }
    public virtual Task OnNavigatedTo(object? parameters)
    {
        return Task.CompletedTask;
    }
    public virtual Task Closed()
    {
        return Task.CompletedTask;
    }

    public virtual async Task NavigateBack()
    {
        await Popup.CloseAsync();
    }
}