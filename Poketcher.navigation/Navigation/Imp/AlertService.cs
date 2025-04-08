using Poketcher.navigation.Navigation.Int;

namespace Poketcher.navigation.Navigation.Imp;

public class AlertService: IAlertService
{
    public Task DisplayAlert(string title, string text, string cancelButton)
    {
        return Shell.Current.DisplayAlert(title, text, cancelButton);
    }

    public Task<bool> DisplayAlert(string title, string text,  string acceptButton, string cancelButton)
    {
        return Shell.Current.DisplayAlert(title, text, acceptButton, cancelButton);
    }

    public Task DisplayActionSheet(string title, string cancel, string destruction, FlowDirection flowDirection,
        string buttons)
    {
        return Shell.Current.DisplayActionSheet(title, cancel, destruction, flowDirection, buttons);
    }

    public Task DisplayPromptAsync(string title, string message, string accept = "OK",
        string cancel = "Cancel", string placeholder = null, int maxLength = 1, Keyboard keyboard = null, string initialValue = "")
    {
        return Shell.Current.DisplayPromptAsync(title, message, accept, cancel, placeholder, maxLength, keyboard, initialValue);
    }
}