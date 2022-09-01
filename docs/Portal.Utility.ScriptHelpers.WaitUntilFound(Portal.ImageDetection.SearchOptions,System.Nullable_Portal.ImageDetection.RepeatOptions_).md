#### [Portal](index.md 'index')
### [Portal.Utility](Portal.Utility.md 'Portal.Utility').[ScriptHelpers](Portal.Utility.ScriptHelpers.md 'Portal.Utility.ScriptHelpers')

## ScriptHelpers.WaitUntilFound(SearchOptions, Nullable<RepeatOptions>) Method

Waits until the template is found.

```csharp
public static Portal.ImageDetection.Match? WaitUntilFound(Portal.ImageDetection.SearchOptions InSearchOptions, System.Nullable<Portal.ImageDetection.RepeatOptions> InRepeatOptions=null);
```
#### Parameters

<a name='Portal.Utility.ScriptHelpers.WaitUntilFound(Portal.ImageDetection.SearchOptions,System.Nullable_Portal.ImageDetection.RepeatOptions_).InSearchOptions'></a>

`InSearchOptions` [SearchOptions](Portal.ImageDetection.SearchOptions.md 'Portal.ImageDetection.SearchOptions')

This is the options you want to use to search for the element.

<a name='Portal.Utility.ScriptHelpers.WaitUntilFound(Portal.ImageDetection.SearchOptions,System.Nullable_Portal.ImageDetection.RepeatOptions_).InRepeatOptions'></a>

`InRepeatOptions` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[RepeatOptions](Portal.ImageDetection.RepeatOptions.md 'Portal.ImageDetection.RepeatOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

This is an optional parameter that allows you to specify how often the search should  
            be repeated.

#### Returns
[Match](Portal.ImageDetection.Match.md 'Portal.ImageDetection.Match')  
Returns the first match found.