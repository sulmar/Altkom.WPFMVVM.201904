using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Altkom.ABC.Models
{

   

    public abstract class Base : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        public int Id { get; set; }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region INotifyDataErrorInfo

        public bool HasErrors => !(validator?.Validate(this).IsValid ?? true);

        public IEnumerable GetErrors(string propertyName)
        {
            return validator.Validate(this, propertyName).Errors;
        }

        // Install-Package FluentValidation.ValidatorAttribute
        private IValidator validator => new AttributedValidatorFactory().GetValidator(this.GetType());

        public string Error => throw new NotImplementedException();

        public string this[string columnName] => throw new NotImplementedException();

        #endregion


    }
}
