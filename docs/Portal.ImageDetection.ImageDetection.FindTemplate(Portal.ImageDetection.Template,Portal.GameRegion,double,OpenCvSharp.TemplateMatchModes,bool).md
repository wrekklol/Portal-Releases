#### [Portal](index.md 'index')
### [Portal.ImageDetection](Portal.ImageDetection.md 'Portal.ImageDetection').[ImageDetection](Portal.ImageDetection.ImageDetection.md 'Portal.ImageDetection.ImageDetection')

## ImageDetection.FindTemplate(Template, GameRegion, double, TemplateMatchModes, bool) Method

Captures a region and tries to match a template to it.

```csharp
public static Portal.ImageDetection.Match? FindTemplate(Portal.ImageDetection.Template? InTemplate, Portal.GameRegion InRegion, double InThreshold, OpenCvSharp.TemplateMatchModes InMethod, bool InbFirstMatch);
```
#### Parameters

<a name='Portal.ImageDetection.ImageDetection.FindTemplate(Portal.ImageDetection.Template,Portal.GameRegion,double,OpenCvSharp.TemplateMatchModes,bool).InTemplate'></a>

`InTemplate` [Template](Portal.ImageDetection.Template.md 'Portal.ImageDetection.Template')

Template to search for.

<a name='Portal.ImageDetection.ImageDetection.FindTemplate(Portal.ImageDetection.Template,Portal.GameRegion,double,OpenCvSharp.TemplateMatchModes,bool).InRegion'></a>

`InRegion` [Portal.GameRegion](https://docs.microsoft.com/en-us/dotnet/api/Portal.GameRegion 'Portal.GameRegion')

Region to search within.

<a name='Portal.ImageDetection.ImageDetection.FindTemplate(Portal.ImageDetection.Template,Portal.GameRegion,double,OpenCvSharp.TemplateMatchModes,bool).InThreshold'></a>

`InThreshold` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

Threshold value for the match. The higher the value, the more strict the  
            match.

<a name='Portal.ImageDetection.ImageDetection.FindTemplate(Portal.ImageDetection.Template,Portal.GameRegion,double,OpenCvSharp.TemplateMatchModes,bool).InMethod'></a>

`InMethod` [OpenCvSharp.TemplateMatchModes](https://docs.microsoft.com/en-us/dotnet/api/OpenCvSharp.TemplateMatchModes 'OpenCvSharp.TemplateMatchModes')

Method to use. <br/> See [Template](Portal.ImageDetection.Template.md 'Portal.ImageDetection.Template') remarks.

<a name='Portal.ImageDetection.ImageDetection.FindTemplate(Portal.ImageDetection.Template,Portal.GameRegion,double,OpenCvSharp.TemplateMatchModes,bool).InbFirstMatch'></a>

`InbFirstMatch` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

If true, returns the first match that is within the specified threshold. Else, returns the best match by comparing all results.

#### Returns
[Match](Portal.ImageDetection.Match.md 'Portal.ImageDetection.Match')  
Returns the best match found.