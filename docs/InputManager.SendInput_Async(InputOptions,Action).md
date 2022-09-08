#### [Portal](index.md 'index')
### [Portal.Input](Portal.Input.md 'Portal.Input').[InputManager](InputManager.md 'Portal.Input.InputManager')

## InputManager.SendInput_Async(InputOptions, Action) Method

Sends input to the system, asynchronously.

```csharp
public static System.Threading.Tasks.Task SendInput_Async(Portal.Input.InputOptions InOptions, System.Action? InOnInputPressed);
```
#### Parameters

<a name='Portal.Input.InputManager.SendInput_Async(Portal.Input.InputOptions,System.Action).InOptions'></a>

`InOptions` [InputOptions](InputOptions.md 'Portal.Input.InputOptions')

Input to send.

<a name='Portal.Input.InputManager.SendInput_Async(Portal.Input.InputOptions,System.Action).InOnInputPressed'></a>

`InOnInputPressed` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Action to call when input has been sent.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')