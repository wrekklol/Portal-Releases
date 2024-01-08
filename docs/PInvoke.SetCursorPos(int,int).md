#### [Portal](index.md 'index')
### [Windows.Win32](Windows.Win32.md 'Windows.Win32').[PInvoke](PInvoke.md 'Windows.Win32.PInvoke')

## PInvoke.SetCursorPos(int, int) Method

Moves the cursor to the specified screen coordinates.

```csharp
internal static Windows.Win32.Foundation.BOOL SetCursorPos(int X, int Y);
```
#### Parameters

<a name='Windows.Win32.PInvoke.SetCursorPos(int,int).X'></a>

`X` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

  
Type: <b>int</b> The new x-coordinate of the cursor, in screen coordinates.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setcursorpos#parameters 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setcursorpos#parameters').

<a name='Windows.Win32.PInvoke.SetCursorPos(int,int).Y'></a>

`Y` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

  
Type: <b>int</b> The new y-coordinate of the cursor, in screen coordinates.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setcursorpos#parameters 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setcursorpos#parameters').

#### Returns
[Windows.Win32.Foundation.BOOL](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Foundation.BOOL 'Windows.Win32.Foundation.BOOL')  
  
Type: <b>BOOL</b> Returns nonzero if successful or zero otherwise. To get extended error information, call <a href="https://docs.microsoft.com/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a>.

### Remarks
  
The cursor is a shared resource. A window should move the cursor only when the cursor is in the window's client area. The calling process must have <b>WINSTA_WRITEATTRIBUTES</b> access to the window station. The input desktop must be the current desktop when you call <b>SetCursorPos</b>. Call <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-openinputdesktop">OpenInputDesktop</a> to determine whether the current desktop is the input desktop. If it is not, call <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-setthreaddesktop">SetThreadDesktop</a> with the <b>HDESK</b> returned by <b>OpenInputDesktop</b> to switch to that desktop.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setcursorpos# 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setcursorpos#').