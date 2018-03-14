using CoffsyAdmin.ViewModels;
using Prism.Navigation;

namespace Coffsy.Core.Menu
{
    public class PrismNavigationPageViewModel : ViewModelBase
    {
        public PrismNavigationPageViewModel(INavigationService navigationService)
            : base(navigationService, "Nao Definido")
        {
        }
    }
}