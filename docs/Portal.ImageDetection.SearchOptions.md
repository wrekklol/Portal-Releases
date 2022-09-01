#### [Portal](index.md 'index')
### [Portal.ImageDetection](Portal.ImageDetection.md 'Portal.ImageDetection')

## SearchOptions Struct

Search options for image detection.

```csharp
public struct SearchOptions
```

### Example
Usage:  
  
```csharp  
SearchOptions MySearchOptions = new("Awesome Template");  
SearchOptions MySearchOptions = new("Awesome Template", 0.5, SQDIFF);  
```  
Can also be created from a string.  
Example:  
  
```csharp  
SearchOptions MySearchOptions = "Awesome Template";  
```

| Constructors | |
| :--- | :--- |
| [SearchOptions(string, double, TemplateMatchModes)](Portal.ImageDetection.SearchOptions.SearchOptions(string,double,OpenCvSharp.TemplateMatchModes).md 'Portal.ImageDetection.SearchOptions.SearchOptions(string, double, OpenCvSharp.TemplateMatchModes)') | SearchOptions constructor. |
| [SearchOptions(string)](Portal.ImageDetection.SearchOptions.SearchOptions(string).md 'Portal.ImageDetection.SearchOptions.SearchOptions(string)') | Calls [SearchOptions(string, double, TemplateMatchModes)](Portal.ImageDetection.SearchOptions.SearchOptions(string,double,OpenCvSharp.TemplateMatchModes).md 'Portal.ImageDetection.SearchOptions.SearchOptions(string, double, OpenCvSharp.TemplateMatchModes)') with default values of (0.75, CCOEFF) for "Threshold" and "Method" respectively. |

| Properties | |
| :--- | :--- |
| [Method](Portal.ImageDetection.SearchOptions.Method.md 'Portal.ImageDetection.SearchOptions.Method') | Template method. <br/> See [Template](Portal.ImageDetection.Template.md 'Portal.ImageDetection.Template') remarks. |
| [TemplateName](Portal.ImageDetection.SearchOptions.TemplateName.md 'Portal.ImageDetection.SearchOptions.TemplateName') | Template name. |
| [Threshold](Portal.ImageDetection.SearchOptions.Threshold.md 'Portal.ImageDetection.SearchOptions.Threshold') | Template threshold. |

| Methods | |
| :--- | :--- |
| [ToString()](Portal.ImageDetection.SearchOptions.ToString().md 'Portal.ImageDetection.SearchOptions.ToString()') | Overridden ToString function. |

| Operators | |
| :--- | :--- |
| [implicit operator SearchOptions(string)](Portal.ImageDetection.SearchOptions.op_ImplicitPortal.ImageDetection.SearchOptions(string).md 'Portal.ImageDetection.SearchOptions.op_Implicit Portal.ImageDetection.SearchOptions(string)') | Cast operator. <br/> Allows you to cast a string to SearchOptions. |
