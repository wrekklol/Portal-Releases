#### [Portal](index.md 'index')
### [Portal.Script](Portal.Script.md 'Portal.Script')

## ScriptBehavior Class

This is what all script behaviors should inherit from.

```csharp
public abstract class ScriptBehavior
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ScriptBehavior

Derived  
&#8627; [PythonBehavior](PythonBehavior.md 'Portal.Script.Languages.PythonBehavior')

| Properties | |
| :--- | :--- |
| [LoopAmount](ScriptBehavior.LoopAmount.md 'Portal.Script.ScriptBehavior.LoopAmount') | Amount of times behavior([Run()](ScriptBehavior.Run().md 'Portal.Script.ScriptBehavior.Run()') function) will loop, can be overridden.<br/>A value of -1 will loop infinitely.<br/><br/>Default value is 1. |
| [Name](ScriptBehavior.Name.md 'Portal.Script.ScriptBehavior.Name') | Name of the behavior.<br/>Should be unique, should only be set if you know what you're doing. |

| Methods | |
| :--- | :--- |
| [Clear()](ScriptBehavior.Clear().md 'Portal.Script.ScriptBehavior.Clear()') | Clear function.<br/><br/>Gets called when its Behavior is changed, and it needs to clear its state. |
| [Init()](ScriptBehavior.Init().md 'Portal.Script.ScriptBehavior.Init()') | Initialization function.<br/><br/>Gets called when its owning module is initializing. |
| [Run()](ScriptBehavior.Run().md 'Portal.Script.ScriptBehavior.Run()') | Run function.<br/><br/>Gets called when its Behavior is running, for example by pressing the "Run Behavior" button in the GUI. |
| [Start()](ScriptBehavior.Start().md 'Portal.Script.ScriptBehavior.Start()') | Start function.<br/><br/>Gets called when its Behavior is started. |
| [Stop()](ScriptBehavior.Stop().md 'Portal.Script.ScriptBehavior.Stop()') | Stop function.<br/><br/>Gets called when its Behavior is stopped. |
