#### [Portal](index.md 'index')
### [Portal.Detect](Portal.Detect.md 'Portal.Detect')

## Template Class

Template for image detection.

```csharp
public class Template
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Template

### Remarks
Templates are automatically imported from your "Templates" folder in your module folder when the app is started, when you press the Reload button and when the folders contents are changed.  
  
Templates MUST be a .png image.  
  
Templates have an associated .meta file, which contains the template's options.  
Options are as follows:  
  
Threshold can be set by setting "Threshold".  
Values are clamped between 0 and 100, as they are percentages.  
  
Method can be set by setting "Method".  
There are three different methods - "CCOEFF", "CCORR" and "SQDIFF".  
Each has their advantages and disadvantages. For example "CCOEFF" is slow, but has good accuracy.  
  
Color type can be set by setting "ColorType".  
There are two different color types - "Grayscale" and "Color".  
"Grayscale" is way faster, but is a little bit less accurate.  
  
A default region can be set by setting "Region".  
An example would be "45 45 55 55" which would be a rectangle in the center of the game window, with a size of 10% of the game window.  
Values are clamped between 0 and 100, as they are percentages of the game window and it wouldn't make sense to go outside it.  
  
Amount of frames to search for can be set by using "F" before the value. OUTDATED  
Values can go from 1 to "DETECTION_FRAMEPOOL_SIZE"(from config).  
<br/>  
Masks are generated from your (image)file's alpha channel.

| Constructors | |
| :--- | :--- |
| [Template(string, Mat, Mat, Nullable&lt;double&gt;, Nullable&lt;TemplateMatchModes&gt;, Nullable&lt;ImreadModes&gt;, Nullable&lt;GameRegion&gt;, Nullable&lt;int&gt;)](Template.Template(string,Mat,Mat,Nullable_double_,Nullable_TemplateMatchModes_,Nullable_ImreadModes_,Nullable_GameRegion_,Nullable_int_).md 'Portal.Detect.Template.Template(string, OpenCvSharp.Mat, OpenCvSharp.Mat, System.Nullable<double>, System.Nullable<OpenCvSharp.TemplateMatchModes>, System.Nullable<OpenCvSharp.ImreadModes>, System.Nullable<Portal.GameRegion>, System.Nullable<int>)') | Template constructor. |

| Properties | |
| :--- | :--- |
| [ColorType](Template.ColorType.md 'Portal.Detect.Template.ColorType') | Template image type. <br/> See [Template](Template.md 'Portal.Detect.Template') remarks. |
| [DefaultRegion](Template.DefaultRegion.md 'Portal.Detect.Template.DefaultRegion') | Template default region. <br/> See [Template](Template.md 'Portal.Detect.Template') remarks. |
| [FramesToSearch](Template.FramesToSearch.md 'Portal.Detect.Template.FramesToSearch') | Template frames to search. <br/> See [Template](Template.md 'Portal.Detect.Template') remarks. |
| [H](Template.H.md 'Portal.Detect.Template.H') | Template height, gets [Height](Size.Height.md 'Portal.Size.Height'). |
| [Image](Template.Image.md 'Portal.Detect.Template.Image') | Template image matrix. |
| [Mask](Template.Mask.md 'Portal.Detect.Template.Mask') | Template mask matrix from image alpha. <br/> See [Template](Template.md 'Portal.Detect.Template') remarks. |
| [Method](Template.Method.md 'Portal.Detect.Template.Method') | Template method. <br/> See [Template](Template.md 'Portal.Detect.Template') remarks. |
| [Name](Template.Name.md 'Portal.Detect.Template.Name') | Template name. |
| [Size](Template.Size.md 'Portal.Detect.Template.Size') | Template size, which is set from image matrix size. |
| [Threshold](Template.Threshold.md 'Portal.Detect.Template.Threshold') | Template threshold. |
| [W](Template.W.md 'Portal.Detect.Template.W') | Template width, gets [Width](Size.Width.md 'Portal.Size.Width'). |

| Methods | |
| :--- | :--- |
| [ToString()](Template.ToString().md 'Portal.Detect.Template.ToString()') | Overridden ToString function. |

| Operators | |
| :--- | :--- |
| [implicit operator Template(string)](Template.implicitoperatorTemplate(string).md 'Portal.Detect.Template.op_Implicit Portal.Detect.Template(string)') | Cast operator. <br/> Allows you to cast a string to a Template from your "Templates" folder. |
