#### [Portal](index.md 'index')
### [Portal.Scripting](Portal.Scripting.md 'Portal.Scripting')

## ScriptModule Class

Module which contains scripted behaviours.

```csharp
public class ScriptModule :
Portal.IReloadable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ScriptModule

Implements [Portal.IReloadable](https://docs.microsoft.com/en-us/dotnet/api/Portal.IReloadable 'Portal.IReloadable')

### Example
There is an example of a module included, it is located in your Portal folder inside a folder called "Modules".  
  
To create a new module, simply create a new folder in your "Modules" folder, and create a file called "YourAwesomeModule.module", and a file called "YourAwesomeModule.include".   
  
To create a behaviour, simply create a new folder in your new module folder, you can call it whatever you like, though "Behaviours" is recommended. Then create a file called "YourAwesomeBehaviour.cs", in which you need to create a class that inherits from [IScriptBehaviour](IScriptBehaviour.md 'Portal.Scripting.IScriptBehaviour'), and has four functions called [Init()](IScriptBehaviour.Init().md 'Portal.Scripting.IScriptBehaviour.Init()'), [Start()](IScriptBehaviour.Start().md 'Portal.Scripting.IScriptBehaviour.Start()'), [Run()](IScriptBehaviour.Run().md 'Portal.Scripting.IScriptBehaviour.Run()') and [Stop()](IScriptBehaviour.Stop().md 'Portal.Scripting.IScriptBehaviour.Stop()').  
  
Example behaviour file:  
  
```csharp  
public class ExampleBehaviour : IScriptBehaviour  
{  
    public int LoopAmount => 3;  
  
  
  
    public void Init()  
    {  
        Print("Hello from Behaviour Initialization!");  
    }  
      
    public void Start()  
    {  
        Print("Hello from Behaviour Start!");  
    }  
  
    public void Run()  
    {  
        Print("Hello from Behaviour Run!");  
  
        // Finds a template from your "Templates" folder in your module folder, and clicks it!  
        //WaitUntilFound("Example Template")?.Draw().Click();  
    }  
      
    public void Stop()  
    {  
        Print("Hello from Behaviour Stop!");  
    }  
}  
```  
  
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
  
Some things are also statically included, which means you can use their variables and functions without having to prefix them with their type.   
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
   "Portal.Scripting",  
   "Portal.Utility", "Portal.Utility.ArrayHelpers", "Portal.Utility.DebugHelpers", "Portal.Utility.DelegateHelpers", "Portal.Utility.MathHelpers", "Portal.Utility.ScriptHelpers", "Portal.Utility.ThreadHelpers",  
   "Portal.Input", "Portal.Input.Input",  
   "Portal.Detection", "OpenCvSharp",  
   "System", "System.Linq", "System.Drawing", "System.Collections.Generic"  
};  
```

| Methods | |
| :--- | :--- |
| [LoadBehaviour(Type)](ScriptModule.LoadBehaviour(Type).md 'Portal.Scripting.ScriptModule.LoadBehaviour(System.Type)') | Call this in your .module file for each behaviour you want to load.<br/>Remember to put `#load "Behaviours\YourBehaviour.cs"` before calling this function to load the file first. |
