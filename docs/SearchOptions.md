#### [Portal](index.md 'index')
### [Portal.ImageDetection](Portal.ImageDetection.md 'Portal.ImageDetection')

## SearchOptions Struct

Search options for image detection.  
Default search options are (GAME_RECT, 0.75, CCOEFF, false) for ([Region](SearchOptions.Region.md 'Portal.ImageDetection.SearchOptions.Region'), [Threshold](SearchOptions.Threshold.md 'Portal.ImageDetection.SearchOptions.Threshold'), [Method](SearchOptions.Method.md 'Portal.ImageDetection.SearchOptions.Method'), [bFirstMatch](SearchOptions.bFirstMatch.md 'Portal.ImageDetection.SearchOptions.bFirstMatch')) respectively.

```csharp
public struct SearchOptions
```

### Example
Usage:  
  
```csharp  
SearchOptions MySearchOptions = new(new(0, 0, 1920, 1080));  
SearchOptions MySearchOptions = new(new(0, 0, 1920, 1080), 0.80, CCORR);  
SearchOptions MySearchOptions = new(new(0, 0, 1920, 1080), 0.95, SQDIFF, true);  
```  
Can also be created from a GameRegion.  
Example:  
  
```csharp  
SearchOptions MySearchOptions = new GameRegion(0, 0, 1920, 1080);  
```

| Constructors | |
| :--- | :--- |
| [SearchOptions(GameRegion, double, TemplateMatchModes, bool)](SearchOptions.SearchOptions(GameRegion,double,TemplateMatchModes,bool).md 'Portal.ImageDetection.SearchOptions.SearchOptions(Portal.GameRegion, double, OpenCvSharp.TemplateMatchModes, bool)') | SearchOptions constructor. |

| Properties | |
| :--- | :--- |
| [bFirstMatch](SearchOptions.bFirstMatch.md 'Portal.ImageDetection.SearchOptions.bFirstMatch') | If true, finds the first match that is within the specified threshold. Else, finds the best match by comparing all results. |
| [Method](SearchOptions.Method.md 'Portal.ImageDetection.SearchOptions.Method') | Search method. <br/> See [Template](Template.md 'Portal.ImageDetection.Template') remarks. |
| [Region](SearchOptions.Region.md 'Portal.ImageDetection.SearchOptions.Region') | Search region. |
| [Threshold](SearchOptions.Threshold.md 'Portal.ImageDetection.SearchOptions.Threshold') | Search threshold. |

| Methods | |
| :--- | :--- |
| [ToString()](SearchOptions.ToString().md 'Portal.ImageDetection.SearchOptions.ToString()') | Overridden ToString function. |

| Operators | |
| :--- | :--- |
| [implicit operator SearchOptions(GameRegion)](SearchOptions.implicitoperatorSearchOptions(GameRegion).md 'Portal.ImageDetection.SearchOptions.op_Implicit Portal.ImageDetection.SearchOptions(Portal.GameRegion)') | Cast operator. <br/> Allows you to cast a GameRegion to SearchOptions. <br/> See [SearchOptions](SearchOptions.md 'Portal.ImageDetection.SearchOptions') for more information. |
