#### [Portal](index.md 'index')
### [Portal.ImageDetection](Portal.ImageDetection.md 'Portal.ImageDetection')

## ImageDetection Class

Functions for detecting an image([Template](Portal.ImageDetection.Template.md 'Portal.ImageDetection.Template')) on the screen.  
  
There are functions in [ScriptHelpers](Portal.Utility.ScriptHelpers.md 'Portal.Utility.ScriptHelpers') which should be instead instead of these functions, as these are only intended to be "base" functions to find templates.

```csharp
public static class ImageDetection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ImageDetection

| Methods | |
| :--- | :--- |
| [FindTemplate(Template, GameRegion, double, TemplateMatchModes, bool)](Portal.ImageDetection.ImageDetection.FindTemplate(Portal.ImageDetection.Template,Portal.GameRegion,double,OpenCvSharp.TemplateMatchModes,bool).md 'Portal.ImageDetection.ImageDetection.FindTemplate(Portal.ImageDetection.Template, Portal.GameRegion, double, OpenCvSharp.TemplateMatchModes, bool)') | Captures a region and tries to match a template to it. |
| [FindTemplates(Template, GameRegion, double, TemplateMatchModes)](Portal.ImageDetection.ImageDetection.FindTemplates(Portal.ImageDetection.Template,Portal.GameRegion,double,OpenCvSharp.TemplateMatchModes).md 'Portal.ImageDetection.ImageDetection.FindTemplates(Portal.ImageDetection.Template, Portal.GameRegion, double, OpenCvSharp.TemplateMatchModes)') | Captures a region and tries to match a template to it. |
