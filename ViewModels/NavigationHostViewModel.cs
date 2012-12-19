using System.Collections.Generic;
using System.Linq;
using Caliburn.Micro;

namespace Navigation.ViewModels
{
    public class NavigationHostViewModel : Conductor<Screen>.Collection.OneActive
    {
        private readonly Stack<NavigationScreenViewModel> _backstack = new Stack<NavigationScreenViewModel>();

        public void Navigate(NavigationScreenViewModel screen)
        {
            if (ActiveItem != null) _backstack.Push((NavigationScreenViewModel)ActiveItem);
            ActivateItem(screen);
        }

        public void Back()
        {
            if (!CanBack) return;

            var current = ActiveItem;
            if (current == null) return;

            DeactivateItem(ActiveItem, false);
            if (current.IsActive) return;

            NavigateBack();
        }

        private void NavigateBack()
        {
            var back = _backstack.Pop();
            ActivateItem(back);
        }

        public bool CanBack
        {
            get { return _backstack.Any(); }
        }
    }
}
