using CommunityToolkit.Maui.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Logging;
using Poketcher.Features.Base;
using Poketcher.navigation.Navigation.Int;

namespace Poketcher.Features.Settings
{
    public partial class SettingsViewModel : BaseViewModel
    {
        IFileSaver _fileSaver;
        CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        public SettingsViewModel(INavigationService navigationService,
            ILogger<BaseViewModel> logger,
            IAlertService alertService) : base(navigationService, logger, alertService)
        {
          
        }
    }
}
