#### [Portal](index.md 'index')
### [Windows.Win32.Graphics.Gdi](Windows.Win32.Graphics.Gdi.md 'Windows.Win32.Graphics.Gdi').[MONITORINFO](MONITORINFO.md 'Windows.Win32.Graphics.Gdi.MONITORINFO')

## MONITORINFO.cbSize Field

  
The size of the structure, in bytes. Set this member to `sizeof ( MONITORINFO )` before calling the <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-getmonitorinfoa">GetMonitorInfo</a> function. Doing so lets the function determine the type of structure you are passing to it.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-monitorinfo#members 'https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-monitorinfo#members').

```csharp
internal uint cbSize;
```

#### Field Value
[System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')