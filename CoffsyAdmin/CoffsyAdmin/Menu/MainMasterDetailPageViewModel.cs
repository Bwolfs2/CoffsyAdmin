using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CoffsyAdmin.ViewModels;
using Prism.Navigation;

namespace CoffsyAdmin.Menu
{
    public class MainMasterDetailPageViewModel : ViewModelBase
    {
        public ObservableCollection<MasterPageItem> Items { get; set; } = new ObservableCollection<MasterPageItem>();
      
        public MainMasterDetailPageViewModel(INavigationService navigationService)
            : base(navigationService, "Menu")
        {
            Items.Add(new MasterPageItem { Title = "Home", Icon = "ic_home_black_24dp", NavigationPage = "PrismNavigationPage/Home" });
            Items.Add(new MasterPageItem { Title = "Message", Icon = "ic_group_work_black_24dp", NavigationPage = "PrismNavigationPage/Message" });
            Items.Add(new MasterPageItem { Title = "Friends", Icon = "ic_work_black_24dp", NavigationPage = "PrismNavigationPage/Friends" });
        }

        public async Task NavigateTo(string page)
        {
            await NavigationService.NavigateAsync(page);
        }
    }
}
