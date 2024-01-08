#### [Portal](index.md 'index')
### [Windows.Win32](Windows.Win32.md 'Windows.Win32').[PInvoke](PInvoke.md 'Windows.Win32.PInvoke')

## PInvoke.SetForegroundWindow(HWND) Method

Brings the thread that created the specified window into the foreground and activates the window.

```csharp
internal static Windows.Win32.Foundation.BOOL SetForegroundWindow(Windows.Win32.Foundation.HWND hWnd);
```
#### Parameters

<a name='Windows.Win32.PInvoke.SetForegroundWindow(Windows.Win32.Foundation.HWND).hWnd'></a>

`hWnd` [Windows.Win32.Foundation.HWND](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Foundation.HWND 'Windows.Win32.Foundation.HWND')

  
Type: <b>HWND</b> A handle to the window that should be activated and brought to the foreground.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setforegroundwindow#parameters 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setforegroundwindow#parameters').

#### Returns
[Windows.Win32.Foundation.BOOL](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Foundation.BOOL 'Windows.Win32.Foundation.BOOL')  
  
Type: <b>BOOL</b> If the window was brought to the foreground, the return value is nonzero. If the window was not brought to the foreground, the return value is zero.

### Remarks
  
The system restricts which processes can set the foreground window. A process can set the foreground window by calling **SetForegroundWindow** only if: - All of the following conditions are true: - The calling process belongs to a desktop application, not a UWP app or a Windows Store app designed for Windows 8 or 8.1. - The foreground process has not disabled calls to **SetForegroundWindow** by a previous call to the [**LockSetForegroundWindow**](nf-winuser-locksetforegroundwindow.md) function. - The foreground lock time-out has expired (see [**SPI_GETFOREGROUNDLOCKTIMEOUT** in **SystemParametersInfo**](nf-winuser-systemparametersinfoa.md#SPI_GETFOREGROUNDLOCKTIMEOUT)). - No menus are active. - Additionally, at least one of the following conditions is true: - The calling process is the foreground process. - The calling process was started by the foreground process. - There is currently no foreground window, and thus no foreground process. - The calling process received the last input event. - Either the foreground process or the calling process is being debugged. It is possible for a process to be denied the right to set the foreground window even if it meets these conditions. An application cannot force a window to the foreground while the user is working with another window. Instead, Windows flashes the taskbar button of the window to notify the user. A process that can set the foreground window can enable another process to set the foreground window by calling the [**AllowSetForegroundWindow**](nf-winuser-allowsetforegroundwindow.md) function. The process specified by the *dwProcessId* parameter to **AllowSetForegroundWindow** loses the ability to set the foreground window the next time that either the user generates input, unless the input is directed at that process, or the next time a process calls **AllowSetForegroundWindow**, unless the same process is specified as in the previous call to **AllowSetForegroundWindow**. The foreground process can disable calls to <b>SetForegroundWindow</b> by calling the [**LockSetForegroundWindow**](nf-winuser-locksetforegroundwindow.md) function.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setforegroundwindow# 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setforegroundwindow#').