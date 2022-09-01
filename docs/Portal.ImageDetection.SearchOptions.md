#### [Portal](index.md 'index')
### [Portal.ImageDetection](Portal.ImageDetection.md 'Portal.ImageDetection')

## SearchOptions Struct

Search options for image detection.  
Default search options are (GAME_RECT, 0.75, CCOEFF, false) for ([Region](Portal.ImageDetection.SearchOptions.Region.md 'Portal.ImageDetection.SearchOptions.Region'), [Threshold](Portal.ImageDetection.SearchOptions.Threshold.md 'Portal.ImageDetection.SearchOptions.Threshold'), [Method](Portal.ImageDetection.SearchOptions.Method.md 'Portal.ImageDetection.SearchOptions.Method'), [bFirstMatch](Portal.ImageDetection.SearchOptions.bFirstMatch.md 'Portal.ImageDetection.SearchOptions.bFirstMatch')) respectively.

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
| [SearchOptions()](Portal.ImageDetection.SearchOptions.SearchOptions().md 'Portal.ImageDetection.SearchOptions.SearchOptions()') | SearchOptions constructor. |
| [SearchOptions(GameRegion)](Portal.ImageDetection.SearchOptions.SearchOptions(Portal.GameRegion).md 'Portal.ImageDetection.SearchOptions.SearchOptions(Portal.GameRegion)') | SearchOptions constructor. |
| [SearchOptions(GameRegion, double)](Portal.ImageDetection.SearchOptions.SearchOptions(Portal.GameRegion,double).md 'Portal.ImageDetection.SearchOptions.SearchOptions(Portal.GameRegion, double)') | SearchOptions constructor. |
| [SearchOptions(GameRegion, double, TemplateMatchModes)](Portal.ImageDetection.SearchOptions.SearchOptions(Portal.GameRegion,double,OpenCvSharp.TemplateMatchModes).md 'Portal.ImageDetection.SearchOptions.SearchOptions(Portal.GameRegion, double, OpenCvSharp.TemplateMatchModes)') | SearchOptions constructor. |
| [SearchOptions(GameRegion, double, TemplateMatchModes, bool)](Portal.ImageDetection.SearchOptions.SearchOptions(Portal.GameRegion,double,OpenCvSharp.TemplateMatchModes,bool).md 'Portal.ImageDetection.SearchOptions.SearchOptions(Portal.GameRegion, double, OpenCvSharp.TemplateMatchModes, bool)') | SearchOptions constructor. |

| Properties | |
| :--- | :--- |
| [bFirstMatch](Portal.ImageDetection.SearchOptions.bFirstMatch.md 'Portal.ImageDetection.SearchOptions.bFirstMatch') | If true, finds the first match that is within the specified threshold. Else, finds the best match by comparing all results. |
| [Method](Portal.ImageDetection.SearchOptions.Method.md 'Portal.ImageDetection.SearchOptions.Method') | Search method. <br/> See [Template](Portal.ImageDetection.Template.md 'Portal.ImageDetection.Template') remarks. |
| [Region](Portal.ImageDetection.SearchOptions.Region.md 'Portal.ImageDetection.SearchOptions.Region') | Search region. |
| [Threshold](Portal.ImageDetection.SearchOptions.Threshold.md 'Portal.ImageDetection.SearchOptions.Threshold') | Search threshold. |

| Methods | |
| :--- | :--- |
| [ToString()](Portal.ImageDetection.SearchOptions.ToString().md 'Portal.ImageDetection.SearchOptions.ToString()') | Overridden ToString function. |

| Operators | |
| :--- | :--- |
| [implicit operator SearchOptions(GameRegion)](Portal.ImageDetection.SearchOptions.op_ImplicitPortal.ImageDetection.SearchOptions(Portal.GameRegion).md 'Portal.ImageDetection.SearchOptions.op_Implicit Portal.ImageDetection.SearchOptions(Portal.GameRegion)') | Cast operator. <br/> Allows you to cast a GameRegion to SearchOptions. <br/> See [SearchOptions(GameRegion)](Portal.ImageDetection.SearchOptions.SearchOptions(Portal.GameRegion).md 'Portal.ImageDetection.SearchOptions.SearchOptions(Portal.GameRegion)') for more information. |
