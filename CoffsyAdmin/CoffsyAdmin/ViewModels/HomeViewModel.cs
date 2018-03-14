using System;
using System.Collections.Generic;
using System.Text;
using Prism.Navigation;

namespace CoffsyAdmin.ViewModels
{
    public class HomeViewModel:ViewModelBase
    {
        public HomeViewModel(INavigationService navigationService) : base(navigationService, "Home")
        {
        }
    }
}
