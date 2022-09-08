#### [Portal](index.md 'index')
### [Portal.Detection](Portal.Detection.md 'Portal.Detection')

## ImageDetection Class

Functions for detecting an image([Template](Template.md 'Portal.Detection.Template')) on the screen.  
  
There are functions in [ScriptHelpers](ScriptHelpers.md 'Portal.Utility.ScriptHelpers') which should be used instead of these functions, as these are only intended to be "base" functions to find templates.

```csharp
public static class ImageDetection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ImageDetection

| Methods | |
| :--- | :--- |
| [FindTemplate(Template, GameRegion, double, TemplateMatchModes)](ImageDetection.FindTemplate(Template,GameRegion,double,TemplateMatchModes).md 'Portal.Detection.ImageDetection.FindTemplate(Portal.Detection.Template, Portal.GameRegion, double, OpenCvSharp.TemplateMatchModes)') | Captures a region and tries to match a template to it. |
| [FindTemplates(Template, GameRegion, double, TemplateMatchModes)](ImageDetection.FindTemplates(Template,GameRegion,double,TemplateMatchModes).md 'Portal.Detection.ImageDetection.FindTemplates(Portal.Detection.Template, Portal.GameRegion, double, OpenCvSharp.TemplateMatchModes)') | Captures a region and tries to match a template to it. |
