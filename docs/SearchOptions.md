#### [Portal](index.md 'index')
### [Portal.Detect](Portal.Detect.md 'Portal.Detect')

## SearchOptions Class

Search options for image detection.  
Default search options are found in config.ini.

```csharp
public class SearchOptions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SearchOptions

### Example
Usage:  
  
```csharp  
SearchOptions MySearchOptions = new(new(0, 0, 100, 100));  
SearchOptions MySearchOptions = new(new(0, 0, 100, 100), 0.80, CCORR, 3);  
```  
Can also be created from a GameRegion.  
Example:  
  
```csharp  
SearchOptions MySearchOptions = new GameRegion(0, 0, 100, 100);  
```  
Can also be created using builder pattern.  
Example:  
  
```csharp  
SearchOptions MySearchOptions = new()  
    .WithRegion(new(0, 0, 100, 100))  
    .WithThreshold(0.80)  
    .WithMethod(CCORR)  
    .WithColorType(3);  
```

| Constructors | |
| :--- | :--- |
| [SearchOptions(Nullable&lt;GameRegion&gt;, Nullable&lt;double&gt;, Nullable&lt;TemplateMatchModes&gt;, Nullable&lt;ImreadModes&gt;, Mat, bool, bool, bool)](SearchOptions.SearchOptions(Nullable_GameRegion_,Nullable_double_,Nullable_TemplateMatchModes_,Nullable_ImreadModes_,Mat,bool,bool,bool).md 'Portal.Detect.SearchOptions.SearchOptions(System.Nullable<Portal.GameRegion>, System.Nullable<double>, System.Nullable<OpenCvSharp.TemplateMatchModes>, System.Nullable<OpenCvSharp.ImreadModes>, OpenCvSharp.Mat, bool, bool, bool)') | SearchOptions constructor. |

| Properties | |
| :--- | :--- |
| [bForceSearch](SearchOptions.bForceSearch.md 'Portal.Detect.SearchOptions.bForceSearch') | Searches even when script is stopped. |
| [bPrioritizeTemplateOptions](SearchOptions.bPrioritizeTemplateOptions.md 'Portal.Detect.SearchOptions.bPrioritizeTemplateOptions') | If true, will prioritize template options(suffixes). <br/> See [Template](Template.md 'Portal.Detect.Template') remarks. |
| [bWantsFrameCaptured](SearchOptions.bWantsFrameCaptured.md 'Portal.Detect.SearchOptions.bWantsFrameCaptured') | If true, frame that was used for the search will be stored as [System.Windows.Controls.Frame](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Controls.Frame 'System.Windows.Controls.Frame'). |
| [ColorType](SearchOptions.ColorType.md 'Portal.Detect.SearchOptions.ColorType') | Search image type. <br/> See [Template](Template.md 'Portal.Detect.Template') remarks. |
| [FrameToSearch](SearchOptions.FrameToSearch.md 'Portal.Detect.SearchOptions.FrameToSearch') | If not null, will be used as the frame to be searched instead of one of the latest captured frames. |
| [Method](SearchOptions.Method.md 'Portal.Detect.SearchOptions.Method') | Search method. <br/> See [Template](Template.md 'Portal.Detect.Template') remarks. |
| [Region](SearchOptions.Region.md 'Portal.Detect.SearchOptions.Region') | Search region. |
| [Threshold](SearchOptions.Threshold.md 'Portal.Detect.SearchOptions.Threshold') | Search threshold. |

| Methods | |
| :--- | :--- |
| [ToString()](SearchOptions.ToString().md 'Portal.Detect.SearchOptions.ToString()') | Overridden ToString function. |

| Operators | |
| :--- | :--- |
| [implicit operator SearchOptions(GameRegion)](SearchOptions.implicitoperatorSearchOptions(GameRegion).md 'Portal.Detect.SearchOptions.op_Implicit Portal.Detect.SearchOptions(Portal.GameRegion)') | Cast operator. <br/> Allows you to cast a GameRegion to SearchOptions. <br/> See [SearchOptions](SearchOptions.md 'Portal.Detect.SearchOptions') for more information. |
