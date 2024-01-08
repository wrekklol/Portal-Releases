#### [Portal](index.md 'index')
### [Portal.Detect](Portal.Detect.md 'Portal.Detect').[DetectManager](DetectManager.md 'Portal.Detect.DetectManager')

## DetectManager.FindMatchesInternal(Template, SearchOptions, bool) Method

Captures a region and tries to compare a template to it.

```csharp
internal static System.Collections.Generic.List<Portal.Detect.Match>? FindMatchesInternal(Portal.Detect.Template InTemplate, Portal.Detect.SearchOptions InSearchOptions, bool InbShouldPrint=true);
```
#### Parameters

<a name='Portal.Detect.DetectManager.FindMatchesInternal(Portal.Detect.Template,Portal.Detect.SearchOptions,bool).InTemplate'></a>

`InTemplate` [Template](Template.md 'Portal.Detect.Template')

Template to search for.

<a name='Portal.Detect.DetectManager.FindMatchesInternal(Portal.Detect.Template,Portal.Detect.SearchOptions,bool).InSearchOptions'></a>

`InSearchOptions` [SearchOptions](SearchOptions.md 'Portal.Detect.SearchOptions')

Options to search with.

<a name='Portal.Detect.DetectManager.FindMatchesInternal(Portal.Detect.Template,Portal.Detect.SearchOptions,bool).InbShouldPrint'></a>

`InbShouldPrint` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Match](Match.md 'Portal.Detect.Match')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
Returns all matches found with the specified search options.