using System;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using WizardFramework.Core;

namespace WizardUnitTests
{
    public class TestsContext
    {
        private BaseWizardContextFactory _contextFactory;
        private BaseWizardStepsFactory _stepsFactory;

        [SetUp]
        public void SetUp()
        {
            // TODO: Initialize context factory here.
            _contextFactory = new ContextFactory();
            _stepsFactory = new StepsFactory();
        }

        [Test]
        public void TestCreateContext()
        {
            var context = _contextFactory.CreateContext();
            Assert.IsNotNull(context);
        }

        [Test]
        public void TestStartContext()
        {
            var testCounter = 0;
            var context = _contextFactory.CreateContext();
            var step = _stepsFactory.CreateNewStep(context);
            step.WhenSuccess(() => testCounter++);
            context.AddStep(step);
            context.Start();

            Assert.IsTrue(testCounter > 0);
        }

        [Test]
        public void TestStopContext()
        {
            var testCounter = 0;
            var context = _contextFactory.CreateContext();
            var step = _stepsFactory.CreateNewStep(context);
            step.WhenSuccess(() => testCounter++);
            context.AddStep(step);
            context.AddStep(step);
            context.AddStep(step);
            context.AddStep(step);
            context.AddStep(step);

            context.Start();
            context.Stop();

            Assert.IsTrue(testCounter == 0);
        }

        [Test]
        public void TestAddStep()
        {
            var testCounter = 0;
            var context = _contextFactory.CreateContext();
            var step = _stepsFactory.CreateNewStep(context);
            step.WhenSuccess(() => testCounter++);
            context.AddStep(step);
            context.Start();

            Assert.IsTrue(testCounter > 0);
        }

        [Test]
        public void TestAddInvalidStep()
        {
            var context = _contextFactory.CreateContext();
            Assert.Throws<ArgumentNullException>(() => context.AddStep(null));
        }

        [Test]
        public void TestRemoveStep()
        {
            var context = _contextFactory.CreateContext();
            var step = _stepsFactory.CreateNewStep(context);
            context.AddStep(step);
            context.AddStep(step);
            context.AddStep(step);
            context.AddStep(step);
            context.AddStep(step);

            context.RemoveStep(step);

            Assert.IsTrue(context.Count == 0);
        }

        [Test]
        public void TestRemoveInvalidStep()
        {
            var context = _contextFactory.CreateContext();
            Assert.Throws<ArgumentNullException>(() => context.RemoveStep(null));
        }

        [Test]
        public void TestGetStep()
        {
            var context = _contextFactory.CreateContext();
            var step = _stepsFactory.CreateNewStep(context);
            step.Name = "TestStep";
            context.AddStep(step);
            
            Assert.IsNotNull(context.GetStep("TestStep"));
        }

        [Test]
        public void TestGetInvalidStep()
        {
            var context = _contextFactory.CreateContext();
            Assert.Throws<InvalidOperationException>(() => context.GetStep("blablabla"));
        }
    }
}