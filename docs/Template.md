#### [Portal](index.md 'index')
### [Portal.Detection](Portal.Detection.md 'Portal.Detection')

## Template Class

Template for image detection.

```csharp
public class Template
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Template

### Remarks
Templates are automatically imported from your "Templates" folder in your module folder when the app is started, and when you press the Reload button.  
  
When naming your templates in your "Templates" folder, you can give them a suffix with a method, threshold and image type override. For example, if you name your template filename "Awesome Template", you can suffix it with "%SQDIFF+85+COLOR%" (so it becomes "Awesome Template %SQDIFF+85+COLOR%"), which will set the method to SQDIFF, threshold to 0.85 and image type to COLOR.  
You don't need to override everything at once, for example "%SQDIFF+85%" is also valid, and "%SQDIFF%" as well.  
   
There are three different methods - CCOEFF, CCORR and SQDIFF.  
Each has their advantages and disadvantages. For example CCOEFF is slow, but has good accuracy.  
Valid values are:  
CCOEFF  
CCORR  
SQDIFF  
1 (which translates to CCOEFF)  
2 (which translates to CCORR)  
3 (which translates to SQDIFF)  
  
There are two different image types - GRAY and COLOR.  
GRAY is way faster, but is a little bit less accurate.  
Valid values are:  
GRAY  
COLOR  
1 (which translates to GRAY)  
2 (which translates to COLOR)  
<br/>  
Masks are generated from your (image)file's alpha channel.

| Constructors | |
| :--- | :--- |
| [Template(string, Mat, Mat, double, TemplateMatchModes, ImreadModes, bool)](Template.Template(string,Mat,Mat,double,TemplateMatchModes,ImreadModes,bool).md 'Portal.Detection.Template.Template(string, OpenCvSharp.Mat, OpenCvSharp.Mat, double, OpenCvSharp.TemplateMatchModes, OpenCvSharp.ImreadModes, bool)') | Template constructor. |

| Properties | |
| :--- | :--- |
| [bShouldOverride](Template.bShouldOverride.md 'Portal.Detection.Template.bShouldOverride') | True if a suffix was added to your template filename. <br/> See [Template](Template.md 'Portal.Detection.Template') remarks. |
| [H](Template.H.md 'Portal.Detection.Template.H') | Template height, gets [Height](GameSize.Height.md 'Portal.GameSize.Height'). |
| [Image](Template.Image.md 'Portal.Detection.Template.Image') | Template image matrix. |
| [ImageType](Template.ImageType.md 'Portal.Detection.Template.ImageType') | Template image type. <br/> See [Template](Template.md 'Portal.Detection.Template') remarks. |
| [Mask](Template.Mask.md 'Portal.Detection.Template.Mask') | Template mask matrix from image alpha. <br/> See [Template](Template.md 'Portal.Detection.Template') remarks. |
| [Method](Template.Method.md 'Portal.Detection.Template.Method') | Template method. <br/> See [Template](Template.md 'Portal.Detection.Template') remarks. |
| [Name](Template.Name.md 'Portal.Detection.Template.Name') | Template name. |
| [Size](Template.Size.md 'Portal.Detection.Template.Size') | Template size, which is set from image matrix size. |
| [Threshold](Template.Threshold.md 'Portal.Detection.Template.Threshold') | Template threshold. |
| [W](Template.W.md 'Portal.Detection.Template.W') | Template width, gets [Width](GameSize.Width.md 'Portal.GameSize.Width'). |

| Methods | |
| :--- | :--- |
| [ToString()](Template.ToString().md 'Portal.Detection.Template.ToString()') | Overridden ToString function. |

| Operators | |
| :--- | :--- |
| [implicit operator Template(string)](Template.implicitoperatorTemplate(string).md 'Portal.Detection.Template.op_Implicit Portal.Detection.Template(string)') | Cast operator. <br/> Allows you to cast a string to a Template from your "Templates" folder. |
