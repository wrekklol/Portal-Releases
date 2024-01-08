#### [Portal](index.md 'index')
### [Windows.Win32](Windows.Win32.md 'Windows.Win32').[PInvoke](PInvoke.md 'Windows.Win32.PInvoke')

## PInvoke.GetWindowLong(HWND, WINDOW_LONG_PTR_INDEX) Method

Retrieves information about the specified window. (GetWindowLongW)

```csharp
internal static int GetWindowLong(Windows.Win32.Foundation.HWND hWnd, Windows.Win32.UI.WindowsAndMessaging.WINDOW_LONG_PTR_INDEX nIndex);
```
#### Parameters

<a name='Windows.Win32.PInvoke.GetWindowLong(Windows.Win32.Foundation.HWND,Windows.Win32.UI.WindowsAndMessaging.WINDOW_LONG_PTR_INDEX).hWnd'></a>

`hWnd` [Windows.Win32.Foundation.HWND](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Foundation.HWND 'Windows.Win32.Foundation.HWND')

  
Type: <b>HWND</b> A handle to the window and, indirectly, the class to which the window belongs.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getwindowlongw#parameters 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getwindowlongw#parameters').

<a name='Windows.Win32.PInvoke.GetWindowLong(Windows.Win32.Foundation.HWND,Windows.Win32.UI.WindowsAndMessaging.WINDOW_LONG_PTR_INDEX).nIndex'></a>

`nIndex` [Windows.Win32.UI.WindowsAndMessaging.WINDOW_LONG_PTR_INDEX](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.UI.WindowsAndMessaging.WINDOW_LONG_PTR_INDEX 'Windows.Win32.UI.WindowsAndMessaging.WINDOW_LONG_PTR_INDEX')

Type: <b>int</b>

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
Type: <b>LONG</b> If the function succeeds, the return value is the requested value. If the function fails, the return value is zero. To get extended error information, call <a href="https://docs.microsoft.com/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a>. If <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-setwindowlonga">SetWindowLong</a> has not been called previously, <b>GetWindowLong</b> returns zero for values in the extra window or class memory.

### Remarks
  
Reserve extra window memory by specifying a nonzero value in the <b>cbWndExtra</b> member of the <a href="https://docs.microsoft.com/windows/desktop/api/winuser/ns-winuser-wndclassexa">WNDCLASSEX</a> structure used with the <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-registerclassexa">RegisterClassEx</a> function.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getwindowlongw# 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getwindowlongw#').