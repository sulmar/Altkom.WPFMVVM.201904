using System;
using System.Collections.Generic;
using System.Text;

namespace Altkom.ABC.ViewModels
{
    public interface INavigationService
    {
        object Parameter { get; }

        void Navigate(string viewName, object parameter = null);
        void GoBack();
        void GoForward();
    }
}
