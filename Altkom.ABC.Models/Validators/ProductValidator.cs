using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Altkom.ABC.Models.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Color).NotEmpty().Length(3, 10);
        }
    }
}
