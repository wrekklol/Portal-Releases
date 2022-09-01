#### [Portal](index.md 'index')
### [Portal.ImageDetection](Portal.ImageDetection.md 'Portal.ImageDetection')

## Template Class

Template for image detection.

```csharp
public class Template
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Template

### Remarks
Templates are automatically imported from your "Templates" folder in your module folder when the app is started, and when you press the Reload button.  
  
When naming your templates in your "Templates" folder, you can give them a suffix with a method and threshold override. For example, if you name your template filename "Awesome Template", you can suffix it with "%SQDIFF+85%" (so it becomes "Awesome Template %SQDIFF+85%"), which will set the method to SQDIFF and threshold to 0.85.  
  
There are three different methods - CCOEFF, CCORR and SQDIFF.  
Each has their advantages and disadvantages. For example CCOEFF is slow, but has good accuracy.  
Valid values are:  
CCOEFF  
CCORR  
SQDIFF  
1 (which translates to CCOEFF)  
2 (which translates to CCORR)  
3 (which translates to SQDIFF)  
<br/>  
Masks are generated from your (image)file's alpha channel.

| Constructors | |
| :--- | :--- |
| [Template(string, Mat, Mat)](Portal.ImageDetection.Template.Template(string,OpenCvSharp.Mat,OpenCvSharp.Mat).md 'Portal.ImageDetection.Template.Template(string, OpenCvSharp.Mat, OpenCvSharp.Mat)') | Calls [Template(string, Mat, Mat, double, TemplateMatchModes, bool)](Portal.ImageDetection.Template.Template(string,OpenCvSharp.Mat,OpenCvSharp.Mat,double,OpenCvSharp.TemplateMatchModes,bool).md 'Portal.ImageDetection.Template.Template(string, OpenCvSharp.Mat, OpenCvSharp.Mat, double, OpenCvSharp.TemplateMatchModes, bool)') with default values of (0.75, CCOEFF, false) for "Threshold", "Method" and "bShouldOverride" respectively/> |
| [Template(string, Mat, Mat, double, TemplateMatchModes, bool)](Portal.ImageDetection.Template.Template(string,OpenCvSharp.Mat,OpenCvSharp.Mat,double,OpenCvSharp.TemplateMatchModes,bool).md 'Portal.ImageDetection.Template.Template(string, OpenCvSharp.Mat, OpenCvSharp.Mat, double, OpenCvSharp.TemplateMatchModes, bool)') | Template constructor. |

| Properties | |
| :--- | :--- |
| [bShouldOverride](Portal.ImageDetection.Template.bShouldOverride.md 'Portal.ImageDetection.Template.bShouldOverride') | True if a suffix was added to your template filename. <br/> See [Template](Portal.ImageDetection.Template.md 'Portal.ImageDetection.Template') remarks. |
| [H](Portal.ImageDetection.Template.H.md 'Portal.ImageDetection.Template.H') | Template height, gets [Portal.GameSize.Height](https://docs.microsoft.com/en-us/dotnet/api/Portal.GameSize.Height 'Portal.GameSize.Height'). |
| [Image](Portal.ImageDetection.Template.Image.md 'Portal.ImageDetection.Template.Image') | Template image matrix. |
| [Mask](Portal.ImageDetection.Template.Mask.md 'Portal.ImageDetection.Template.Mask') | Template mask matrix from image alpha. <br/> See [Template](Portal.ImageDetection.Template.md 'Portal.ImageDetection.Template') remarks. |
| [Method](Portal.ImageDetection.Template.Method.md 'Portal.ImageDetection.Template.Method') | Template method. <br/> See [Template](Portal.ImageDetection.Template.md 'Portal.ImageDetection.Template') remarks. |
| [Name](Portal.ImageDetection.Template.Name.md 'Portal.ImageDetection.Template.Name') | Template name. |
| [Size](Portal.ImageDetection.Template.Size.md 'Portal.ImageDetection.Template.Size') | Template size, which is set from image matrix size. |
| [Threshold](Portal.ImageDetection.Template.Threshold.md 'Portal.ImageDetection.Template.Threshold') | Template threshold. |
| [W](Portal.ImageDetection.Template.W.md 'Portal.ImageDetection.Template.W') | Template width, gets [Portal.GameSize.Width](https://docs.microsoft.com/en-us/dotnet/api/Portal.GameSize.Width 'Portal.GameSize.Width'). |

| Methods | |
| :--- | :--- |
| [ToString()](Portal.ImageDetection.Template.ToString().md 'Portal.ImageDetection.Template.ToString()') | Overridden ToString function. |

| Operators | |
| :--- | :--- |
| [implicit operator Template(string)](Portal.ImageDetection.Template.op_ImplicitPortal.ImageDetection.Template(string).md 'Portal.ImageDetection.Template.op_Implicit Portal.ImageDetection.Template(string)') | Cast operator. <br/> Allows you to cast a string to a Template from your "Templates" folder. |
