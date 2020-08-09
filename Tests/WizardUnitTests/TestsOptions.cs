using System;
using System.Runtime.InteropServices.ComTypes;
using System.Xml.Xsl;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using WizardFramework.Core;

namespace WizardUnitTests
{
    /// <summary>
    /// Single option unit tests.
    /// </summary>
    public class TestsOptions
    {
        private BaseWizardOptionFactory _optionsFactory;

        [SetUp]
        public void Setup()
        {
            _optionsFactory = new OptionsFactory();
        }

        [Test]
        public void TestCreateSingleOption()
        {
            var option = _optionsFactory.CreateSingleOption<string>("Name");
            Assert.IsNotNull(option);
        }

        [Test]
        public void TestCreateNullOption()
        {
            Assert.Throws<ArgumentNullException>(() => _optionsFactory.CreateSingleOption<string>(null));
        }

        [Test]
        public void TestCreateValidatedOption()
        {
            var option =
                _optionsFactory.CreateSingleValidatedOption<string>("TestOption", s => !string.IsNullOrEmpty(s));
            Assert.IsNotNull(option);
        }
    }
}