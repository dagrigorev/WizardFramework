using System;
using System.Diagnostics.SymbolStore;
using NUnit.Framework;
using WizardFramework.Abstractions;
using WizardFramework.Core;

namespace WizardUnitTests
{
    /// <summary>
    /// Wizard steps factory.
    /// </summary>
    public class TestsSteps
    {
        private BaseWizardStepsFactory _stepsFactory;
        private IWizardContext _context;

        [SetUp]
        public void SetUp()
        {
            // TODO: Initialize steps factory and context here here.
            _stepsFactory = new StepsFactory();
            _context = new WizardContext();
        }

        [Test]
        public void TestCreateSingleStep()
        {
            var step = _stepsFactory.CreateNewStep(_context);
            Assert.IsNotNull(step);
        }

        [Test]
        public void TestCreateInvalidStep()
        {
            Assert.Throws<ArgumentNullException>(() => _stepsFactory.CreateNewStep(null));
        }

        [Test]
        public void TestCreateInfiniteErrorStep()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void TestCreateSkippableStep()
        {
            var step = _stepsFactory.CreateSkippableStep(_context);
            Assert.IsNotNull(step);
        }

        [Test]
        public void TestCreateAcceptableStep()
        {
            var step = _stepsFactory.CreateAcceptableStep(_context);
            Assert.IsNotNull(step);
        }

        [Test]
        public void TestDoSingleStep()
        {
            var testCounter = 0;
            var step = _stepsFactory.CreateNewStep(_context);
            step.WhenSuccess(() => testCounter++);

            Assert.IsTrue(testCounter > 0);
        }

        [Test]
        public void TestUnDoSingleStep()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void TestDoStepWithRequiredOption()
        {
            var testCounter = 0;
            var step = _stepsFactory.CreateNewStep(_context);
            step.LocalConfiguration.IsAcceptable.Value = true;
            step.WhenError(e => testCounter++);
            Assert.IsTrue(testCounter > 0);
        }
    }
}