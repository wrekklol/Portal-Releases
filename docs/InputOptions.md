#### [Portal](index.md 'index')
### [Portal.Input](Portal.Input.md 'Portal.Input')

## InputOptions Struct

Input options.

```csharp
public struct InputOptions
```

| Constructors | |
| :--- | :--- |
| [InputOptions(EKeys, EKeyState, EKeyModifiers, int, int, bool, Nullable&lt;uint&gt;)](InputOptions.InputOptions(EKeys,EKeyState,EKeyModifiers,int,int,bool,Nullable_uint_).md 'Portal.Input.InputOptions.InputOptions(Portal.Input.EKeys, Portal.Input.EKeyState, Portal.Input.EKeyModifiers, int, int, bool, System.Nullable<uint>)') | SendInputOptions that takes a key, modifiers, a press delay, a release delay, auto release info and extra data. |

| Properties | |
| :--- | :--- |
| [bAutoReleaseModifiers](InputOptions.bAutoReleaseModifiers.md 'Portal.Input.InputOptions.bAutoReleaseModifiers') | If true, extra events with release input modifiers will be sent. |
| [Data](InputOptions.Data.md 'Portal.Input.InputOptions.Data') | Extra data to send, like scroll wheel delta, or which mouse X button was pressed. |
| [Key](InputOptions.Key.md 'Portal.Input.InputOptions.Key') | Key to send. |
| [KeyState](InputOptions.KeyState.md 'Portal.Input.InputOptions.KeyState') | Key state to send key with (Up or Down). |
| [Modifiers](InputOptions.Modifiers.md 'Portal.Input.InputOptions.Modifiers') | Modifiers to send key with. |
| [PressDelay](InputOptions.PressDelay.md 'Portal.Input.InputOptions.PressDelay') | Delay before key press. |
| [ReleaseDelay](InputOptions.ReleaseDelay.md 'Portal.Input.InputOptions.ReleaseDelay') | Delay before key release. |

| Operators | |
| :--- | :--- |
| [implicit operator InputOptions(EKeys)](InputOptions.implicitoperatorInputOptions(EKeys).md 'Portal.Input.InputOptions.op_Implicit Portal.Input.InputOptions(Portal.Input.EKeys)') | Cast operator. <br/> Allows you to cast [Portal.Input.EKeys](https://docs.microsoft.com/en-us/dotnet/api/Portal.Input.EKeys 'Portal.Input.EKeys') to input options. |
| [implicit operator InputOptions(string)](InputOptions.implicitoperatorInputOptions(string).md 'Portal.Input.InputOptions.op_Implicit Portal.Input.InputOptions(string)') | Cast operator. <br/>           Allows you to cast an input binding string to input options. |
