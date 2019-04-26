using Altkom.ABC.IServices;
using Altkom.ABC.Models;
using Altkom.ABC.ViewModels.Messages;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace Altkom.ABC.ViewModels
{
    public class ProductsViewModel : EntitiesViewModel<Product>
    {
        public ProductsViewModel(INavigationService navigationService, IEventAggregator eventAggregator, IProductsService entitiesService)
            : base(navigationService, eventAggregator, entitiesService)
        {

            EditCommand = new RelayCommand(()=>Edit());

           
        }

        private void Edit()
        {
            navigationService.Navigate("Product", SelectedProduct);

            eventAggregator.Send(new ProductChangedMessage(SelectedProduct));
        }

        public IEnumerable<Product> Products => Entities;

        public Product SelectedProduct => SelectedEntity;

        public bool IsSelected => SelectedEntity != null;

        public ICommand EditCommand { get; private set; }

      


    }
}
