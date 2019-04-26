using Altkom.ABC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Altkom.ABC.ViewModels
{
    public class ProductViewModel : ViewModelBase
    {
        public Product Product { get; set; }

        public ProductViewModel(INavigationService navigationService, IEventAggregator eventAggregator) 
            : base(navigationService, eventAggregator)
        {
            this.Product = navigationService.Parameter as Product;
        }
    }
}
