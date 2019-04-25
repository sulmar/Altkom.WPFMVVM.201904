using Altkom.ABC.FakeServices.Fakers;
using Altkom.ABC.IServices;
using Altkom.ABC.Models;

namespace Altkom.ABC.FakeServices
{
    public class FakeProductsService : FakeEntitiesService<Product>, IProductsService
    {
        public FakeProductsService(ProductFaker entityFaker) : base(entityFaker)
        {
        }
    }
}
