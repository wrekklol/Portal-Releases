#### [Portal](index.md 'index')
### [Windows.Win32](Windows.Win32.md 'Windows.Win32').[PInvoke](PInvoke.md 'Windows.Win32.PInvoke')

## PInvoke.SendInput(Span<INPUT>, int) Method

Synthesizes keystrokes, mouse motions, and button clicks.

```csharp
internal static uint SendInput(System.Span<Windows.Win32.UI.Input.KeyboardAndMouse.INPUT> pInputs, int cbSize);
```
#### Parameters

<a name='Windows.Win32.PInvoke.SendInput(System.Span_Windows.Win32.UI.Input.KeyboardAndMouse.INPUT_,int).pInputs'></a>

`pInputs` [System.Span&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1')[INPUT](INPUT.md 'Windows.Win32.UI.Input.KeyboardAndMouse.INPUT')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1')

  
Type: <b>LPINPUT</b> An array of <a href="https://docs.microsoft.com/windows/desktop/api/winuser/ns-winuser-input">INPUT</a> structures. Each structure represents an event to be inserted into the keyboard or mouse input stream.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-sendinput#parameters 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-sendinput#parameters').

<a name='Windows.Win32.PInvoke.SendInput(System.Span_Windows.Win32.UI.Input.KeyboardAndMouse.INPUT_,int).cbSize'></a>

`cbSize` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

  
Type: <b>int</b> The size, in bytes, of an <a href="https://docs.microsoft.com/windows/desktop/api/winuser/ns-winuser-input">INPUT</a> structure. If <i>cbSize</i> is not the size of an <b>INPUT</b> structure, the function fails.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-sendinput#parameters 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-sendinput#parameters').

#### Returns
[System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')  
  
Type: <b>UINT</b> The function returns the number of events that it successfully inserted into the keyboard or mouse input stream. If the function returns zero, the input was already blocked by another thread. To get extended error information, call <a href="https://docs.microsoft.com/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a>. This function fails when it is blocked by UIPI. Note that neither <a href="https://docs.microsoft.com/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a> nor the return value will indicate the failure was caused by UIPI blocking.

### Remarks
  
This function is subject to UIPI. Applications are permitted to inject input only into applications that are at an equal or lesser integrity level. The <b>SendInput</b> function inserts the events in the <a href="https://docs.microsoft.com/windows/desktop/api/winuser/ns-winuser-input">INPUT</a> structures serially into the keyboard or mouse input stream. These events are not interspersed with other keyboard or mouse input events inserted either by the user (with the keyboard or mouse) or by calls to <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-keybd_event">keybd_event</a>, <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-mouse_event">mouse_event</a>, or other calls to <b>SendInput</b>. This function does not reset the keyboard's current state. Any keys that are already pressed when the function is called might interfere with the events that this function generates. To avoid this problem, check the keyboard's state with the <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-getasynckeystate">GetAsyncKeyState</a> function and correct as necessary. Because the touch keyboard uses the surrogate macros defined in winnls.h to send input to the system, a listener on the keyboard event hook must decode input originating from the touch keyboard. For more information, see <a href="https://docs.microsoft.com/windows/desktop/Intl/surrogates-and-supplementary-characters">Surrogates and Supplementary Characters</a>. An accessibility application can use <b>SendInput</b> to inject keystrokes corresponding to application launch shortcut keys that are handled by the shell.  This  functionality is not guaranteed to work for other types of applications.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-sendinput# 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-sendinput#').