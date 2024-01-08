#### [Portal](index.md 'index')
### [Portal.Input](Portal.Input.md 'Portal.Input')

## InputData Struct

Input data.

```csharp
public struct InputData
```

| Constructors | |
| :--- | :--- |
| [InputData(EKey, EKeyState, Nullable&lt;uint&gt;)](InputData.InputData(EKey,EKeyState,Nullable_uint_).md 'Portal.Input.InputData.InputData(Portal.Input.EKey, Portal.Input.EKeyState, System.Nullable<uint>)') | InputOptions constructor that takes a press delay, a release delay and extra data. |

| Properties | |
| :--- | :--- |
| [Data](InputData.Data.md 'Portal.Input.InputData.Data') | Extra data to send, like scroll wheel delta, or which mouse X button was pressed. |
| [Key](InputData.Key.md 'Portal.Input.InputData.Key') | Key to send. |
| [KeyState](InputData.KeyState.md 'Portal.Input.InputData.KeyState') | Key state to send key with (Up or Down). |

| Methods | |
| :--- | :--- |
| [IsMouseInput()](InputData.IsMouseInput().md 'Portal.Input.InputData.IsMouseInput()') | Checks if this is mouse input. |

| Operators | |
| :--- | :--- |
| [implicit operator InputData(EKey)](InputData.implicitoperatorInputData(EKey).md 'Portal.Input.InputData.op_Implicit Portal.Input.InputData(Portal.Input.EKey)') | Cast operator. <br/> Allows you to cast [EKey](EKey.md 'Portal.Input.EKey') to input. |
