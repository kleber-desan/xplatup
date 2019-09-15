using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace XplatCollect.ViewModels
{
    public sealed class ProfilePageViewModel : ViewModelBase
    {
        public ProfilePageViewModel(INavigationService navigationService
            , IPageDialogService pageDialogService)
            : base(navigationService, pageDialogService)
        {
        }
    }
}