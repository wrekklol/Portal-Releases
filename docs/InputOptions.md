#### [Portal](index.md 'index')
### [Portal.Input](Portal.Input.md 'Portal.Input')

## InputOptions Struct

Input options.

```csharp
public struct InputOptions
```

| Constructors | |
| :--- | :--- |
| [InputOptions(EKeyModifier, int, int, bool)](InputOptions.InputOptions(EKeyModifier,int,int,bool).md 'Portal.Input.InputOptions.InputOptions(Portal.Input.EKeyModifier, int, int, bool)') | InputOptions constructor that takes modifiers, a press delay and a release delay. |

| Properties | |
| :--- | :--- |
| [bForceSend](InputOptions.bForceSend.md 'Portal.Input.InputOptions.bForceSend') | Sends even when script is stopped. |
| [Modifiers](InputOptions.Modifiers.md 'Portal.Input.InputOptions.Modifiers') | Modifiers to send key with. |
| [PressDelay](InputOptions.PressDelay.md 'Portal.Input.InputOptions.PressDelay') | Delay before key press. |
| [ReleaseDelay](InputOptions.ReleaseDelay.md 'Portal.Input.InputOptions.ReleaseDelay') | Delay before key release. |

| Operators | |
| :--- | :--- |
| [implicit operator InputOptions(EKeyModifier)](InputOptions.implicitoperatorInputOptions(EKeyModifier).md 'Portal.Input.InputOptions.op_Implicit Portal.Input.InputOptions(Portal.Input.EKeyModifier)') | Cast operator. <br/> Allows you to cast [EKeyModifier](EKeyModifier.md 'Portal.Input.EKeyModifier') to input options. |
