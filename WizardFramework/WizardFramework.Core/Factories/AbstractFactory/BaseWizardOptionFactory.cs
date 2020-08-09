using System;
using WizardFramework.Abstractions;

namespace WizardFramework.Core
{
    /// <summary>
    /// Options factory.
    /// </summary>
    public abstract class BaseWizardOptionFactory
    {
        public virtual IWizardSingleOption<T> CreateSingleOption<T>(string name)
        {
            return default;
        }

        public virtual IWizardSingleOption<T> CreateSingleValidatedOption<T>(string name, Func<T, bool> validationPredicate)
        {
            return default;
        }
    }
}