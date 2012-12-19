namespace Navigation.ViewModels
{
    public class DemoNavigationScreenViewModel : NavigationScreenViewModel
    {
        private readonly int _i;

        public DemoNavigationScreenViewModel(int i)
        {
            _i = i;
            DisplayName = "DemoScreen - " + i;
        }

        public void Next()
        {
            NavigationHost.Navigate(new DemoNavigationScreenViewModel(_i + 1));
        }

        public override string ToString()
        {
            return DisplayName;
        }
    }
}