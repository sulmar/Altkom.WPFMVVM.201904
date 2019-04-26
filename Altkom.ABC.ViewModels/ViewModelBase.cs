using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Altkom.ABC.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        protected readonly INavigationService navigationService;
        protected readonly IEventAggregator eventAggregator;

        protected ViewModelBase(INavigationService navigationService, IEventAggregator eventAggregator)
        {
            this.navigationService = navigationService;
            this.eventAggregator = eventAggregator;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
