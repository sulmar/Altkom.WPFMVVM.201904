using Altkom.ABC.FakeServices;
using System;
using System.Collections.Generic;
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


        public ShellViewModel()
        {
            Name = "Hello";

            ShowViewCommand = new RelayCommand<string>(p => ShowView(p));

            SelectedViewModel = new CustomersViewModel(new FakeCustomersService(new FakeServices.Fakers.CustomerFaker()));
        }

        private void ShowView(string view)
        {
            SelectedViewModel = new ProductsViewModel(new FakeProductsService(new FakeServices.Fakers.ProductFaker()));
        }
    }
}
