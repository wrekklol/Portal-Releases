#### [Portal](index.md 'index')
### [Portal.Utility](Portal.Utility.md 'Portal.Utility').[ScriptHelpers](Portal.Utility.ScriptHelpers.md 'Portal.Utility.ScriptHelpers')

## ScriptHelpers.WaitUntilFound(string, Nullable<SearchOptions>, Nullable<RepeatOptions>) Method

Waits until the template is found.

```csharp
public static Portal.ImageDetection.Match? WaitUntilFound(string InTemplateName, System.Nullable<Portal.ImageDetection.SearchOptions> InSearchOptions=null, System.Nullable<Portal.ImageDetection.RepeatOptions> InRepeatOptions=null);
```
#### Parameters

<a name='Portal.Utility.ScriptHelpers.WaitUntilFound(string,System.Nullable_Portal.ImageDetection.SearchOptions_,System.Nullable_Portal.ImageDetection.RepeatOptions_).InTemplateName'></a>

`InTemplateName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Portal.Utility.ScriptHelpers.WaitUntilFound(string,System.Nullable_Portal.ImageDetection.SearchOptions_,System.Nullable_Portal.ImageDetection.RepeatOptions_).InSearchOptions'></a>

`InSearchOptions` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[SearchOptions](Portal.ImageDetection.SearchOptions.md 'Portal.ImageDetection.SearchOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

<a name='Portal.Utility.ScriptHelpers.WaitUntilFound(string,System.Nullable_Portal.ImageDetection.SearchOptions_,System.Nullable_Portal.ImageDetection.RepeatOptions_).InRepeatOptions'></a>

`InRepeatOptions` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[RepeatOptions](Portal.ImageDetection.RepeatOptions.md 'Portal.ImageDetection.RepeatOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

#### Returns
[Match](Portal.ImageDetection.Match.md 'Portal.ImageDetection.Match')  
Returns the first or the best match found depending on search options.