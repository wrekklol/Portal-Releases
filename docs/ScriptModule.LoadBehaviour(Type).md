#### [Portal](index.md 'index')
### [Portal.Scripting](Portal.Scripting.md 'Portal.Scripting').[ScriptModule](ScriptModule.md 'Portal.Scripting.ScriptModule')

## ScriptModule.LoadBehaviour(Type) Method

Call this in your .module file for each behaviour you want to load.  
Remember to put `#load "Behaviours\YourBehaviour.cs"` before calling this function to load the file first.

```csharp
public void LoadBehaviour(System.Type? InBehaviour);
```
#### Parameters

<a name='Portal.Scripting.ScriptModule.LoadBehaviour(System.Type).InBehaviour'></a>

`InBehaviour` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')