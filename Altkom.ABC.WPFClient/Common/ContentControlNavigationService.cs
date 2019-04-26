using Altkom.ABC.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Altkom.ABC.WPFClient.Common
{
    public class ContentControlNavigationService : INavigationService
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

            ContentControl control = FindControl("ViewControl");

            Uri uri = new Uri($"Views/{viewName}View.xaml", UriKind.Relative);

            Frame frame = new Frame();

            frame.Source = uri;

            control.Content = frame;

        }

        private ContentControl FindControl(string name)
        {
            if (Application.Current.MainWindow.FindName(name) is ContentControl control)
            {
                return control;
            }

            throw new KeyNotFoundException(name);
        }
    }
}
