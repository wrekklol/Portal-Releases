#### [Portal](index.md 'index')
### [Portal.Detection](Portal.Detection.md 'Portal.Detection').[ImageDetection](ImageDetection.md 'Portal.Detection.ImageDetection')

## ImageDetection.FindTemplates(Template, GameRegion, double, TemplateMatchModes) Method

Captures a region and tries to match a template to it.

```csharp
public static System.Collections.Generic.List<Portal.Detection.Match> FindTemplates(Portal.Detection.Template? InTemplate, Portal.GameRegion InRegion, double InThreshold, OpenCvSharp.TemplateMatchModes InMethod);
```
#### Parameters

<a name='Portal.Detection.ImageDetection.FindTemplates(Portal.Detection.Template,Portal.GameRegion,double,OpenCvSharp.TemplateMatchModes).InTemplate'></a>

`InTemplate` [Template](Template.md 'Portal.Detection.Template')

Template to search for.

<a name='Portal.Detection.ImageDetection.FindTemplates(Portal.Detection.Template,Portal.GameRegion,double,OpenCvSharp.TemplateMatchModes).InRegion'></a>

`InRegion` [GameRegion](GameRegion.md 'Portal.GameRegion')

Region to search within.

<a name='Portal.Detection.ImageDetection.FindTemplates(Portal.Detection.Template,Portal.GameRegion,double,OpenCvSharp.TemplateMatchModes).InThreshold'></a>

`InThreshold` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

Threshold value for the match. The higher the value, the more strict the  
            match.

<a name='Portal.Detection.ImageDetection.FindTemplates(Portal.Detection.Template,Portal.GameRegion,double,OpenCvSharp.TemplateMatchModes).InMethod'></a>

`InMethod` [OpenCvSharp.TemplateMatchModes](https://docs.microsoft.com/en-us/dotnet/api/OpenCvSharp.TemplateMatchModes 'OpenCvSharp.TemplateMatchModes')

Method to use. <br/> See [Template](Template.md 'Portal.Detection.Template') remarks.

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Match](Match.md 'Portal.Detection.Match')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
Returns all matches found within the threshold.