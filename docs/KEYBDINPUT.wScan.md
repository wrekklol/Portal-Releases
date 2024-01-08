#### [Portal](index.md 'index')
### [Windows.Win32.UI.Input.KeyboardAndMouse](Windows.Win32.UI.Input.KeyboardAndMouse.md 'Windows.Win32.UI.Input.KeyboardAndMouse').[KEYBDINPUT](KEYBDINPUT.md 'Windows.Win32.UI.Input.KeyboardAndMouse.KEYBDINPUT')

## KEYBDINPUT.wScan Field

  
Type: <b>WORD</b> A hardware scan code for the key. If <b>dwFlags</b> specifies <b>KEYEVENTF_UNICODE</b>, <b>wScan</b> specifies a Unicode character which is to be sent to the foreground application.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-keybdinput#members 'https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-keybdinput#members').

```csharp
internal ushort wScan;
```

#### Field Value
[System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')