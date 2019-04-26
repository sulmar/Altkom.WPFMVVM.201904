using Altkom.ABC.IServices;
using Altkom.ABC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Input;

namespace Altkom.ABC.ViewModels
{

    public class CustomersViewModel : ViewModelBase
    {
        public IEnumerable<Customer> Customers { get; set; }

        public Customer SelectedCustomer
        {
            get => _selectedCustomer;
            set
            {
                _selectedCustomer = value;

                SaveCommand.OnCanExecuteChanged();
            }
        }

        public double Width { get; set; } = 200;

        private readonly ICustomersService customersService;
        private Customer _selectedCustomer;

        public RelayCommand SaveCommand { get; private set; }

        public CustomersViewModel(INavigationService navigationService, ICustomersService customersService)
            : base(navigationService)
        {
            this.customersService = customersService;

            SaveCommand = new RelayCommand(() => Save(), () => CanSave);

            Load();
        }

        private void Save()
        {

        }

        public bool IsSelectedCustomer => SelectedCustomer != null;

        private bool CanSave => IsSelectedCustomer;

        public void Load()
        {
            // Thread.CurrentPrincipal.IsInRole("Administrator");

           Customers = customersService.Get();
        }
    }
}
