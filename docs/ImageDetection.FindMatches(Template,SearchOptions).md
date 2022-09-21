#### [Portal](index.md 'index')
### [Portal.Detection](Portal.Detection.md 'Portal.Detection').[ImageDetection](ImageDetection.md 'Portal.Detection.ImageDetection')

## ImageDetection.FindMatches(Template, SearchOptions) Method

Captures a region and tries to compare a template to it.

```csharp
public static System.Collections.Generic.List<Portal.Detection.Match>? FindMatches(Portal.Detection.Template? InTemplate, Portal.Detection.SearchOptions InSearchOptions);
```
#### Parameters

<a name='Portal.Detection.ImageDetection.FindMatches(Portal.Detection.Template,Portal.Detection.SearchOptions).InTemplate'></a>

`InTemplate` [Template](Template.md 'Portal.Detection.Template')

Template to search for.

<a name='Portal.Detection.ImageDetection.FindMatches(Portal.Detection.Template,Portal.Detection.SearchOptions).InSearchOptions'></a>

`InSearchOptions` [SearchOptions](SearchOptions.md 'Portal.Detection.SearchOptions')

Options to search with.

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Match](Match.md 'Portal.Detection.Match')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
Returns all matches found with the specified search options.