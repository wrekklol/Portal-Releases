#### [Portal](index.md 'index')
### [Portal.Input](Portal.Input.md 'Portal.Input').[Input](Portal.Input.Input.md 'Portal.Input.Input')

## Input.RegisterHotkey(Keys, Action) Method

Registers a hotkey with the system.

```csharp
public static void RegisterHotkey(System.Windows.Forms.Keys InKey, System.Action InKeyPressCallback);
```
#### Parameters

<a name='Portal.Input.Input.RegisterHotkey(System.Windows.Forms.Keys,System.Action).InKey'></a>

`InKey` [System.Windows.Forms.Keys](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Forms.Keys 'System.Windows.Forms.Keys')

Key you want to register.

<a name='Portal.Input.Input.RegisterHotkey(System.Windows.Forms.Keys,System.Action).InKeyPressCallback'></a>

`InKeyPressCallback` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Function that will be called when the hotkey is pressed.