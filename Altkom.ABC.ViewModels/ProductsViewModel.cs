using Altkom.ABC.IServices;
using Altkom.ABC.Models;
using System.Collections.Generic;

namespace Altkom.ABC.ViewModels
{
    public class ProductsViewModel : EntitiesViewModel<Product>
    {
        public ProductsViewModel(IProductsService entitiesService)
            : base(entitiesService)
        {
        }

        public IEnumerable<Product> Products => Entities;

        public Product SelectedProduct => SelectedEntity;
    }
}
