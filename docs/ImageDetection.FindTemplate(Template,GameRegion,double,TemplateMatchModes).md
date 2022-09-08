#### [Portal](index.md 'index')
### [Portal.Detection](Portal.Detection.md 'Portal.Detection').[ImageDetection](ImageDetection.md 'Portal.Detection.ImageDetection')

## ImageDetection.FindTemplate(Template, GameRegion, double, TemplateMatchModes) Method

Captures a region and tries to match a template to it.

```csharp
public static Portal.Detection.Match? FindTemplate(Portal.Detection.Template? InTemplate, Portal.GameRegion InRegion, double InThreshold, OpenCvSharp.TemplateMatchModes InMethod);
```
#### Parameters

<a name='Portal.Detection.ImageDetection.FindTemplate(Portal.Detection.Template,Portal.GameRegion,double,OpenCvSharp.TemplateMatchModes).InTemplate'></a>

`InTemplate` [Template](Template.md 'Portal.Detection.Template')

Template to search for.

<a name='Portal.Detection.ImageDetection.FindTemplate(Portal.Detection.Template,Portal.GameRegion,double,OpenCvSharp.TemplateMatchModes).InRegion'></a>

`InRegion` [GameRegion](GameRegion.md 'Portal.GameRegion')

Region to search within.

<a name='Portal.Detection.ImageDetection.FindTemplate(Portal.Detection.Template,Portal.GameRegion,double,OpenCvSharp.TemplateMatchModes).InThreshold'></a>

`InThreshold` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

Threshold value for the match. The higher the value, the more strict the  
            match.

<a name='Portal.Detection.ImageDetection.FindTemplate(Portal.Detection.Template,Portal.GameRegion,double,OpenCvSharp.TemplateMatchModes).InMethod'></a>

`InMethod` [OpenCvSharp.TemplateMatchModes](https://docs.microsoft.com/en-us/dotnet/api/OpenCvSharp.TemplateMatchModes 'OpenCvSharp.TemplateMatchModes')

Method to use. <br/> See [Template](Template.md 'Portal.Detection.Template') remarks.

#### Returns
[Match](Match.md 'Portal.Detection.Match')  
Returns the best match found.