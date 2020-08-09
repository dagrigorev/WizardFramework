using System;
using Pipeline;

namespace WizardFramework.Abstractions
{
    /// <summary>
    /// Simple wizard step.
    /// </summary>
    public interface IWizardStep : IPipelineItem, ICloneable
    {
        /// <summary>
        /// Step name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Wizard context.
        /// </summary>
        IWizardContext Context { get; }

        /// <summary>
        /// Step configuration storage.
        /// </summary>
        IWizardStepConfiguration LocalConfiguration { get; }

        /// <summary>
        /// Do current step. 
        /// </summary>
        void Do();

        /// <summary>
        /// Undo current step.
        /// </summary>
        void UnDo();
    }
}
