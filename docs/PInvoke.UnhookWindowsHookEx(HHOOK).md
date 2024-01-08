#### [Portal](index.md 'index')
### [Windows.Win32](Windows.Win32.md 'Windows.Win32').[PInvoke](PInvoke.md 'Windows.Win32.PInvoke')

## PInvoke.UnhookWindowsHookEx(HHOOK) Method

Removes a hook procedure installed in a hook chain by the SetWindowsHookEx function.

```csharp
internal static Windows.Win32.Foundation.BOOL UnhookWindowsHookEx(Windows.Win32.UI.WindowsAndMessaging.HHOOK hhk);
```
#### Parameters

<a name='Windows.Win32.PInvoke.UnhookWindowsHookEx(Windows.Win32.UI.WindowsAndMessaging.HHOOK).hhk'></a>

`hhk` [Windows.Win32.UI.WindowsAndMessaging.HHOOK](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.UI.WindowsAndMessaging.HHOOK 'Windows.Win32.UI.WindowsAndMessaging.HHOOK')

  
Type: <b>HHOOK</b> A handle to the hook to be removed. This parameter is a hook handle obtained by a previous call to <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-setwindowshookexa">SetWindowsHookEx</a>.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-unhookwindowshookex#parameters 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-unhookwindowshookex#parameters').

#### Returns
[Windows.Win32.Foundation.BOOL](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Foundation.BOOL 'Windows.Win32.Foundation.BOOL')  
  
Type: <b>BOOL</b> If the function succeeds, the return value is nonzero. If the function fails, the return value is zero. To get extended error information, call <a href="https://docs.microsoft.com/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a>.

### Remarks
The hook procedure can be in the state of being called by another thread even after <b>UnhookWindowsHookEx</b> returns. If the hook procedure is not being called concurrently, the hook procedure is removed immediately before <b>UnhookWindowsHookEx</b> returns.