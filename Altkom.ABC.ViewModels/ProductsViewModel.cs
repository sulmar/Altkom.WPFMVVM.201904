using Altkom.ABC.IServices;
using Altkom.ABC.Models;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace Altkom.ABC.ViewModels
{
    public class ProductsViewModel : EntitiesViewModel<Product>
    {
        public ProductsViewModel(INavigationService navigationService, IProductsService entitiesService)
            : base(navigationService, entitiesService)
        {

            EditCommand = new RelayCommand(()=>Edit());
        }

        private void Edit()
        {
            navigationService.Navigate("Product", SelectedProduct);
        }

        public IEnumerable<Product> Products => Entities;

        public Product SelectedProduct => SelectedEntity;

        public bool IsSelected => SelectedEntity != null;

        public ICommand EditCommand { get; private set; }


    }
}
