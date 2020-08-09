using System;
using Microsoft.VisualBasic.CompilerServices;
using WizardFramework.Abstractions;
using Pipeline;
using Pipeline.Exceptions;

namespace WizardFramework.Core
{
    public class SingleStep : IWizardStep
    {
        private Action _continueAction;
        private Action _successAction;
        private Action<PipelineItemExecutionException> _errorAction;

        public Guid Id { get; }
        public string Name { get; set; }
        public IWizardContext Context { get; }
        public IWizardStepConfiguration LocalConfiguration { get; }

        public SingleStep(IWizardContext context, string name)
        {
            if(context == null) throw new ArgumentNullException();

            Context = context;
            Name = name;
            Id = Guid.NewGuid();
        }

        public void ContinueWith(Action action)
        {
            _continueAction = action;
        }

        public void WhenSuccess(Action action)
        {
            _successAction = action;
        }

        public void WhenError(Action<PipelineItemExecutionException> action)
        {
            _errorAction = action;
        }

        public void Execute()
        {
            try
            {
                // TODO: Execute step here.
                _successAction?.Invoke();
            }
            catch (Exception ex)
            {
                _errorAction?.Invoke(new PipelineItemExecutionException(ex));
            }

            _continueAction?.Invoke();
        }

        public void Execute(object[] args)
        {
            Execute();
        }

        public void Do()
        {
            Execute();
        }

        public void UnDo()
        {
            throw new NotImplementedException();
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}