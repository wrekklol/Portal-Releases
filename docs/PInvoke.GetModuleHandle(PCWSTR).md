#### [Portal](index.md 'index')
### [Windows.Win32](Windows.Win32.md 'Windows.Win32').[PInvoke](PInvoke.md 'Windows.Win32.PInvoke')

## PInvoke.GetModuleHandle(PCWSTR) Method

Retrieves a module handle for the specified module. The module must have been loaded by the calling process. (Unicode)

```csharp
internal static Windows.Win32.Foundation.HMODULE GetModuleHandle(Windows.Win32.Foundation.PCWSTR lpModuleName);
```
#### Parameters

<a name='Windows.Win32.PInvoke.GetModuleHandle(Windows.Win32.Foundation.PCWSTR).lpModuleName'></a>

`lpModuleName` [PCWSTR](PCWSTR.md 'Windows.Win32.Foundation.PCWSTR')

  
The name of the loaded module (either a .dll or .exe file). If the file name extension is omitted, the default library extension .dll is appended. The file name string can include a trailing point character (.) to indicate that the module name has no extension. The string does not have to specify a path. When specifying a path, be sure to use backslashes (\\), not forward slashes (/). The name is compared (case independently) to the names of modules currently mapped into the address space of the calling process.  
  
If this parameter is NULL, <b>GetModuleHandle</b> returns a handle to the file used to create the calling process (.exe file). The <b>GetModuleHandle</b> function does not retrieve handles for modules that were loaded using the <b>LOAD_LIBRARY_AS_DATAFILE</b> flag. For more information, see <a href="https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-loadlibraryexa">LoadLibraryEx</a>.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-getmodulehandlew#parameters 'https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-getmodulehandlew#parameters').

#### Returns
[Windows.Win32.Foundation.HMODULE](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Foundation.HMODULE 'Windows.Win32.Foundation.HMODULE')  
  
If the function succeeds, the return value is a handle to the specified module. If the function fails, the return value is NULL. To get extended error information, call <a href="https://docs.microsoft.com/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a>.

### Remarks
  
The returned handle is not global or inheritable. It cannot be duplicated or used by another process. If <i>lpModuleName</i> does not include a path and there is more than one loaded module with the same base name and extension, you cannot predict which module handle will be returned. To work around this problem, you could specify a path, use <a href="https://docs.microsoft.com/windows/desktop/Msi/side-by-side-assemblies">side-by-side assemblies</a>, or use <a href="https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-getmodulehandleexa">GetModuleHandleEx</a> to specify a memory location rather than a DLL name. The <b>GetModuleHandle</b> function returns a handle to a mapped module without incrementing its reference count. However, if this handle is passed to the <a href="https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-freelibrary">FreeLibrary</a> function, the reference count of the mapped module will be decremented. Therefore, do not pass a handle returned by <b>GetModuleHandle</b> to the <b>FreeLibrary</b> function. Doing so can cause a DLL module to be unmapped prematurely. This function must be used carefully in a multithreaded application. There is no guarantee that the module handle remains valid between the time this function returns the handle and the time it is used. For example, suppose that a thread retrieves a module handle, but before it uses the handle, a second thread frees the module. If the system loads another module, it could reuse the module handle that was recently freed. Therefore, the first thread would have a handle to a different module  than the one intended.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-getmodulehandlew# 'https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-getmodulehandlew#').