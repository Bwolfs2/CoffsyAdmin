using Prism.Mvvm;
using Prism.Navigation;

namespace CoffsyAdmin.ViewModels
{
    public class ViewModelBase : BindableBase, INavigationAware, IDestructible
    {
        public ViewModelBase()
        {
            
        }
        protected INavigationService NavigationService { get; private set; }

        private string _title;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public ViewModelBase(INavigationService navigationService, string title)
        {
            NavigationService = navigationService;
            _title = title;
        }

        public virtual void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(NavigationParameters parameters)
        {

        }

        public virtual void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public virtual void Destroy()
        {

        }
    }
}