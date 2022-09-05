#### [Portal](index.md 'index')
### [Portal.ImageDetection](Portal.ImageDetection.md 'Portal.ImageDetection').[ImageDetection](ImageDetection.md 'Portal.ImageDetection.ImageDetection')

## ImageDetection.FindTemplates(Template, GameRegion, double, TemplateMatchModes) Method

Captures a region and tries to match a template to it.

```csharp
public static System.Collections.Generic.List<Portal.ImageDetection.Match> FindTemplates(Portal.ImageDetection.Template? InTemplate, Portal.GameRegion InRegion, double InThreshold, OpenCvSharp.TemplateMatchModes InMethod);
```
#### Parameters

<a name='Portal.ImageDetection.ImageDetection.FindTemplates(Portal.ImageDetection.Template,Portal.GameRegion,double,OpenCvSharp.TemplateMatchModes).InTemplate'></a>

`InTemplate` [Template](Template.md 'Portal.ImageDetection.Template')

Template to search for.

<a name='Portal.ImageDetection.ImageDetection.FindTemplates(Portal.ImageDetection.Template,Portal.GameRegion,double,OpenCvSharp.TemplateMatchModes).InRegion'></a>

`InRegion` [GameRegion](GameRegion.md 'Portal.GameRegion')

Region to search within.

<a name='Portal.ImageDetection.ImageDetection.FindTemplates(Portal.ImageDetection.Template,Portal.GameRegion,double,OpenCvSharp.TemplateMatchModes).InThreshold'></a>

`InThreshold` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

Threshold value for the match. The higher the value, the more strict the  
            match.

<a name='Portal.ImageDetection.ImageDetection.FindTemplates(Portal.ImageDetection.Template,Portal.GameRegion,double,OpenCvSharp.TemplateMatchModes).InMethod'></a>

`InMethod` [OpenCvSharp.TemplateMatchModes](https://docs.microsoft.com/en-us/dotnet/api/OpenCvSharp.TemplateMatchModes 'OpenCvSharp.TemplateMatchModes')

Method to use. <br/> See [Template](Template.md 'Portal.ImageDetection.Template') remarks.

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Match](Match.md 'Portal.ImageDetection.Match')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
Returns all matches found within the threshold.