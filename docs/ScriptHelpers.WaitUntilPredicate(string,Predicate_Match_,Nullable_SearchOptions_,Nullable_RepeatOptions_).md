#### [Portal](index.md 'index')
### [Portal.Utility](Portal.Utility.md 'Portal.Utility').[ScriptHelpers](ScriptHelpers.md 'Portal.Utility.ScriptHelpers')

## ScriptHelpers.WaitUntilPredicate(string, Predicate<Match>, Nullable<SearchOptions>, Nullable<RepeatOptions>) Method

Waits until the specified predicate is true.

```csharp
public static (Portal.Detection.Match? Match,bool bPredicateResult) WaitUntilPredicate(string InTemplateName, System.Predicate<Portal.Detection.Match?> InPredicate, System.Nullable<Portal.Detection.SearchOptions> InSearchOptions=null, System.Nullable<Portal.Detection.RepeatOptions> InRepeatOptions=null);
```
#### Parameters

<a name='Portal.Utility.ScriptHelpers.WaitUntilPredicate(string,System.Predicate_Portal.Detection.Match_,System.Nullable_Portal.Detection.SearchOptions_,System.Nullable_Portal.Detection.RepeatOptions_).InTemplateName'></a>

`InTemplateName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Portal.Utility.ScriptHelpers.WaitUntilPredicate(string,System.Predicate_Portal.Detection.Match_,System.Nullable_Portal.Detection.SearchOptions_,System.Nullable_Portal.Detection.RepeatOptions_).InPredicate'></a>

`InPredicate` [System.Predicate&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')[Match](Match.md 'Portal.Detection.Match')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')

<a name='Portal.Utility.ScriptHelpers.WaitUntilPredicate(string,System.Predicate_Portal.Detection.Match_,System.Nullable_Portal.Detection.SearchOptions_,System.Nullable_Portal.Detection.RepeatOptions_).InSearchOptions'></a>

`InSearchOptions` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[SearchOptions](SearchOptions.md 'Portal.Detection.SearchOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

<a name='Portal.Utility.ScriptHelpers.WaitUntilPredicate(string,System.Predicate_Portal.Detection.Match_,System.Nullable_Portal.Detection.SearchOptions_,System.Nullable_Portal.Detection.RepeatOptions_).InRepeatOptions'></a>

`InRepeatOptions` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[RepeatOptions](RepeatOptions.md 'Portal.Detection.RepeatOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

#### Returns
[&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[Match](Match.md 'Portal.Detection.Match')[,](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')  
Returns the best match found, and the predicate result.

### Example
Example usage:  
  
```csharp  
var (MatchFound, bPredicateResult) = WaitUntilPredicate("MyTemplateName", match => match != null, new GameRegion(0, 0, 1920, 1080), new RepeatOptions(100, 0));  
```  
The above tries to find the template "MyTemplateName" until the predicate is true, which it is when a match is found.  
It has [SearchOptions](SearchOptions.md 'Portal.Detection.SearchOptions') of a default screen resolution, and [RepeatOptions](RepeatOptions.md 'Portal.Detection.RepeatOptions') that says it shall repeat 100 times with 0ms between each try, stopping when the predicate is true.