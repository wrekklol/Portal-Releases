#### [Portal](index.md 'index')
### [Portal.Utility](Portal.Utility.md 'Portal.Utility').[ScriptHelpers](ScriptHelpers.md 'Portal.Utility.ScriptHelpers')

## ScriptHelpers.DoUntilPredicate_Async(string, Action, Predicate<Match>, Nullable<SearchOptions>, Nullable<RepeatOptions>) Method

Repeatedly executes the given action until the specified predicate is true, asynchronously.

```csharp
public static System.Threading.Tasks.Task<(Portal.Detection.Match? Match,bool bPredicateResult)> DoUntilPredicate_Async(string InTemplateName, System.Action? InAction, System.Predicate<Portal.Detection.Match?> InPredicate, System.Nullable<Portal.Detection.SearchOptions> InSearchOptions=null, System.Nullable<Portal.Detection.RepeatOptions> InRepeatOptions=null);
```
#### Parameters

<a name='Portal.Utility.ScriptHelpers.DoUntilPredicate_Async(string,System.Action,System.Predicate_Portal.Detection.Match_,System.Nullable_Portal.Detection.SearchOptions_,System.Nullable_Portal.Detection.RepeatOptions_).InTemplateName'></a>

`InTemplateName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Portal.Utility.ScriptHelpers.DoUntilPredicate_Async(string,System.Action,System.Predicate_Portal.Detection.Match_,System.Nullable_Portal.Detection.SearchOptions_,System.Nullable_Portal.Detection.RepeatOptions_).InAction'></a>

`InAction` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

<a name='Portal.Utility.ScriptHelpers.DoUntilPredicate_Async(string,System.Action,System.Predicate_Portal.Detection.Match_,System.Nullable_Portal.Detection.SearchOptions_,System.Nullable_Portal.Detection.RepeatOptions_).InPredicate'></a>

`InPredicate` [System.Predicate&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')[Match](Match.md 'Portal.Detection.Match')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')

<a name='Portal.Utility.ScriptHelpers.DoUntilPredicate_Async(string,System.Action,System.Predicate_Portal.Detection.Match_,System.Nullable_Portal.Detection.SearchOptions_,System.Nullable_Portal.Detection.RepeatOptions_).InSearchOptions'></a>

`InSearchOptions` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[SearchOptions](SearchOptions.md 'Portal.Detection.SearchOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

<a name='Portal.Utility.ScriptHelpers.DoUntilPredicate_Async(string,System.Action,System.Predicate_Portal.Detection.Match_,System.Nullable_Portal.Detection.SearchOptions_,System.Nullable_Portal.Detection.RepeatOptions_).InRepeatOptions'></a>

`InRepeatOptions` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[RepeatOptions](RepeatOptions.md 'Portal.Detection.RepeatOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[Match](Match.md 'Portal.Detection.Match')[,](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
Returns the best match found, and the predicate result.