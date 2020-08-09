using WizardFramework.Abstractions;

namespace WizardFramework.Core
{
    public class StepsFactory : BaseWizardStepsFactory
    {
        public override IWizardStep CreateNewStep(IWizardContext context)
        {
            return new SingleStep(context, "NewStep");
        }

        public IWizardStep CreateNewStep(IWizardContext context, string name)
        {
            return new SingleStep(context, name);
        }

        public override IWizardStep CreateAcceptableStep(IWizardContext context)
        {
            var step = CreateNewStep(context);
            step.LocalConfiguration.IsAcceptable.Value = true;

            return step;
        }

        public override IWizardStep CreateSkippableStep(IWizardContext context)
        {
            var step = CreateNewStep(context);
            step.LocalConfiguration.IsSkippable.Value = true;

            return step;
        }
    }
}