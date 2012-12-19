using Caliburn.Micro;

namespace Navigation.ViewModels
{
    public class NavigationScreenViewModel : Screen
    {
        public NavigationHostViewModel NavigationHost
        {
            get { return (NavigationHostViewModel)Parent; }
        }

        public void Back()
        {
            NavigationHost.Back();
        }
    }
}