namespace WizardFramework.Abstractions
{
    /// <summary>
    /// Configuration storage container contract.
    /// </summary>
    public interface IWizardConfigurationStorage
    {
        /// <summary>
        /// Adds new configuration.
        /// </summary>
        /// <param name="name"></param>
        void AddConfiguration(string name);

        /// <summary>
        /// Removes configuration.
        /// </summary>
        /// <param name="name"></param>
        void RemoveConfiguration(string name);
    }
}