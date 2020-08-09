using System;
using WizardFramework.Abstractions;

namespace WizardFramework.Core
{
    /// <summary>
    /// Wizard context abstract factory.
    /// </summary>
    public abstract class BaseWizardContextFactory
    {
        /// <summary>
        /// Creates new wizard context.
        /// </summary>
        /// <returns></returns>
        public virtual IWizardContext CreateContext()
        {
            return default;
        }
    }
}
