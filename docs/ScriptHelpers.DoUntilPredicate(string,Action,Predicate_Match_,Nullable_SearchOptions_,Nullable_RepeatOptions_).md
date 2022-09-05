#### [Portal](index.md 'index')
### [Portal.Utility](Portal.Utility.md 'Portal.Utility').[ScriptHelpers](ScriptHelpers.md 'Portal.Utility.ScriptHelpers')

## ScriptHelpers.DoUntilPredicate(string, Action, Predicate<Match>, Nullable<SearchOptions>, Nullable<RepeatOptions>) Method

Repeatedly executes the given action until the specified predicate is true, synchronously.

```csharp
public static (Portal.ImageDetection.Match? Match,bool bPredicateResult) DoUntilPredicate(string InTemplateName, System.Action? InAction, System.Predicate<Portal.ImageDetection.Match?> InPredicate, System.Nullable<Portal.ImageDetection.SearchOptions> InSearchOptions=null, System.Nullable<Portal.ImageDetection.RepeatOptions> InRepeatOptions=null);
```
#### Parameters

<a name='Portal.Utility.ScriptHelpers.DoUntilPredicate(string,System.Action,System.Predicate_Portal.ImageDetection.Match_,System.Nullable_Portal.ImageDetection.SearchOptions_,System.Nullable_Portal.ImageDetection.RepeatOptions_).InTemplateName'></a>

`InTemplateName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Portal.Utility.ScriptHelpers.DoUntilPredicate(string,System.Action,System.Predicate_Portal.ImageDetection.Match_,System.Nullable_Portal.ImageDetection.SearchOptions_,System.Nullable_Portal.ImageDetection.RepeatOptions_).InAction'></a>

`InAction` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

<a name='Portal.Utility.ScriptHelpers.DoUntilPredicate(string,System.Action,System.Predicate_Portal.ImageDetection.Match_,System.Nullable_Portal.ImageDetection.SearchOptions_,System.Nullable_Portal.ImageDetection.RepeatOptions_).InPredicate'></a>

`InPredicate` [System.Predicate&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')[Match](Match.md 'Portal.ImageDetection.Match')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')

<a name='Portal.Utility.ScriptHelpers.DoUntilPredicate(string,System.Action,System.Predicate_Portal.ImageDetection.Match_,System.Nullable_Portal.ImageDetection.SearchOptions_,System.Nullable_Portal.ImageDetection.RepeatOptions_).InSearchOptions'></a>

`InSearchOptions` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[SearchOptions](SearchOptions.md 'Portal.ImageDetection.SearchOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

<a name='Portal.Utility.ScriptHelpers.DoUntilPredicate(string,System.Action,System.Predicate_Portal.ImageDetection.Match_,System.Nullable_Portal.ImageDetection.SearchOptions_,System.Nullable_Portal.ImageDetection.RepeatOptions_).InRepeatOptions'></a>

`InRepeatOptions` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[RepeatOptions](RepeatOptions.md 'Portal.ImageDetection.RepeatOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

#### Returns
[&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[Match](Match.md 'Portal.ImageDetection.Match')[,](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')  
Returns the first or the best match found depending on search options, and the predicate result.