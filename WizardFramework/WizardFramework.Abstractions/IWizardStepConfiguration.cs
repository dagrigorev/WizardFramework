namespace WizardFramework.Abstractions
{
    /// <summary>
    /// Single step configuration.
    /// </summary>
    public interface IWizardStepConfiguration : IWizardConfigurationStorage
    {
        /// <summary>
        /// Gets or sets flag that allows you to skip step.
        /// </summary>
        IWizardSingleOption<bool> IsSkippable { get; set; }

        /// <summary>
        /// Gets ro sets flag that shows you need to accept this step.
        /// </summary>
        IWizardSingleOption<bool> IsAcceptable { get; set; }
    }
}