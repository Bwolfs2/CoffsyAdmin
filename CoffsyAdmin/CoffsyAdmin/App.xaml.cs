using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Coffsy.Core.Menu;
using CoffsyAdmin.Menu;
using CoffsyAdmin.Pages;
using CoffsyAdmin.ViewModels;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;

namespace CoffsyAdmin
{
	public partial class App : PrismApplication
    {
        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("MainMasterDetailPage/PrismNavigationPage/Home");
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<PrismNavigationPage, PrismNavigationPageViewModel>("PrismNavigationPage");

            containerRegistry.RegisterForNavigation<MainMasterDetailPageMasterDetailPage, MainMasterDetailPageViewModel>("MainMasterDetailPage");

            containerRegistry.RegisterForNavigation<Home, HomeViewModel>("Home");

            containerRegistry.RegisterForNavigation<Message>("Message");

            containerRegistry.RegisterForNavigation<Friends>("Friends");
        }

    }
}
