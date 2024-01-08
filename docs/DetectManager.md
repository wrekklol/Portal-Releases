#### [Portal](index.md 'index')
### [Portal.Detect](Portal.Detect.md 'Portal.Detect')

## DetectManager Class

Manager for detecting an image([Template](Template.md 'Portal.Detect.Template')) on the screen.  
  
There are functions in [ScriptCallables](ScriptCallables.md 'Portal.Script.ScriptCallables') which should be used instead of these functions, as these are only intended to be "base" functions to find templates.

```csharp
public class DetectManager : Portal.Singleton<Portal.Detect.DetectManager>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Portal.Singleton&lt;](https://docs.microsoft.com/en-us/dotnet/api/Portal.Singleton-1 'Portal.Singleton`1')[DetectManager](DetectManager.md 'Portal.Detect.DetectManager')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Portal.Singleton-1 'Portal.Singleton`1') &#129106; DetectManager

| Methods | |
| :--- | :--- |
| [FindMatchesInternal(Template, SearchOptions, bool)](DetectManager.FindMatchesInternal(Template,SearchOptions,bool).md 'Portal.Detect.DetectManager.FindMatchesInternal(Portal.Detect.Template, Portal.Detect.SearchOptions, bool)') | Captures a region and tries to compare a template to it. |
| [FindMatchesInternal(IEnumerable&lt;Template&gt;, SearchOptions, bool)](DetectManager.FindMatchesInternal(IEnumerable_Template_,SearchOptions,bool).md 'Portal.Detect.DetectManager.FindMatchesInternal(System.Collections.Generic.IEnumerable<Portal.Detect.Template>, Portal.Detect.SearchOptions, bool)') | Captures a region and tries to compare a template to it. |
| [FindMatchInternal(Template, SearchOptions, bool)](DetectManager.FindMatchInternal(Template,SearchOptions,bool).md 'Portal.Detect.DetectManager.FindMatchInternal(Portal.Detect.Template, Portal.Detect.SearchOptions, bool)') | Captures a region and tries to compare a template to it. |
