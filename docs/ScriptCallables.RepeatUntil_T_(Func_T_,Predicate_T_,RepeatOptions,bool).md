#### [Portal](index.md 'index')
### [Portal.Script](Portal.Script.md 'Portal.Script').[ScriptCallables](ScriptCallables.md 'Portal.Script.ScriptCallables')

## ScriptCallables.RepeatUntil<T>(Func<T>, Predicate<T>, RepeatOptions, bool) Method

Repeats specified action, for a specified amount of loops, until predicate is true.

```csharp
public static System.Threading.Tasks.Task<T?> RepeatUntil<T>(System.Func<T?> InAction, System.Predicate<T?> InPredicate, Portal.Detect.RepeatOptions InRepeatOptions, bool InbForce=false);
```
#### Type parameters

<a name='Portal.Script.ScriptCallables.RepeatUntil_T_(System.Func_T_,System.Predicate_T_,Portal.Detect.RepeatOptions,bool).T'></a>

`T`
#### Parameters

<a name='Portal.Script.ScriptCallables.RepeatUntil_T_(System.Func_T_,System.Predicate_T_,Portal.Detect.RepeatOptions,bool).InAction'></a>

`InAction` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](ScriptCallables.RepeatUntil_T_(Func_T_,Predicate_T_,RepeatOptions,bool).md#Portal.Script.ScriptCallables.RepeatUntil_T_(System.Func_T_,System.Predicate_T_,Portal.Detect.RepeatOptions,bool).T 'Portal.Script.ScriptCallables.RepeatUntil<T>(System.Func<T>, System.Predicate<T>, Portal.Detect.RepeatOptions, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Action to repeat.

<a name='Portal.Script.ScriptCallables.RepeatUntil_T_(System.Func_T_,System.Predicate_T_,Portal.Detect.RepeatOptions,bool).InPredicate'></a>

`InPredicate` [System.Predicate&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')[T](ScriptCallables.RepeatUntil_T_(Func_T_,Predicate_T_,RepeatOptions,bool).md#Portal.Script.ScriptCallables.RepeatUntil_T_(System.Func_T_,System.Predicate_T_,Portal.Detect.RepeatOptions,bool).T 'Portal.Script.ScriptCallables.RepeatUntil<T>(System.Func<T>, System.Predicate<T>, Portal.Detect.RepeatOptions, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')

Predicate to check.

<a name='Portal.Script.ScriptCallables.RepeatUntil_T_(System.Func_T_,System.Predicate_T_,Portal.Detect.RepeatOptions,bool).InRepeatOptions'></a>

`InRepeatOptions` [RepeatOptions](RepeatOptions.md 'Portal.Detect.RepeatOptions')

Options for repeating.

<a name='Portal.Script.ScriptCallables.RepeatUntil_T_(System.Func_T_,System.Predicate_T_,Portal.Detect.RepeatOptions,bool).InbForce'></a>

`InbForce` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

If true, will run even when script is stopped.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](ScriptCallables.RepeatUntil_T_(Func_T_,Predicate_T_,RepeatOptions,bool).md#Portal.Script.ScriptCallables.RepeatUntil_T_(System.Func_T_,System.Predicate_T_,Portal.Detect.RepeatOptions,bool).T 'Portal.Script.ScriptCallables.RepeatUntil<T>(System.Func<T>, System.Predicate<T>, Portal.Detect.RepeatOptions, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')