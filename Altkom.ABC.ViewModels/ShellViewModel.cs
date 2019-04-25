using System;
using System.Collections.Generic;
using System.Text;

namespace Altkom.ABC.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        public string Name { get; set; }

        public ShellViewModel()
        {
            Name = "Hello";
        }
    }
}
