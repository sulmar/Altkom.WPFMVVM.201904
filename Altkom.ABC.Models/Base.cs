using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Altkom.ABC.Models
{
    public abstract class Base : INotifyPropertyChanged
    {
        public int Id { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;


        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
