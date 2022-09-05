#### [Portal](index.md 'index')
### [Portal.Scripting](Portal.Scripting.md 'Portal.Scripting')

## IScriptBehaviour Interface

This interface is what all behaviours should inherit from.

```csharp
public interface IScriptBehaviour
```

| Properties | |
| :--- | :--- |
| [LoopAmount](IScriptBehaviour.LoopAmount.md 'Portal.Scripting.IScriptBehaviour.LoopAmount') | Amount of times behaviour([Run()](IScriptBehaviour.Run().md 'Portal.Scripting.IScriptBehaviour.Run()') function) will loop, can be overridden.<br/>A value of -1 will loop infinitely.<br/><br/>Default value is 1. |

| Methods | |
| :--- | :--- |
| [Init()](IScriptBehaviour.Init().md 'Portal.Scripting.IScriptBehaviour.Init()') | Initialization function, must be overridden.<br/><br/>Gets called when its owning module is initializing. |
| [Run()](IScriptBehaviour.Run().md 'Portal.Scripting.IScriptBehaviour.Run()') | Run function, must be overridden.<br/>           <br/>           Gets called when its owning module is running, for example by pressing the "Run Behaviour" button in the GUI. |
