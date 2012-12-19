using System.ComponentModel.Composition;
using Caliburn.Micro;

namespace Navigation.ViewModels
{
    [Export(typeof(IShell))]
    public class ShellViewModel : Screen,  IShell
    {
        private NavigationHostViewModel _navigationHost;
        public NavigationHostViewModel NavigationHost
        {
            get { return _navigationHost; }
            set
            {
                if (Equals(value, _navigationHost)) return;
                _navigationHost = value;
                NotifyOfPropertyChange(() => NavigationHost);
            }
        }

        protected override void OnInitialize()
        {
            NavigationHost= new NavigationHostViewModel();
            NavigationHost.Navigate(new DemoNavigationScreenViewModel(0));
        }
    }
}