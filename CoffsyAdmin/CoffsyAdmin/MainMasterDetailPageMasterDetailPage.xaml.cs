using CoffsyAdmin.Menu;
using Xamarin.Forms;

namespace CoffsyAdmin
{
	public partial class MainMasterDetailPageMasterDetailPage : MasterDetailPage
    {
		public MainMasterDetailPageMasterDetailPage()
		{
			InitializeComponent();
		}

        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedItem = (MasterPageItem)e.SelectedItem;

            var a = (MainMasterDetailPageViewModel)BindingContext;

            await a.NavigateTo(selectedItem.NavigationPage);
        }
    }
}
