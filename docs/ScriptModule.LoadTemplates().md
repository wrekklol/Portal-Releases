#### [Portal](index.md 'index')
### [Portal.Script](Portal.Script.md 'Portal.Script').[ScriptModule](ScriptModule.md 'Portal.Script.ScriptModule')

## ScriptModule.LoadTemplates() Method

Loads the module's templates.  
Templates are loaded from the module's [TemplatePath](ScriptModule.TemplatePath.md 'Portal.Script.ScriptModule.TemplatePath').  
  
Each template is loaded as a [Template](Template.md 'Portal.Detect.Template') object, which contains the template's name, image, mask, and metadata.  
If a template has an associated .meta file, the metadata will be loaded from it.

```csharp
public virtual void LoadTemplates();
```