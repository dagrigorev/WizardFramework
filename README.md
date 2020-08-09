# WizardFramework
Simple wizard framework that helps you to create complex wizard dialogs (gui or console) quickly.

Based on [TaskPipeline](https://github.com/dagrigorev/TaskPipeline.git).
*This library is not ready yet.*

## Simple usage

    // create factories
    var contextFactory = new ContextFactory();
    var stepsFactory = new StepsFactory();

    // create context
    var context = contextFactory.CreateContext();
    
    // create new step
    var step = stepsFactory.CreateNewStep(context);
    
    // add step to context
    context.AddStep(step);

    // start wizard
    context.Start();

## Requirements

* [NET Standard](https://dotnet.microsoft.com/download) (2.1 or higher)
* [TasksPipeline.Abstractions](https://www.nuget.org/packages/TasksPipeline.Abstractions/) (1.0.0 or higher)
* [TasksPipeline.Default](https://www.nuget.org/packages/TasksPipeline.Default/) (1.0.0 or higher)

---

## P.S.

*If you have any ideas or propositions, please, text me or leave a comment* :)
