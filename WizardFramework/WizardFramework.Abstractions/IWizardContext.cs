namespace WizardFramework.Abstractions
{
    using Pipeline;

    /// <summary>
    /// Wizard steps manager.
    /// </summary>
    public interface IWizardContext : IPipelineBase
    {
        /// <summary>
        /// Wizard configurations storage.
        /// </summary>
        IWizardConfigurationStorage GlobalConfiguration { get; }

        /// <summary>
        /// Starts wizard.
        /// </summary>
        void Start();

        /// <summary>
        /// Stops wizard.
        /// </summary>
        void Stop();

        /// <summary>
        /// Adds new step to wizard.
        /// </summary>
        /// <param name="step"></param>
        void AddStep(IWizardStep step);

        /// <summary>
        /// Removes step from wizard.
        /// </summary>
        /// <param name="step"></param>
        void RemoveStep(IWizardStep step);

        /// <summary>
        /// Gets step by name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        IWizardStep GetStep(string name);

        /// <summary>
        /// Saves current state.
        /// </summary>
        void SaveState();

        /// <summary>
        /// Restores saved state.
        /// </summary>
        void RestoreState();
    }
}