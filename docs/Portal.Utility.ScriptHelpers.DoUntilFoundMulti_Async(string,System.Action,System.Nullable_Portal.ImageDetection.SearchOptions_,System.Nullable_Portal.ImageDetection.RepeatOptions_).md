#### [Portal](index.md 'index')
### [Portal.Utility](Portal.Utility.md 'Portal.Utility').[ScriptHelpers](Portal.Utility.ScriptHelpers.md 'Portal.Utility.ScriptHelpers')

## ScriptHelpers.DoUntilFoundMulti_Async(string, Action, Nullable<SearchOptions>, Nullable<RepeatOptions>) Method

Repeatedly executes the given action until the template is found, asynchronously.

```csharp
public static System.Threading.Tasks.Task<System.Collections.Generic.List<Portal.ImageDetection.Match>> DoUntilFoundMulti_Async(string InTemplateName, System.Action? InAction, System.Nullable<Portal.ImageDetection.SearchOptions> InSearchOptions=null, System.Nullable<Portal.ImageDetection.RepeatOptions> InRepeatOptions=null);
```
#### Parameters

<a name='Portal.Utility.ScriptHelpers.DoUntilFoundMulti_Async(string,System.Action,System.Nullable_Portal.ImageDetection.SearchOptions_,System.Nullable_Portal.ImageDetection.RepeatOptions_).InTemplateName'></a>

`InTemplateName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Portal.Utility.ScriptHelpers.DoUntilFoundMulti_Async(string,System.Action,System.Nullable_Portal.ImageDetection.SearchOptions_,System.Nullable_Portal.ImageDetection.RepeatOptions_).InAction'></a>

`InAction` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

<a name='Portal.Utility.ScriptHelpers.DoUntilFoundMulti_Async(string,System.Action,System.Nullable_Portal.ImageDetection.SearchOptions_,System.Nullable_Portal.ImageDetection.RepeatOptions_).InSearchOptions'></a>

`InSearchOptions` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[SearchOptions](Portal.ImageDetection.SearchOptions.md 'Portal.ImageDetection.SearchOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

<a name='Portal.Utility.ScriptHelpers.DoUntilFoundMulti_Async(string,System.Action,System.Nullable_Portal.ImageDetection.SearchOptions_,System.Nullable_Portal.ImageDetection.RepeatOptions_).InRepeatOptions'></a>

`InRepeatOptions` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[RepeatOptions](Portal.ImageDetection.RepeatOptions.md 'Portal.ImageDetection.RepeatOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Match](Portal.ImageDetection.Match.md 'Portal.ImageDetection.Match')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
Returns all matches found depending on search options.