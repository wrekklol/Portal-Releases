#### [Portal](index.md 'index')
### [Portal.Input](Portal.Input.md 'Portal.Input').[InputManager](InputManager.md 'Portal.Input.InputManager')

## InputManager.BindKey(EKey, Action, EKeyModifier, bool) Method

Binds a key to an action.

```csharp
public static void BindKey(Portal.Input.EKey InKey, System.Action InAction, Portal.Input.EKeyModifier InModifierKeys, bool InbExactModifiers);
```
#### Parameters

<a name='Portal.Input.InputManager.BindKey(Portal.Input.EKey,System.Action,Portal.Input.EKeyModifier,bool).InKey'></a>

`InKey` [EKey](EKey.md 'Portal.Input.EKey')

Key to bind.

<a name='Portal.Input.InputManager.BindKey(Portal.Input.EKey,System.Action,Portal.Input.EKeyModifier,bool).InAction'></a>

`InAction` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Action to bind.

<a name='Portal.Input.InputManager.BindKey(Portal.Input.EKey,System.Action,Portal.Input.EKeyModifier,bool).InModifierKeys'></a>

`InModifierKeys` [EKeyModifier](EKeyModifier.md 'Portal.Input.EKeyModifier')

Modifier keys to bind.

<a name='Portal.Input.InputManager.BindKey(Portal.Input.EKey,System.Action,Portal.Input.EKeyModifier,bool).InbExactModifiers'></a>

`InbExactModifiers` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Whater to check for exact modifiers.