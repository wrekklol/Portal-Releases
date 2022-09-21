#### [Portal](index.md 'index')
### [Portal.Detection](Portal.Detection.md 'Portal.Detection').[ImageDetection](ImageDetection.md 'Portal.Detection.ImageDetection')

## ImageDetection.FindBestMatch(Template, SearchOptions) Method

Captures a region and tries to compare a template to it.

```csharp
public static Portal.Detection.Match? FindBestMatch(Portal.Detection.Template? InTemplate, Portal.Detection.SearchOptions InSearchOptions);
```
#### Parameters

<a name='Portal.Detection.ImageDetection.FindBestMatch(Portal.Detection.Template,Portal.Detection.SearchOptions).InTemplate'></a>

`InTemplate` [Template](Template.md 'Portal.Detection.Template')

Template to search for.

<a name='Portal.Detection.ImageDetection.FindBestMatch(Portal.Detection.Template,Portal.Detection.SearchOptions).InSearchOptions'></a>

`InSearchOptions` [SearchOptions](SearchOptions.md 'Portal.Detection.SearchOptions')

Options to search with.

#### Returns
[Match](Match.md 'Portal.Detection.Match')  
Returns the best match found.