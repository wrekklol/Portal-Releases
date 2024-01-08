#### [Portal](index.md 'index')
### [Portal.Script](Portal.Script.md 'Portal.Script')

## ScriptModule Class

Module which contains scripted behaviors.

```csharp
public class ScriptModule
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ScriptModule

Derived  
&#8627; [PythonModule](PythonModule.md 'Portal.Script.Languages.PythonModule')

| Properties | |
| :--- | :--- |
| [Behaviors](ScriptModule.Behaviors.md 'Portal.Script.ScriptModule.Behaviors') | Behaviors in the module. |
| [bHasScriptChanged](ScriptModule.bHasScriptChanged.md 'Portal.Script.ScriptModule.bHasScriptChanged') | Whether the module's script has changed since last reload. |
| [ErrorCount](ScriptModule.ErrorCount.md 'Portal.Script.ScriptModule.ErrorCount') | Amount of errors that occurred while compiling the module. |
| [Files](ScriptModule.Files.md 'Portal.Script.ScriptModule.Files') | Files in the module. |
| [ModuleData](ScriptModule.ModuleData.md 'Portal.Script.ScriptModule.ModuleData') | Module's data, like module type, accepted extensions, etc. |
| [ModuleFile](ScriptModule.ModuleFile.md 'Portal.Script.ScriptModule.ModuleFile') | Module's main file. |
| [ModuleHash](ScriptModule.ModuleHash.md 'Portal.Script.ScriptModule.ModuleHash') | Hash of the module's folder. |
| [ModulePath](ScriptModule.ModulePath.md 'Portal.Script.ScriptModule.ModulePath') | Path to the module. |
| [Name](ScriptModule.Name.md 'Portal.Script.ScriptModule.Name') | Name of the module. |
| [TemplatePath](ScriptModule.TemplatePath.md 'Portal.Script.ScriptModule.TemplatePath') | Path to the module's template folder. |
| [Templates](ScriptModule.Templates.md 'Portal.Script.ScriptModule.Templates') | Templates in the module. |

| Methods | |
| :--- | :--- |
| [CompileModule()](ScriptModule.CompileModule().md 'Portal.Script.ScriptModule.CompileModule()') | Compiles the module. |
| [Initialize(ScriptFile)](ScriptModule.Initialize(ScriptFile).md 'Portal.Script.ScriptModule.Initialize(Portal.Script.ScriptFile)') | Initializes the module. |
| [InitializeFile(string)](ScriptModule.InitializeFile(string).md 'Portal.Script.ScriptModule.InitializeFile(string)') | Initializes a script file. |
| [LoadTemplates()](ScriptModule.LoadTemplates().md 'Portal.Script.ScriptModule.LoadTemplates()') | Loads the module's templates.<br/>Templates are loaded from the module's [TemplatePath](ScriptModule.TemplatePath.md 'Portal.Script.ScriptModule.TemplatePath').<br/><br/>Each template is loaded as a [Template](Template.md 'Portal.Detect.Template') object, which contains the template's name, image, mask, and metadata.<br/>If a template has an associated .meta file, the metadata will be loaded from it. |
| [Reload()](ScriptModule.Reload().md 'Portal.Script.ScriptModule.Reload()') | Reloads the module. |
