using WizardFramework.Abstractions;

namespace WizardFramework.Core
{
    public class ContextFactory : BaseWizardContextFactory
    {
        public override IWizardContext CreateContext()
        {
            return new WizardContext();
        }
    }
}