using System;
using WizardFramework.Abstractions;

namespace WizardFramework.Core
{
    /// <summary>
    /// Options factory.
    /// </summary>
    public class OptionsFactory : BaseWizardOptionFactory
    {
        public override IWizardSingleOption<T> CreateSingleOption<T>(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException();

            return new SingleOption<T>();
        }

        public override IWizardSingleOption<T> CreateSingleValidatedOption<T>(string name, Func<T, bool> validationPredicate)
        {
            if (string.IsNullOrEmpty(name) || validationPredicate == null) throw new ArgumentNullException();
            return new SingleOption<T>(validationPredicate);
        }
    }
}