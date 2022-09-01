#### [Portal](index.md 'index')
### [Portal.Utility](Portal.Utility.md 'Portal.Utility').[ScriptHelpers](Portal.Utility.ScriptHelpers.md 'Portal.Utility.ScriptHelpers')

## ScriptHelpers.DoUntilFound_Async(SearchOptions, Action, Nullable<RepeatOptions>) Method

Repeatedly executes the given action until the given search options are found, asynchronously.

```csharp
public static System.Threading.Tasks.Task<Portal.ImageDetection.Match?> DoUntilFound_Async(Portal.ImageDetection.SearchOptions InSearchOptions, System.Action? InAction, System.Nullable<Portal.ImageDetection.RepeatOptions> InRepeatOptions=null);
```
#### Parameters

<a name='Portal.Utility.ScriptHelpers.DoUntilFound_Async(Portal.ImageDetection.SearchOptions,System.Action,System.Nullable_Portal.ImageDetection.RepeatOptions_).InSearchOptions'></a>

`InSearchOptions` [SearchOptions](Portal.ImageDetection.SearchOptions.md 'Portal.ImageDetection.SearchOptions')

Options for the search.

<a name='Portal.Utility.ScriptHelpers.DoUntilFound_Async(Portal.ImageDetection.SearchOptions,System.Action,System.Nullable_Portal.ImageDetection.RepeatOptions_).InAction'></a>

`InAction` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Action to perform.

<a name='Portal.Utility.ScriptHelpers.DoUntilFound_Async(Portal.ImageDetection.SearchOptions,System.Action,System.Nullable_Portal.ImageDetection.RepeatOptions_).InRepeatOptions'></a>

`InRepeatOptions` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[RepeatOptions](Portal.ImageDetection.RepeatOptions.md 'Portal.ImageDetection.RepeatOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

This is an optional parameter that allows you to specify how many times you want to repeat the action.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[Match](Portal.ImageDetection.Match.md 'Portal.ImageDetection.Match')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
Returns the first match found.