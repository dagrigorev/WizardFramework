using WizardFramework.Abstractions;

namespace WizardFramework.Core
{
    /// <summary>
    /// Base wizard steps abstract factory.
    /// </summary>
    public abstract class BaseWizardStepsFactory
    {
        /// <summary>
        /// Creates new single step.
        /// </summary>
        /// <param name="context">Step owner.</param>
        /// <returns></returns>
        public virtual IWizardStep CreateNewStep(IWizardContext context)
        {
            return default;
        }

        /// <summary>
        /// Creates new skippable step.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public virtual IWizardStep CreateSkippableStep(IWizardContext context)
        {
            return CreateNewStep(context);
        }

        /// <summary>
        /// Create new acceptable step.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public virtual IWizardStep CreateAcceptableStep(IWizardContext context)
        {
            return CreateNewStep(context);
        }
    }
}