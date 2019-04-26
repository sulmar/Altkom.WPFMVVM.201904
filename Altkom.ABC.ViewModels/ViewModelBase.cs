using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Altkom.ABC.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        protected INavigationService navigationService;

        protected ViewModelBase(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
