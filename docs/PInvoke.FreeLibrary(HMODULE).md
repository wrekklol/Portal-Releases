#### [Portal](index.md 'index')
### [Windows.Win32](Windows.Win32.md 'Windows.Win32').[PInvoke](PInvoke.md 'Windows.Win32.PInvoke')

## PInvoke.FreeLibrary(HMODULE) Method

Frees the loaded dynamic-link library (DLL) module and, if necessary, decrements its reference count.

```csharp
internal static Windows.Win32.Foundation.BOOL FreeLibrary(Windows.Win32.Foundation.HMODULE hLibModule);
```
#### Parameters

<a name='Windows.Win32.PInvoke.FreeLibrary(Windows.Win32.Foundation.HMODULE).hLibModule'></a>

`hLibModule` [Windows.Win32.Foundation.HMODULE](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Foundation.HMODULE 'Windows.Win32.Foundation.HMODULE')

  
A handle to the loaded library module. The <a href="https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-loadlibrarya">LoadLibrary</a>, <a href="https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-loadlibraryexa">LoadLibraryEx</a>, <a href="https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-getmodulehandlea">GetModuleHandle</a>, or <a href="https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-getmodulehandleexa">GetModuleHandleEx</a> function returns this handle.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-freelibrary#parameters 'https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-freelibrary#parameters').

#### Returns
[Windows.Win32.Foundation.BOOL](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Foundation.BOOL 'Windows.Win32.Foundation.BOOL')  
  
If the function succeeds, the return value is nonzero. If the function fails, the return value is zero. To get extended error information, call the <a href="https://docs.microsoft.com/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a> function.

### Remarks
  
The system maintains a per-process reference count for each loaded module. A  module that was loaded at process initialization due to load-time dynamic linking has a reference count of one. The reference count for a module is incremented each time the  module is loaded by a call to <a href="https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-loadlibrarya">LoadLibrary</a>. The reference count is also incremented by a call to <a href="https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-loadlibraryexa">LoadLibraryEx</a> unless the  module  is being loaded for the first time and is being loaded as   a data or image file. The reference count is decremented each time the <b>FreeLibrary</b> or <a href="https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-freelibraryandexitthread">FreeLibraryAndExitThread</a> function is called for the module. When a  module's reference count reaches zero or the process terminates, the system unloads the module from the address space of the  process. Before unloading a library module, the system enables the module to detach from the process by calling the module's <a href="https://docs.microsoft.com/windows/desktop/Dlls/dllmain">DllMain</a> function, if it has one, with the DLL_PROCESS_DETACH value. Doing so gives the library module an opportunity to clean up resources allocated on behalf of the current process. After the entry-point function returns, the library module is removed from the address space of the current process. It is not safe to call <b>FreeLibrary</b> from <a href="https://docs.microsoft.com/windows/desktop/Dlls/dllmain">DllMain</a>. For more information, see the Remarks section in <a href="https://docs.microsoft.com/windows/desktop/Dlls/dllmain">DllMain</a>. Calling <b>FreeLibrary</b> does not affect other processes that are using the same module. Use caution when calling <b>FreeLibrary</b> with a handle returned by <a href="https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-getmodulehandlea">GetModuleHandle</a>. The <b>GetModuleHandle</b> function does not increment a module's reference count, so passing this handle to <b>FreeLibrary</b> can cause a module to be unloaded prematurely. A thread that must unload the DLL in which it is executing and then terminate itself should call <a href="https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-freelibraryandexitthread">FreeLibraryAndExitThread</a> instead of calling <b>FreeLibrary</b> and <b>ExitThread</b> separately. Otherwise, a race condition can occur. For details, see the Remarks section of <a href="https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-freelibraryandexitthread">FreeLibraryAndExitThread</a>.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-freelibrary# 'https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-freelibrary#').