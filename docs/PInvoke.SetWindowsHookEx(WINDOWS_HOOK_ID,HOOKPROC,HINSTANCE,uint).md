#### [Portal](index.md 'index')
### [Windows.Win32](Windows.Win32.md 'Windows.Win32').[PInvoke](PInvoke.md 'Windows.Win32.PInvoke')

## PInvoke.SetWindowsHookEx(WINDOWS_HOOK_ID, HOOKPROC, HINSTANCE, uint) Method

Installs an application-defined hook procedure into a hook chain. (Unicode)

```csharp
internal static Windows.Win32.UI.WindowsAndMessaging.HHOOK SetWindowsHookEx(Windows.Win32.UI.WindowsAndMessaging.WINDOWS_HOOK_ID idHook, Windows.Win32.UI.WindowsAndMessaging.HOOKPROC lpfn, Windows.Win32.Foundation.HINSTANCE hmod, uint dwThreadId);
```
#### Parameters

<a name='Windows.Win32.PInvoke.SetWindowsHookEx(Windows.Win32.UI.WindowsAndMessaging.WINDOWS_HOOK_ID,Windows.Win32.UI.WindowsAndMessaging.HOOKPROC,Windows.Win32.Foundation.HINSTANCE,uint).idHook'></a>

`idHook` [Windows.Win32.UI.WindowsAndMessaging.WINDOWS_HOOK_ID](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.UI.WindowsAndMessaging.WINDOWS_HOOK_ID 'Windows.Win32.UI.WindowsAndMessaging.WINDOWS_HOOK_ID')

Type: <b>int</b>

<a name='Windows.Win32.PInvoke.SetWindowsHookEx(Windows.Win32.UI.WindowsAndMessaging.WINDOWS_HOOK_ID,Windows.Win32.UI.WindowsAndMessaging.HOOKPROC,Windows.Win32.Foundation.HINSTANCE,uint).lpfn'></a>

`lpfn` [Windows.Win32.UI.WindowsAndMessaging.HOOKPROC](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.UI.WindowsAndMessaging.HOOKPROC 'Windows.Win32.UI.WindowsAndMessaging.HOOKPROC')

  
Type: <b>HOOKPROC</b> A pointer to the hook procedure. If the <i>dwThreadId</i> parameter is zero or specifies the identifier of a thread created by a different process, the <i>lpfn</i> parameter must point to a hook procedure in a DLL. Otherwise, <i>lpfn</i> can point to a hook procedure in the code associated with the current process.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setwindowshookexw#parameters 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setwindowshookexw#parameters').

<a name='Windows.Win32.PInvoke.SetWindowsHookEx(Windows.Win32.UI.WindowsAndMessaging.WINDOWS_HOOK_ID,Windows.Win32.UI.WindowsAndMessaging.HOOKPROC,Windows.Win32.Foundation.HINSTANCE,uint).hmod'></a>

`hmod` [Windows.Win32.Foundation.HINSTANCE](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Foundation.HINSTANCE 'Windows.Win32.Foundation.HINSTANCE')

  
Type: <b>HINSTANCE</b> A handle to the DLL containing the hook procedure pointed to by the <i>lpfn</i> parameter. The <i>hMod</i> parameter must be set to <b>NULL</b> if the <i>dwThreadId</i> parameter specifies a thread created by the current process and if the hook procedure is within the code associated with the current process.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setwindowshookexw#parameters 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setwindowshookexw#parameters').

<a name='Windows.Win32.PInvoke.SetWindowsHookEx(Windows.Win32.UI.WindowsAndMessaging.WINDOWS_HOOK_ID,Windows.Win32.UI.WindowsAndMessaging.HOOKPROC,Windows.Win32.Foundation.HINSTANCE,uint).dwThreadId'></a>

`dwThreadId` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

  
Type: <b>DWORD</b> The identifier of the thread with which the hook procedure is to be associated. For desktop apps, if this parameter is zero, the hook procedure is associated with all existing threads running in the same desktop as the calling thread. For Windows Store apps, see the Remarks section.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setwindowshookexw#parameters 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setwindowshookexw#parameters').

#### Returns
[Windows.Win32.UI.WindowsAndMessaging.HHOOK](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.UI.WindowsAndMessaging.HHOOK 'Windows.Win32.UI.WindowsAndMessaging.HHOOK')  
  
Type: <b>HHOOK</b> If the function succeeds, the return value is the handle to the hook procedure. If the function fails, the return value is <b>NULL</b>. To get extended error information, call <a href="https://docs.microsoft.com/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a>.

### Remarks
  
<b>SetWindowsHookEx</b> can be used to inject a DLL into another process. A 32-bit DLL cannot be injected into a 64-bit process, and a 64-bit DLL cannot be injected into a 32-bit process. If an application requires the use of hooks in other processes, it is required that a 32-bit application call <b>SetWindowsHookEx</b> to inject a 32-bit DLL into 32-bit processes, and a 64-bit application call <b>SetWindowsHookEx</b> to inject a 64-bit DLL into 64-bit processes. The 32-bit and 64-bit DLLs must have different names.  
  
Because hooks run in the context of an application, they must match the "bitness" of the application. If a 32-bit application installs a global hook on 64-bit Windows, the 32-bit hook is injected into each 32-bit process (the usual security boundaries apply). In a 64-bit process, the threads are still marked as "hooked." However, because a 32-bit application must run the hook code, the system executes the hook in the hooking app's context; specifically, on the thread that called <b>SetWindowsHookEx</b>. This means that the hooking application must continue to pump messages or it might block the normal functioning of the 64-bit processes.  
  
If a 64-bit application installs a global hook on 64-bit Windows, the 64-bit hook is injected into each 64-bit process, while all 32-bit processes use a callback to the hooking application.  
  
To hook all applications on the desktop of a 64-bit Windows installation, install a 32-bit global hook and a 64-bit global hook, each from appropriate processes, and be sure to keep pumping messages in the hooking application to avoid blocking normal functioning. If you already have a 32-bit global hooking application and it doesn't need to run in each application's context, you may not need to create a 64-bit version.  
  
An error may occur if the <i>hMod</i> parameter is <b>NULL</b> and the <i>dwThreadId</i> parameter is zero or specifies the identifier of a thread created by another process. Calling the <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-callnexthookex">CallNextHookEx</a> function to chain to the next hook procedure is optional, but it is highly recommended; otherwise, other applications that have installed hooks will not receive hook notifications and may behave incorrectly as a result. You should call <b>CallNextHookEx</b> unless you absolutely need to prevent the notification from being seen by other applications. Before terminating, an application must call the <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-unhookwindowshookex">UnhookWindowsHookEx</a> function to free system resources associated with the hook. The scope of a hook depends on the hook type. Some hooks can be set only with global scope; others can also be set for only a specific thread, as shown in the following table.  
  
This doc was truncated.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setwindowshookexw# 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-setwindowshookexw#').