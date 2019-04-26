using Altkom.ABC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Altkom.ABC.ViewModels.Messages
{

    public class ProductChangedMessage
    {
        public ProductChangedMessage(Product product)
        {
            Product = product;
        }

        public Product Product { get; private set; }
    }
}
