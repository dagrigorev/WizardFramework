using System;
using System.ComponentModel;
using WizardFramework.Abstractions;

namespace WizardFramework.Core
{
    /// <summary>
    /// Single option implementation.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SingleOption<T> : IWizardSingleOption<T>
    {
        private T _value;
        private Func<T, bool> _validationPredicate;

        public event PropertyChangedEventHandler PropertyChanged;
        public string Name { get; set; }
        public bool IsRequired { get; set; }

        public T Value
        {
            get => _value;
            set
            {
                if (!_value.Equals(value))
                {
                    _value = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
                }
            }
        }

        public SingleOption()
        {
        }
        public bool IsValid()
        {
            if (_validationPredicate == null) return true;

            return _validationPredicate.Invoke(Value);
        }

        public SingleOption(Func<T, bool> validator)
        {
            _validationPredicate = validator ?? throw new ArgumentNullException();
        }
    }
}