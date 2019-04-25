using System;
using System.Collections.Generic;
using System.Text;

namespace Altkom.ABC.Models
{
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

                Validated();

            }
        }

        partial void Validating();

        partial void Validated();

    }
}
