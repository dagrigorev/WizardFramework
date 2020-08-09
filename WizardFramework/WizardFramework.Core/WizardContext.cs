using Pipeline.Default;
using WizardFramework.Abstractions;

namespace WizardFramework.Core
{
    /// <summary>
    /// Wizard context implementation.
    /// </summary>
    public class WizardContext : Pipeline.Default.SequentialPipeline, IWizardContext
    {
        public IWizardConfigurationStorage GlobalConfiguration { get; }

        public WizardContext()
            :base()
        {
            GlobalConfiguration = new WizardConfiguration();
        }

        public void Start()
        {
            Execute();
        }

        public void Stop()
        {
            throw new System.NotImplementedException();
        }

        public void AddStep(IWizardStep step)
        {
            Register(new PipeItemExecutionPredicate(() => true), step);
        }

        public void RemoveStep(IWizardStep step)
        {
            UnRegister(step);
        }

        public IWizardStep GetStep(string name)
        {
            throw new System.NotImplementedException();
        }

        public void SaveState()
        {
            throw new System.NotImplementedException();
        }

        public void RestoreState()
        {
            throw new System.NotImplementedException();
        }
    }
}