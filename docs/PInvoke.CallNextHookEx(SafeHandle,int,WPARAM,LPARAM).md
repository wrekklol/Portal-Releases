#### [Portal](index.md 'index')
### [Windows.Win32](Windows.Win32.md 'Windows.Win32').[PInvoke](PInvoke.md 'Windows.Win32.PInvoke')

## PInvoke.CallNextHookEx(SafeHandle, int, WPARAM, LPARAM) Method

Passes the hook information to the next hook procedure in the current hook chain. A hook procedure can call this function either before or after processing the hook information.

```csharp
internal static Windows.Win32.Foundation.LRESULT CallNextHookEx(System.Runtime.InteropServices.SafeHandle hhk, int nCode, Windows.Win32.Foundation.WPARAM wParam, Windows.Win32.Foundation.LPARAM lParam);
```
#### Parameters

<a name='Windows.Win32.PInvoke.CallNextHookEx(System.Runtime.InteropServices.SafeHandle,int,Windows.Win32.Foundation.WPARAM,Windows.Win32.Foundation.LPARAM).hhk'></a>

`hhk` [System.Runtime.InteropServices.SafeHandle](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.InteropServices.SafeHandle 'System.Runtime.InteropServices.SafeHandle')

  
Type: <b>HHOOK</b> This parameter is ignored.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-callnexthookex#parameters 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-callnexthookex#parameters').

<a name='Windows.Win32.PInvoke.CallNextHookEx(System.Runtime.InteropServices.SafeHandle,int,Windows.Win32.Foundation.WPARAM,Windows.Win32.Foundation.LPARAM).nCode'></a>

`nCode` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

  
Type: <b>int</b> The hook code passed to the current hook procedure. The next hook procedure uses this code to determine how to process the hook information.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-callnexthookex#parameters 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-callnexthookex#parameters').

<a name='Windows.Win32.PInvoke.CallNextHookEx(System.Runtime.InteropServices.SafeHandle,int,Windows.Win32.Foundation.WPARAM,Windows.Win32.Foundation.LPARAM).wParam'></a>

`wParam` [Windows.Win32.Foundation.WPARAM](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Foundation.WPARAM 'Windows.Win32.Foundation.WPARAM')

  
Type: <b>WPARAM</b> The <i>wParam</i> value passed to the current hook procedure. The meaning of this parameter depends on the type of hook associated with the current hook chain.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-callnexthookex#parameters 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-callnexthookex#parameters').

<a name='Windows.Win32.PInvoke.CallNextHookEx(System.Runtime.InteropServices.SafeHandle,int,Windows.Win32.Foundation.WPARAM,Windows.Win32.Foundation.LPARAM).lParam'></a>

`lParam` [Windows.Win32.Foundation.LPARAM](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Foundation.LPARAM 'Windows.Win32.Foundation.LPARAM')

  
Type: <b>LPARAM</b> The <i>lParam</i> value passed to the current hook procedure. The meaning of this parameter depends on the type of hook associated with the current hook chain.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-callnexthookex#parameters 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-callnexthookex#parameters').

#### Returns
[Windows.Win32.Foundation.LRESULT](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Foundation.LRESULT 'Windows.Win32.Foundation.LRESULT')  
  
Type: <b>LRESULT</b> This value is returned by the next hook procedure in the chain. The current hook procedure must also return this value. The meaning of the return value depends on the hook type. For more information, see the descriptions of the individual hook procedures.

### Remarks
  
Hook procedures are installed in chains for particular hook types. <b>CallNextHookEx</b> calls the next hook in the chain. Calling <b>CallNextHookEx</b> is optional, but it is highly recommended; otherwise, other applications that have installed hooks will not receive hook notifications and may behave incorrectly as a result. You should call <b>CallNextHookEx</b> unless you absolutely need to prevent the notification from being seen by other applications.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-callnexthookex# 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-callnexthookex#').