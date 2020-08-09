using System.ComponentModel;

namespace WizardFramework.Abstractions
{
    /// <summary>
    /// Single configuration field contract.
    /// </summary>
    /// <typeparam name="T">Configuration type.</typeparam>
    public interface IWizardSingleOption<T> : INotifyPropertyChanged
    {
        /// <summary>
        /// Option name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Configuration value.
        /// </summary>
        T Value { get; set; }

        /// <summary>
        /// Gets or sets required flag.
        /// </summary>
        bool IsRequired { get; set; }

        /// <summary>
        /// Checks configuration value for validity.
        /// </summary>
        /// <returns></returns>
        bool IsValid();
    }
}