#### [Portal](index.md 'index')
### [Portal.Input](Portal.Input.md 'Portal.Input')

## SendInputOptions Struct

Input options.

```csharp
public struct SendInputOptions
```

| Constructors | |
| :--- | :--- |
| [SendInputOptions(Keys, int, int)](Portal.Input.SendInputOptions.SendInputOptions(System.Windows.Forms.Keys,int,int).md 'Portal.Input.SendInputOptions.SendInputOptions(System.Windows.Forms.Keys, int, int)') | SendInputOptions that takes a key, a press delay and a release delay. |
| [SendInputOptions(Keys, int)](Portal.Input.SendInputOptions.SendInputOptions(System.Windows.Forms.Keys,int).md 'Portal.Input.SendInputOptions.SendInputOptions(System.Windows.Forms.Keys, int)') | SendInputOptions that takes a key and a release delay. |
| [SendInputOptions(Keys, KeyModifiers, int, int, object)](Portal.Input.SendInputOptions.SendInputOptions(System.Windows.Forms.Keys,Portal.Input.KeyModifiers,int,int,object).md 'Portal.Input.SendInputOptions.SendInputOptions(System.Windows.Forms.Keys, Portal.Input.KeyModifiers, int, int, object)') | SendInputOptions that takes a key, modifiers, a press delay, a release delay and extra data. |
| [SendInputOptions(Keys, KeyModifiers, int)](Portal.Input.SendInputOptions.SendInputOptions(System.Windows.Forms.Keys,Portal.Input.KeyModifiers,int).md 'Portal.Input.SendInputOptions.SendInputOptions(System.Windows.Forms.Keys, Portal.Input.KeyModifiers, int)') | SendInputOptions that takes a key, modifiers and a release delay. |
| [SendInputOptions(Keys, KeyModifiers)](Portal.Input.SendInputOptions.SendInputOptions(System.Windows.Forms.Keys,Portal.Input.KeyModifiers).md 'Portal.Input.SendInputOptions.SendInputOptions(System.Windows.Forms.Keys, Portal.Input.KeyModifiers)') | SendInputOptions that takes a key and modifiers. |
| [SendInputOptions(Keys)](Portal.Input.SendInputOptions.SendInputOptions(System.Windows.Forms.Keys).md 'Portal.Input.SendInputOptions.SendInputOptions(System.Windows.Forms.Keys)') | SendInputOptions that only takes a key. |

| Properties | |
| :--- | :--- |
| [Data](Portal.Input.SendInputOptions.Data.md 'Portal.Input.SendInputOptions.Data') | Extra data to send, like scroll wheel delta. |
| [Key](Portal.Input.SendInputOptions.Key.md 'Portal.Input.SendInputOptions.Key') | Key to send. |
| [Modifiers](Portal.Input.SendInputOptions.Modifiers.md 'Portal.Input.SendInputOptions.Modifiers') | Modifiers to send key with. |
| [PressDelay](Portal.Input.SendInputOptions.PressDelay.md 'Portal.Input.SendInputOptions.PressDelay') | Delay before key press. |
| [ReleaseDelay](Portal.Input.SendInputOptions.ReleaseDelay.md 'Portal.Input.SendInputOptions.ReleaseDelay') | Delay before key release. |

| Operators | |
| :--- | :--- |
| [implicit operator SendInputOptions(Keys)](Portal.Input.SendInputOptions.op_ImplicitPortal.Input.SendInputOptions(System.Windows.Forms.Keys).md 'Portal.Input.SendInputOptions.op_Implicit Portal.Input.SendInputOptions(System.Windows.Forms.Keys)') | Cast operator. <br/> Allows you to cast [System.Windows.Forms.Keys](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Forms.Keys 'System.Windows.Forms.Keys') to input options. |
