#### [Portal](index.md 'index')
### [Portal.Input](Portal.Input.md 'Portal.Input').[InputManager](InputManager.md 'Portal.Input.InputManager')

## InputManager.BindKey(EKey, Action, EKeyState, EKeyModifier, bool, bool) Method

Binds a key to an action.

```csharp
public static void BindKey(Portal.Input.EKey InKey, System.Action InAction, Portal.Input.EKeyState InKeyState, Portal.Input.EKeyModifier InModifierKeys, bool bExactModifiers, bool InbCaptureInput);
```
#### Parameters

<a name='Portal.Input.InputManager.BindKey(Portal.Input.EKey,System.Action,Portal.Input.EKeyState,Portal.Input.EKeyModifier,bool,bool).InKey'></a>

`InKey` [EKey](EKey.md 'Portal.Input.EKey')

Key to bind.

<a name='Portal.Input.InputManager.BindKey(Portal.Input.EKey,System.Action,Portal.Input.EKeyState,Portal.Input.EKeyModifier,bool,bool).InAction'></a>

`InAction` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Action to bind.

<a name='Portal.Input.InputManager.BindKey(Portal.Input.EKey,System.Action,Portal.Input.EKeyState,Portal.Input.EKeyModifier,bool,bool).InKeyState'></a>

`InKeyState` [EKeyState](EKeyState.md 'Portal.Input.EKeyState')

Key state(Up or Down) to bind.

<a name='Portal.Input.InputManager.BindKey(Portal.Input.EKey,System.Action,Portal.Input.EKeyState,Portal.Input.EKeyModifier,bool,bool).InModifierKeys'></a>

`InModifierKeys` [EKeyModifier](EKeyModifier.md 'Portal.Input.EKeyModifier')

Modifier keys to bind.

<a name='Portal.Input.InputManager.BindKey(Portal.Input.EKey,System.Action,Portal.Input.EKeyState,Portal.Input.EKeyModifier,bool,bool).bExactModifiers'></a>

`bExactModifiers` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Whater to check for exact modifiers.

<a name='Portal.Input.InputManager.BindKey(Portal.Input.EKey,System.Action,Portal.Input.EKeyState,Portal.Input.EKeyModifier,bool,bool).InbCaptureInput'></a>

`InbCaptureInput` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Whater to capture input.