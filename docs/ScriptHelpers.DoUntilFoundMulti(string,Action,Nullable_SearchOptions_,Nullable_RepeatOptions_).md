#### [Portal](index.md 'index')
### [Portal.Utility](Portal.Utility.md 'Portal.Utility').[ScriptHelpers](ScriptHelpers.md 'Portal.Utility.ScriptHelpers')

## ScriptHelpers.DoUntilFoundMulti(string, Action, Nullable<SearchOptions>, Nullable<RepeatOptions>) Method

Repeatedly executes the given action until the template is found, synchronously.

```csharp
public static System.Collections.Generic.List<Portal.Detection.Match>? DoUntilFoundMulti(string InTemplateName, System.Action? InAction, System.Nullable<Portal.Detection.SearchOptions> InSearchOptions=null, System.Nullable<Portal.Detection.RepeatOptions> InRepeatOptions=null);
```
#### Parameters

<a name='Portal.Utility.ScriptHelpers.DoUntilFoundMulti(string,System.Action,System.Nullable_Portal.Detection.SearchOptions_,System.Nullable_Portal.Detection.RepeatOptions_).InTemplateName'></a>

`InTemplateName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Portal.Utility.ScriptHelpers.DoUntilFoundMulti(string,System.Action,System.Nullable_Portal.Detection.SearchOptions_,System.Nullable_Portal.Detection.RepeatOptions_).InAction'></a>

`InAction` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

<a name='Portal.Utility.ScriptHelpers.DoUntilFoundMulti(string,System.Action,System.Nullable_Portal.Detection.SearchOptions_,System.Nullable_Portal.Detection.RepeatOptions_).InSearchOptions'></a>

`InSearchOptions` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[SearchOptions](SearchOptions.md 'Portal.Detection.SearchOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

<a name='Portal.Utility.ScriptHelpers.DoUntilFoundMulti(string,System.Action,System.Nullable_Portal.Detection.SearchOptions_,System.Nullable_Portal.Detection.RepeatOptions_).InRepeatOptions'></a>

`InRepeatOptions` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[RepeatOptions](RepeatOptions.md 'Portal.Detection.RepeatOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Match](Match.md 'Portal.Detection.Match')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
Returns all matches found.

### Example
Example usage:  
  
```csharp  
int MyVar = 0;  
var MatchesFound = DoUntilFoundMulti("MyTemplateName", () =>  
{  
    MyVar++;  
}, new GameRegion(0, 0, 1920, 1080), new RepeatOptions(100, 0));  
```  
The above tries to find the template "MyTemplateName" and executes an action each try until it is found.  
It has [SearchOptions](SearchOptions.md 'Portal.Detection.SearchOptions') of a default screen resolution, and [RepeatOptions](RepeatOptions.md 'Portal.Detection.RepeatOptions') that says it shall repeat 100 times with 0ms between each try, stopping when matches are found.