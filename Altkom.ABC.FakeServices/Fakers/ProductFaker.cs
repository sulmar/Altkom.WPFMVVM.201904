using Altkom.ABC.Models;
using Bogus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Altkom.ABC.FakeServices.Fakers
{
    public class ProductFaker : Faker<Product>
    {
        public ProductFaker()
        {
            StrictMode(true);
            RuleFor(p => p.Id, f => f.IndexFaker);
            RuleFor(p => p.Name, f => f.Commerce.ProductName());
            RuleFor(p => p.Color, f => f.Commerce.Color());
        }
    }
}
