#### [Portal](index.md 'index')
### [Portal.ImageDetection](Portal.ImageDetection.md 'Portal.ImageDetection').[ImageDetection](Portal.ImageDetection.ImageDetection.md 'Portal.ImageDetection.ImageDetection')

## ImageDetection.FindTemplate(Template, double, TemplateMatchModes) Method

Captures the game viewport and tries to match a template to it.

```csharp
public static Portal.ImageDetection.Match? FindTemplate(Portal.ImageDetection.Template? InTemplate, double InThreshold, OpenCvSharp.TemplateMatchModes InMethod);
```
#### Parameters

<a name='Portal.ImageDetection.ImageDetection.FindTemplate(Portal.ImageDetection.Template,double,OpenCvSharp.TemplateMatchModes).InTemplate'></a>

`InTemplate` [Template](Portal.ImageDetection.Template.md 'Portal.ImageDetection.Template')

Template to search for.

<a name='Portal.ImageDetection.ImageDetection.FindTemplate(Portal.ImageDetection.Template,double,OpenCvSharp.TemplateMatchModes).InThreshold'></a>

`InThreshold` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

Threshold value for the match. The higher the value, the more strict the  
            match.

<a name='Portal.ImageDetection.ImageDetection.FindTemplate(Portal.ImageDetection.Template,double,OpenCvSharp.TemplateMatchModes).InMethod'></a>

`InMethod` [OpenCvSharp.TemplateMatchModes](https://docs.microsoft.com/en-us/dotnet/api/OpenCvSharp.TemplateMatchModes 'OpenCvSharp.TemplateMatchModes')

Method to use. <br/> See [Template](Portal.ImageDetection.Template.md 'Portal.ImageDetection.Template') remarks.

#### Returns
[Match](Portal.ImageDetection.Match.md 'Portal.ImageDetection.Match')  
Returns the best match found.