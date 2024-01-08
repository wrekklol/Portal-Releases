#### [Portal](index.md 'index')
### [Windows.Win32](Windows.Win32.md 'Windows.Win32').[PInvoke](PInvoke.md 'Windows.Win32.PInvoke')

## PInvoke.GetMessageExtraInfo() Method

Retrieves the extra message information for the current thread. Extra message information is an application- or driver-defined value associated with the current thread's message queue.

```csharp
internal static Windows.Win32.Foundation.LPARAM GetMessageExtraInfo();
```

#### Returns
[Windows.Win32.Foundation.LPARAM](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Foundation.LPARAM 'Windows.Win32.Foundation.LPARAM')  
  
Type: <b>LPARAM</b> The return value specifies the extra information. The meaning of the extra information is device specific.

### Remarks
To set a thread's extra message information, use the <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-setmessageextrainfo">SetMessageExtraInfo</a> function.