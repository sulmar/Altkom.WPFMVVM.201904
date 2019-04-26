using Altkom.ABC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Altkom.ABC.WPFClient.Common
{
    public class FrameNavigationService : INavigationService
    {
        public object Parameter { get; private set; }

        public void GoBack()
        {
            throw new NotImplementedException();
        }

        public void GoForward()
        {
            throw new NotImplementedException();
        }

        public void Navigate(string viewName, object parameter = null)
        {
            Parameter = parameter;

            Frame frame = Get("ViewFrame");

            Uri uri = new Uri($"Views/{viewName}View.xaml", UriKind.Relative);

            frame.Navigate(uri, parameter);

        }

        private Frame Get(string name)
        {
            if (Application.Current.MainWindow.FindName(name) is Frame frame)
            {
                return frame;
            }

            throw new KeyNotFoundException(name);
        }
    }
}
