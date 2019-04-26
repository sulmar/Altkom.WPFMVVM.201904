using Altkom.ABC.Models.Validators;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Altkom.ABC.Models
{
    [Validator(typeof(ProductValidator))]
    public partial class Product : Base
    {
        private string _color;

        public string Name { get; set; }


        public string Color
        {
            get { return _color; }
            set
            {
                Validating();

                _color = value;

                OnPropertyChanged();

                Validated();

            }
        }

        partial void Validating();

        partial void Validated();

    }
}
