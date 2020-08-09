using System.Collections.Generic;
using WizardFramework.Abstractions;

namespace WizardFramework.Core
{
    /// <summary>
    /// Single step configuration implementation.
    /// </summary>
    public class SingleStepConfiguration : IWizardStepConfiguration
    {
        public IWizardSingleOption<bool> IsSkippable { get; set; }
        public IWizardSingleOption<bool> IsAcceptable { get; set; }


        public SingleStepConfiguration()
        {
            IsSkippable = new SingleOption<bool>();
            IsAcceptable = new SingleOption<bool>();
        }

        public void AddConfiguration(string name)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveConfiguration(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}