#### [Portal](index.md 'index')
### [Portal.Input](Portal.Input.md 'Portal.Input').[Input](Input.md 'Portal.Input.Input')

## Input.RegisterHotkey(Keys, KeyModifiers, Action) Method

Registers a hotkey with the system.

```csharp
public static void RegisterHotkey(System.Windows.Forms.Keys InKey, Portal.Input.KeyModifiers InModifiers, System.Action InKeyPressCallback);
```
#### Parameters

<a name='Portal.Input.Input.RegisterHotkey(System.Windows.Forms.Keys,Portal.Input.KeyModifiers,System.Action).InKey'></a>

`InKey` [System.Windows.Forms.Keys](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Forms.Keys 'System.Windows.Forms.Keys')

Key you want to register.

<a name='Portal.Input.Input.RegisterHotkey(System.Windows.Forms.Keys,Portal.Input.KeyModifiers,System.Action).InModifiers'></a>

`InModifiers` [KeyModifiers](KeyModifiers.md 'Portal.Input.KeyModifiers')

A bitmask(flag) of the modifiers you want to register.

<a name='Portal.Input.Input.RegisterHotkey(System.Windows.Forms.Keys,Portal.Input.KeyModifiers,System.Action).InKeyPressCallback'></a>

`InKeyPressCallback` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Function that will be called when the hotkey is pressed.