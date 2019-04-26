using Altkom.ABC.FakeServices;
using Altkom.ABC.ViewModels.Messages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;

namespace Altkom.ABC.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        private ViewModelBase _selectedViewModel;

        public string Name { get; set; }

        public ICommand ShowViewCommand { get; private set; }

        public ViewModelBase SelectedViewModel
        {
            get => _selectedViewModel;
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged();
            }
        }

        public ShellViewModel(INavigationService navigationService, IEventAggregator eventAggregator) : base(navigationService, eventAggregator)
        {
            Name = "Hello";

            ShowViewCommand = new RelayCommand<string>(p => ShowView(p));

            eventAggregator.Register<ProductChangedMessage>(OnProductChanged);      
        }

        private void ShowView(string view)
        {
            navigationService.Navigate(view, "Hello World");

           // SelectedViewModel = new ProductsViewModel(new FakeProductsService(new FakeServices.Fakers.ProductFaker()));
        }

        private void OnProductChanged(ProductChangedMessage message)
        {
            Trace.WriteLine($"{message.Product.Name} was changed");
        }
    }
}
