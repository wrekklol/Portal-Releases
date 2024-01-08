#### [Portal](index.md 'index')
### [Windows.Win32](Windows.Win32.md 'Windows.Win32').[PInvoke](PInvoke.md 'Windows.Win32.PInvoke')

## PInvoke.SetWindowLong(HWND, WINDOW_LONG_PTR_INDEX, int) Method

Changes an attribute of the specified window. The function also sets the 32-bit (long) value at the specified offset into the extra window memory. (Unicode)

```csharp
internal static int SetWindowLong(Windows.Win32.Foundation.HWND hWnd, Windows.Win32.UI.WindowsAndMessaging.WINDOW_LONG_PTR_INDEX nIndex, int dwNewLong);
```
#### Parameters

<a name='Windows.Win32.PInvoke.SetWindowLong(Windows.Win32.Foundation.HWND,Windows.Win32.UI.WindowsAndMessaging.WINDOW_LONG_PTR_INDEX,int).hWnd'></a>

`hWnd` [Windows.Win32.Foundation.HWND](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Foundation.HWND 'Windows.Win32.Foundation.HWND')

  
Type: <b>HWND</b> A handle to the window and, indirectly, the class to which the window belongs.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setwindowlongw#parameters 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setwindowlongw#parameters').

<a name='Windows.Win32.PInvoke.SetWindowLong(Windows.Win32.Foundation.HWND,Windows.Win32.UI.WindowsAndMessaging.WINDOW_LONG_PTR_INDEX,int).nIndex'></a>

`nIndex` [Windows.Win32.UI.WindowsAndMessaging.WINDOW_LONG_PTR_INDEX](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.UI.WindowsAndMessaging.WINDOW_LONG_PTR_INDEX 'Windows.Win32.UI.WindowsAndMessaging.WINDOW_LONG_PTR_INDEX')

Type: <b>int</b>

<a name='Windows.Win32.PInvoke.SetWindowLong(Windows.Win32.Foundation.HWND,Windows.Win32.UI.WindowsAndMessaging.WINDOW_LONG_PTR_INDEX,int).dwNewLong'></a>

`dwNewLong` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

  
Type: <b>LONG</b> The replacement value.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setwindowlongw#parameters 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setwindowlongw#parameters').

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
Type: <b>LONG</b> If the function succeeds, the return value is the previous value of the specified 32-bit integer. If the function fails, the return value is zero. To get extended error information, call <a href="https://docs.microsoft.com/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a>. If the previous value of the specified 32-bit integer is zero, and the function succeeds, the return value is zero, but the function does not clear the last error information. This makes it difficult to determine success or failure. To deal with this, you should clear the last error information by calling <a href="https://docs.microsoft.com/windows/desktop/api/errhandlingapi/nf-errhandlingapi-setlasterror">SetLastError</a> with 0 before calling <b>SetWindowLong</b>. Then, function failure will be indicated by a return value of zero and a <a href="https://docs.microsoft.com/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a> result that is nonzero.

### Remarks
  
Certain window data is cached, so changes you make using <b>SetWindowLong</b> will not take effect until you call the <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-setwindowpos">SetWindowPos</a> function. Specifically, if you change any of the frame styles, you must call <b>SetWindowPos</b> with the <b>SWP_FRAMECHANGED</b> flag for the cache to be updated properly. If you use <b>SetWindowLong</b> with the <b>GWL_WNDPROC</b> index to replace the window procedure, the window procedure must conform to the guidelines specified in the description of the <a href="https://docs.microsoft.com/previous-versions/windows/desktop/legacy/ms633573(v=vs.85)">WindowProc</a> callback function. If you use <b>SetWindowLong</b> with the <b>DWL_MSGRESULT</b> index to set the return value for a message processed by a dialog procedure, you should return <b>TRUE</b> directly afterward. Otherwise, if you call any function that results in your dialog procedure receiving a window message, the nested window message could overwrite the return value you set using <b>DWL_MSGRESULT</b>. Calling <b>SetWindowLong</b> with the <b>GWL_WNDPROC</b> index creates a subclass of the window class used to create the window. An application can subclass a system class, but should not subclass a window class created by another process. The <b>SetWindowLong</b> function creates the window subclass by changing the window procedure associated with a particular window class, causing the system to call the new window procedure instead of the previous one. An application must pass any messages not processed by the new window procedure to the previous window procedure by calling <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-callwindowproca">CallWindowProc</a>. This allows the application to create a chain of window procedures. Reserve extra window memory by specifying a nonzero value in the <b>cbWndExtra</b> member of the <a href="https://docs.microsoft.com/windows/desktop/api/winuser/ns-winuser-wndclassexa">WNDCLASSEX</a> structure used with the <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-registerclassexa">RegisterClassEx</a> function. You must not call <b>SetWindowLong</b> with the <b>GWL_HWNDPARENT</b> index to change the parent of a child window. Instead, use the <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-setparent">SetParent</a> function. If the window has a class style of <b>CS_CLASSDC</b> or <b>CS_OWNDC</b>, do not set the extended window styles <b>WS_EX_COMPOSITED</b> or <b>WS_EX_LAYERED</b>. Calling <b>SetWindowLong</b> to set the style on a progressbar will reset its position.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setwindowlongw# 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setwindowlongw#').