using Poketcher.Features.Base;

namespace Poketcher.Features.Settings;

public partial class SettingsPage : BasePage
{
	public SettingsPage(SettingsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}