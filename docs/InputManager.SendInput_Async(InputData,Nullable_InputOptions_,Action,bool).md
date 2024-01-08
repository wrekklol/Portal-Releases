#### [Portal](index.md 'index')
### [Portal.Input](Portal.Input.md 'Portal.Input').[InputManager](InputManager.md 'Portal.Input.InputManager')

## InputManager.SendInput_Async(InputData, Nullable<InputOptions>, Action, bool) Method

Sends input to the system, asynchronously.

```csharp
public static System.Threading.Tasks.Task SendInput_Async(Portal.Input.InputData InInput, System.Nullable<Portal.Input.InputOptions> InOptions=null, System.Action? InOnInputPressed=null, bool InbShouldPrint=true);
```
#### Parameters

<a name='Portal.Input.InputManager.SendInput_Async(Portal.Input.InputData,System.Nullable_Portal.Input.InputOptions_,System.Action,bool).InInput'></a>

`InInput` [InputData](InputData.md 'Portal.Input.InputData')

Input to send.

<a name='Portal.Input.InputManager.SendInput_Async(Portal.Input.InputData,System.Nullable_Portal.Input.InputOptions_,System.Action,bool).InOptions'></a>

`InOptions` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[InputOptions](InputOptions.md 'Portal.Input.InputOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

Input options to send with.

<a name='Portal.Input.InputManager.SendInput_Async(Portal.Input.InputData,System.Nullable_Portal.Input.InputOptions_,System.Action,bool).InOnInputPressed'></a>

`InOnInputPressed` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Action to call when input has been sent.

<a name='Portal.Input.InputManager.SendInput_Async(Portal.Input.InputData,System.Nullable_Portal.Input.InputOptions_,System.Action,bool).InbShouldPrint'></a>

`InbShouldPrint` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')