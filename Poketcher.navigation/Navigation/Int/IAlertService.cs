namespace Poketcher.navigation.Navigation.Int;

public interface IAlertService
{
    Task DisplayAlert(string title, string text, string cancelButton);
    Task<bool> DisplayAlert(string title, string text, string acceptButton, string cancelButton);

    public Task DisplayActionSheet(string title, string cancel, string destruction, FlowDirection flowDirection,
        string buttons);

    Task DisplayPromptAsync(string title, string message, string accept = "OK", string cancel = "Cancel",
        string placeholder = null, int maxLength = 1, Keyboard keyboard = null, string initialValue = "");
}