#### [Portal](index.md 'index')
### [Portal.Utility](Portal.Utility.md 'Portal.Utility').[ScriptHelpers](ScriptHelpers.md 'Portal.Utility.ScriptHelpers')

## ScriptHelpers.WaitUntilFound(string, Nullable<SearchOptions>, Nullable<RepeatOptions>) Method

Waits until the template is found.

```csharp
public static Portal.Detection.Match? WaitUntilFound(string InTemplateName, System.Nullable<Portal.Detection.SearchOptions> InSearchOptions=null, System.Nullable<Portal.Detection.RepeatOptions> InRepeatOptions=null);
```
#### Parameters

<a name='Portal.Utility.ScriptHelpers.WaitUntilFound(string,System.Nullable_Portal.Detection.SearchOptions_,System.Nullable_Portal.Detection.RepeatOptions_).InTemplateName'></a>

`InTemplateName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Portal.Utility.ScriptHelpers.WaitUntilFound(string,System.Nullable_Portal.Detection.SearchOptions_,System.Nullable_Portal.Detection.RepeatOptions_).InSearchOptions'></a>

`InSearchOptions` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[SearchOptions](SearchOptions.md 'Portal.Detection.SearchOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

<a name='Portal.Utility.ScriptHelpers.WaitUntilFound(string,System.Nullable_Portal.Detection.SearchOptions_,System.Nullable_Portal.Detection.RepeatOptions_).InRepeatOptions'></a>

`InRepeatOptions` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[RepeatOptions](RepeatOptions.md 'Portal.Detection.RepeatOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

#### Returns
[Match](Match.md 'Portal.Detection.Match')  
Returns the best match found.