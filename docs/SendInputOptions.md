#### [Portal](index.md 'index')
### [Portal.Input](Portal.Input.md 'Portal.Input')

## SendInputOptions Struct

Input options.

```csharp
public struct SendInputOptions
```

| Constructors | |
| :--- | :--- |
| [SendInputOptions(Keys, KeyModifiers, int, int, object)](SendInputOptions.SendInputOptions(Keys,KeyModifiers,int,int,object).md 'Portal.Input.SendInputOptions.SendInputOptions(System.Windows.Forms.Keys, Portal.Input.KeyModifiers, int, int, object)') | SendInputOptions that takes a key, modifiers, a press delay, a release delay and extra data. |

| Properties | |
| :--- | :--- |
| [Data](SendInputOptions.Data.md 'Portal.Input.SendInputOptions.Data') | Extra data to send, like scroll wheel delta. |
| [Key](SendInputOptions.Key.md 'Portal.Input.SendInputOptions.Key') | Key to send. |
| [Modifiers](SendInputOptions.Modifiers.md 'Portal.Input.SendInputOptions.Modifiers') | Modifiers to send key with. |
| [PressDelay](SendInputOptions.PressDelay.md 'Portal.Input.SendInputOptions.PressDelay') | Delay before key press. |
| [ReleaseDelay](SendInputOptions.ReleaseDelay.md 'Portal.Input.SendInputOptions.ReleaseDelay') | Delay before key release. |

| Operators | |
| :--- | :--- |
| [implicit operator SendInputOptions(Keys)](SendInputOptions.implicitoperatorSendInputOptions(Keys).md 'Portal.Input.SendInputOptions.op_Implicit Portal.Input.SendInputOptions(System.Windows.Forms.Keys)') | Cast operator. <br/> Allows you to cast [System.Windows.Forms.Keys](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Forms.Keys 'System.Windows.Forms.Keys') to input options. |
