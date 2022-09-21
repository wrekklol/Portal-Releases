#### [Portal](index.md 'index')
### [Portal.Detection](Portal.Detection.md 'Portal.Detection')

## SearchOptions Struct

Search options for image detection.  
Default search options are found in config.ini.

```csharp
public struct SearchOptions
```

### Example
Usage:  
  
```csharp  
SearchOptions MySearchOptions = new(new(0, 0, 1920, 1080));  
SearchOptions MySearchOptions = new(new(0, 0, 1920, 1080), 0.80, CCORR, 3);  
```  
Can also be created from a GameRegion.  
Example:  
  
```csharp  
SearchOptions MySearchOptions = new GameRegion(0, 0, 1920, 1080);  
```

| Constructors | |
| :--- | :--- |
| [SearchOptions(GameRegion, double, TemplateMatchModes, ImreadModes, int)](SearchOptions.SearchOptions(GameRegion,double,TemplateMatchModes,ImreadModes,int).md 'Portal.Detection.SearchOptions.SearchOptions(Portal.GameRegion, double, OpenCvSharp.TemplateMatchModes, OpenCvSharp.ImreadModes, int)') | SearchOptions constructor. |

| Properties | |
| :--- | :--- |
| [FramesToSearch](SearchOptions.FramesToSearch.md 'Portal.Detection.SearchOptions.FramesToSearch') | Amount of frames to search for template. <br/> See [Template](Template.md 'Portal.Detection.Template') remarks. |
| [ImageType](SearchOptions.ImageType.md 'Portal.Detection.SearchOptions.ImageType') | Search image type. <br/> See [Template](Template.md 'Portal.Detection.Template') remarks. |
| [Method](SearchOptions.Method.md 'Portal.Detection.SearchOptions.Method') | Search method. <br/> See [Template](Template.md 'Portal.Detection.Template') remarks. |
| [Region](SearchOptions.Region.md 'Portal.Detection.SearchOptions.Region') | Search region. |
| [Threshold](SearchOptions.Threshold.md 'Portal.Detection.SearchOptions.Threshold') | Search threshold. |

| Methods | |
| :--- | :--- |
| [ToString()](SearchOptions.ToString().md 'Portal.Detection.SearchOptions.ToString()') | Overridden ToString function. |

| Operators | |
| :--- | :--- |
| [implicit operator SearchOptions(GameRegion)](SearchOptions.implicitoperatorSearchOptions(GameRegion).md 'Portal.Detection.SearchOptions.op_Implicit Portal.Detection.SearchOptions(Portal.GameRegion)') | Cast operator. <br/> Allows you to cast a GameRegion to SearchOptions. <br/> See [SearchOptions](SearchOptions.md 'Portal.Detection.SearchOptions') for more information. |
