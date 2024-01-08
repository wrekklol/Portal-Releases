#### [Portal](index.md 'index')
### [Portal.Script](Portal.Script.md 'Portal.Script')

## ScriptManager Class

Manages all script modules and behaviors.

```csharp
public class ScriptManager : Portal.Singleton<Portal.Script.ScriptManager>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Portal.Singleton&lt;](https://docs.microsoft.com/en-us/dotnet/api/Portal.Singleton-1 'Portal.Singleton`1')[ScriptManager](ScriptManager.md 'Portal.Script.ScriptManager')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Portal.Singleton-1 'Portal.Singleton`1') &#129106; ScriptManager

| Properties | |
| :--- | :--- |
| [Modules](ScriptManager.Modules.md 'Portal.Script.ScriptManager.Modules') | All loaded script modules. |
| [ScriptThread](ScriptManager.ScriptThread.md 'Portal.Script.ScriptManager.ScriptThread') | Main script worker, responsible for starting, running and stopping the script. |
| [SelectedBehavior](ScriptManager.SelectedBehavior.md 'Portal.Script.ScriptManager.SelectedBehavior') | The currently selected script behavior. |
| [SelectedModule](ScriptManager.SelectedModule.md 'Portal.Script.ScriptManager.SelectedModule') | The currently selected script module. |

| Methods | |
| :--- | :--- |
| [CanStartScript()](ScriptManager.CanStartScript().md 'Portal.Script.ScriptManager.CanStartScript()') | Checks if the currently selected script module and behavior are valid and can be started. |
| [GetBehaviorIndex(string)](ScriptManager.GetBehaviorIndex(string).md 'Portal.Script.ScriptManager.GetBehaviorIndex(string)') | Gets the index of the given behavior. |
| [GetModuleIndex(string)](ScriptManager.GetModuleIndex(string).md 'Portal.Script.ScriptManager.GetModuleIndex(string)') | Gets the index of the given module. |
| [IsBehaviorSelected(int)](ScriptManager.IsBehaviorSelected(int).md 'Portal.Script.ScriptManager.IsBehaviorSelected(int)') | Checks if the given behavior is selected. |
| [IsBehaviorSelected(string)](ScriptManager.IsBehaviorSelected(string).md 'Portal.Script.ScriptManager.IsBehaviorSelected(string)') | Checks if the given behavior is selected. |
| [IsModuleSelected(int)](ScriptManager.IsModuleSelected(int).md 'Portal.Script.ScriptManager.IsModuleSelected(int)') | Checks if the given module is selected. |
| [IsModuleSelected(string)](ScriptManager.IsModuleSelected(string).md 'Portal.Script.ScriptManager.IsModuleSelected(string)') | Checks if the given module is selected. |
| [IsScriptRunning(bool)](ScriptManager.IsScriptRunning(bool).md 'Portal.Script.ScriptManager.IsScriptRunning(bool)') | Checks if the script is running. |
| [SetScriptBehavior(string)](ScriptManager.SetScriptBehavior(string).md 'Portal.Script.ScriptManager.SetScriptBehavior(string)') | Sets the currently selected script behavior. |
| [SetScriptModule(string)](ScriptManager.SetScriptModule(string).md 'Portal.Script.ScriptManager.SetScriptModule(string)') | Sets the currently selected script module. |
| [StartScript()](ScriptManager.StartScript().md 'Portal.Script.ScriptManager.StartScript()') | Starts the script. |
| [StopScript()](ScriptManager.StopScript().md 'Portal.Script.ScriptManager.StopScript()') | Stops the script. |
| [ToggleScript()](ScriptManager.ToggleScript().md 'Portal.Script.ScriptManager.ToggleScript()') | Toggles the script. |
