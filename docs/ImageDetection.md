#### [Portal](index.md 'index')
### [Portal.ImageDetection](Portal.ImageDetection.md 'Portal.ImageDetection')

## ImageDetection Class

Functions for detecting an image([Template](Template.md 'Portal.ImageDetection.Template')) on the screen.  
  
There are functions in [ScriptHelpers](ScriptHelpers.md 'Portal.Utility.ScriptHelpers') which should be used instead of these functions, as these are only intended to be "base" functions to find templates.

```csharp
public static class ImageDetection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ImageDetection

| Methods | |
| :--- | :--- |
| [FindTemplate(Template, GameRegion, double, TemplateMatchModes, bool)](ImageDetection.FindTemplate(Template,GameRegion,double,TemplateMatchModes,bool).md 'Portal.ImageDetection.ImageDetection.FindTemplate(Portal.ImageDetection.Template, Portal.GameRegion, double, OpenCvSharp.TemplateMatchModes, bool)') | Captures a region and tries to match a template to it. |
| [FindTemplates(Template, GameRegion, double, TemplateMatchModes)](ImageDetection.FindTemplates(Template,GameRegion,double,TemplateMatchModes).md 'Portal.ImageDetection.ImageDetection.FindTemplates(Portal.ImageDetection.Template, Portal.GameRegion, double, OpenCvSharp.TemplateMatchModes)') | Captures a region and tries to match a template to it. |
