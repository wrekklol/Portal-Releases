#### [Portal](index.md 'index')
### [Windows.Win32.UI.Input.KeyboardAndMouse](Windows.Win32.UI.Input.KeyboardAndMouse.md 'Windows.Win32.UI.Input.KeyboardAndMouse')

## INPUT Struct

Used by SendInput to store information for synthesizing input events such as keystrokes, mouse movement, and mouse clicks.

```csharp
internal struct INPUT
```

### Remarks
<b> INPUT_KEYBOARD</b> supports nonkeyboard input methods, such as handwriting recognition or voice recognition, as if it were text input by using the <b>KEYEVENTF_UNICODE</b> flag. For more information, see the remarks section of <a href="https://docs.microsoft.com/windows/desktop/api/winuser/ns-winuser-keybdinput">KEYBDINPUT</a>.

| Fields | |
| :--- | :--- |
| [type](INPUT.type.md 'Windows.Win32.UI.Input.KeyboardAndMouse.INPUT.type') | Type: <b>DWORD</b> |
