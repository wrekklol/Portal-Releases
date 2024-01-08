#### [Portal](index.md 'index')
### [Windows.Win32](Windows.Win32.md 'Windows.Win32').[PInvoke](PInvoke.md 'Windows.Win32.PInvoke')

## PInvoke.GetAsyncKeyState(int) Method

Determines whether a key is up or down at the time the function is called, and whether the key was pressed after a previous call to GetAsyncKeyState.

```csharp
internal static short GetAsyncKeyState(int vKey);
```
#### Parameters

<a name='Windows.Win32.PInvoke.GetAsyncKeyState(int).vKey'></a>

`vKey` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

  
Type: <b>int</b> The virtual-key code. For more information, see <a href="https://docs.microsoft.com/windows/desktop/inputdev/virtual-key-codes">Virtual Key Codes</a>. You can use left- and right-distinguishing constants to specify certain keys. See the Remarks section for further information.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getasynckeystate#parameters 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getasynckeystate#parameters').

#### Returns
[System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')  
  
Type: <b>SHORT</b> If the function succeeds, the return value specifies whether the key was pressed since the last call to <b>GetAsyncKeyState</b>, and whether the key is currently up or down. If the most significant bit is set, the key is down, and if the least significant bit is set, the key was pressed after the previous call to <b>GetAsyncKeyState</b>. However, you should not rely on this last behavior; for more information, see the Remarks. The return value is zero for the following cases:  
  
This doc was truncated.

### Remarks
  
The <b>GetAsyncKeyState</b> function works with mouse buttons. However, it checks on the state of the physical mouse buttons, not on the logical mouse buttons that the physical buttons are mapped to. For example, the call <b>GetAsyncKeyState</b>(VK_LBUTTON) always returns the state of the left physical mouse button, regardless of whether it is mapped to the left or right logical mouse button. You can determine the system's current mapping of physical mouse buttons to logical mouse buttons by calling `GetSystemMetrics(SM_SWAPBUTTON)`. which returns TRUE if the mouse buttons have been swapped. Although the least significant bit of the return value indicates whether the key has been pressed since the last query, due to the preemptive multitasking nature of Windows, another application can call <b>GetAsyncKeyState</b> and receive the "recently pressed" bit instead of your application. The behavior of the least significant bit of the return value is retained strictly for compatibility with 16-bit Windows applications (which are non-preemptive) and should not be relied upon. You can use the virtual-key code constants <b>VK_SHIFT</b>, <b>VK_CONTROL</b>, and <b>VK_MENU</b> as values for the <i>vKey</i> parameter. This gives the state of the SHIFT, CTRL, or ALT keys without distinguishing between left and right. You can use the following virtual-key code constants as values for <i>vKey</i> to distinguish between the left and right instances of those keys.  
  
This doc was truncated.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getasynckeystate# 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getasynckeystate#').