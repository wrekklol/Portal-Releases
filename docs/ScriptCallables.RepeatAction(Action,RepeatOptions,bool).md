#### [Portal](index.md 'index')
### [Portal.Script](Portal.Script.md 'Portal.Script').[ScriptCallables](ScriptCallables.md 'Portal.Script.ScriptCallables')

## ScriptCallables.RepeatAction(Action, RepeatOptions, bool) Method

Repeats specified action, for a specified amount of loops.

```csharp
public static System.Threading.Tasks.Task RepeatAction(System.Action InAction, Portal.Detect.RepeatOptions InRepeatOptions, bool InbForce=false);
```
#### Parameters

<a name='Portal.Script.ScriptCallables.RepeatAction(System.Action,Portal.Detect.RepeatOptions,bool).InAction'></a>

`InAction` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Action to repeat.

<a name='Portal.Script.ScriptCallables.RepeatAction(System.Action,Portal.Detect.RepeatOptions,bool).InRepeatOptions'></a>

`InRepeatOptions` [RepeatOptions](RepeatOptions.md 'Portal.Detect.RepeatOptions')

Options for repeating.

<a name='Portal.Script.ScriptCallables.RepeatAction(System.Action,Portal.Detect.RepeatOptions,bool).InbForce'></a>

`InbForce` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

If true, will run even when script is stopped.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')