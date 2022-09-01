#### [Portal](index.md 'index')
### [Portal.Scripting.CSharp](Portal.Scripting.CSharp.md 'Portal.Scripting.CSharp')

## CSharpModule Class

Module which contains behaviours scripted in c#.

```csharp
public class CSharpModule : Portal.Scripting.ScriptModule
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Portal.Scripting.ScriptModule](https://docs.microsoft.com/en-us/dotnet/api/Portal.Scripting.ScriptModule 'Portal.Scripting.ScriptModule') &#129106; CSharpModule

### Example
There is an example of a module on the github page (in the "Code" section).  
  
To create a new module, simply create a new folder in your "Modules" folder, and create a file called "YourAwesomeModule.module", and a file called "YourAwesomeModule.include".   
  
To create a behaviour, simply create a new folder in your new module folder, you can call it whatever you like, though "Behaviours" is recommended. Then create a file called "YourAwesomeBehaviour.cs", in which you need to create a class that inherits from [IScriptBehaviour](Portal.Scripting.IScriptBehaviour.md 'Portal.Scripting.IScriptBehaviour'), and has a property called [BehaviourName](Portal.Scripting.IScriptBehaviour.BehaviourName.md 'Portal.Scripting.IScriptBehaviour.BehaviourName'), and two functions called [Init()](Portal.Scripting.IScriptBehaviour.Init().md 'Portal.Scripting.IScriptBehaviour.Init()') and [Run()](Portal.Scripting.IScriptBehaviour.Run().md 'Portal.Scripting.IScriptBehaviour.Run()').  
Then you just need to add the new behaviour to your .module file. To do this, just add two lines:  
  
```csharp  
#load "Behaviours\YourAwesomeBehaviour.cs"  
LoadBehaviour(typeof(YourAwesomeBehaviour));  
```  
  
That's it! Now you can run your module from the GUI, but you should probably put something in the functions you created first.  
  
Behaviours are compiled with some default includes (`using NamespaceHere;`). If more is needed, put them into your .include file without the "using" part and without the semi colon.  
Example .include file:  
  
```csharp  
System.Threading  
System.Reflection  
ThisCustomNamespaceIsIncluded1  
ThisCustomNamespaceIsIncluded2  
ThisCustomNamespaceIsIncluded3  
```  
Those namespaces will now get included on compilation so your behaviours can use them.  
  
Some things are also statically included, which means you can use their properties and functions without having to prefix them with their type.   
So for example you can just type:  
  
```csharp  
Print("Hello World!");  
```  
Without having to type  
  
```csharp  
Printer.Print("Hello World!");  
```

### Remarks
Default includes of a CSharp Module:  
  
```csharp  
private readonly string[] CommonIncludes =  
{  
    "Portal",  
    "Portal.Globals",  
    "Portal.Printer",  
    "Portal.Scripting", "Portal.Scripting.CSharp",  
    "Portal.Utility", "Portal.Utility.ScriptHelpers",  
    "Portal.Input", "Portal.Input.Input",  
    "Portal.ImageDetection", "OpenCvSharp",  
    "System", "System.Linq", "System.Drawing", "System.Collections.Generic",  
};  
```