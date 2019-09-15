using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace XplatCollect.ViewModels
{
    public sealed class NewCollectionPageViewModel : ViewModelBase
    {
        public NewCollectionPageViewModel(INavigationService navigationService
            , IPageDialogService pageDialogService)
            : base(navigationService, pageDialogService)
        {
        }
    }
}