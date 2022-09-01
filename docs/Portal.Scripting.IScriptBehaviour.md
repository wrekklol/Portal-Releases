#### [Portal](index.md 'index')
### [Portal.Scripting](Portal.Scripting.md 'Portal.Scripting')

## IScriptBehaviour Interface

This interface is what all behaviours should inherit from.

```csharp
public interface IScriptBehaviour
```

| Properties | |
| :--- | :--- |
| [BehaviourName](Portal.Scripting.IScriptBehaviour.BehaviourName.md 'Portal.Scripting.IScriptBehaviour.BehaviourName') | Behaviour name, must be overridden. |
| [LoopAmount](Portal.Scripting.IScriptBehaviour.LoopAmount.md 'Portal.Scripting.IScriptBehaviour.LoopAmount') | Amount of times behaviour([Run()](Portal.Scripting.IScriptBehaviour.Run().md 'Portal.Scripting.IScriptBehaviour.Run()') function) will loop, must be inherited.<br/>A value of -1 will loop infinitely.<br/><br/>Default value is 1. |

| Methods | |
| :--- | :--- |
| [Init()](Portal.Scripting.IScriptBehaviour.Init().md 'Portal.Scripting.IScriptBehaviour.Init()') | Initialization function, must be overridden.<br/><br/>Gets called when its owning module is initializing. |
| [Run()](Portal.Scripting.IScriptBehaviour.Run().md 'Portal.Scripting.IScriptBehaviour.Run()') | Run function, must be overridden.<br/>           <br/>           Gets called when its owning module is running, for example by pressing the "Run Behaviour" button in the GUI. |
