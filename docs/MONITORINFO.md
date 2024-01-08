#### [Portal](index.md 'index')
### [Windows.Win32.Graphics.Gdi](Windows.Win32.Graphics.Gdi.md 'Windows.Win32.Graphics.Gdi')

## MONITORINFO Struct

The MONITORINFO structure contains information about a display monitor.The GetMonitorInfo function stores information in a MONITORINFO structure or a MONITORINFOEX structure.The MONITORINFO structure is a subset of the MONITORINFOEX structure.

```csharp
internal struct MONITORINFO
```

### Remarks
  
[Learn more about this API from docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-monitorinfo 'https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-monitorinfo').

| Fields | |
| :--- | :--- |
| [cbSize](MONITORINFO.cbSize.md 'Windows.Win32.Graphics.Gdi.MONITORINFO.cbSize') | <br/><br/>The size of the structure, in bytes. Set this member to `sizeof ( MONITORINFO )` before calling the <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-getmonitorinfoa">GetMonitorInfo</a> function. Doing so lets the function determine the type of structure you are passing to it.<br/><br/>[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-monitorinfo#members 'https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-monitorinfo#members'). |
| [dwFlags](MONITORINFO.dwFlags.md 'Windows.Win32.Graphics.Gdi.MONITORINFO.dwFlags') | <br/><br/>A set of flags that represent attributes of the display monitor. The following flag is defined.<br/><br/>This doc was truncated.<br/><br/>[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-monitorinfo#members 'https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-monitorinfo#members'). |
| [rcMonitor](MONITORINFO.rcMonitor.md 'Windows.Win32.Graphics.Gdi.MONITORINFO.rcMonitor') | A <a href="https://docs.microsoft.com/windows/desktop/api/windef/ns-windef-rect">RECT</a> structure that specifies the display monitor rectangle, expressed in virtual-screen coordinates. Note that if the monitor is not the primary display monitor, some of the rectangle's coordinates may be negative values. |
| [rcWork](MONITORINFO.rcWork.md 'Windows.Win32.Graphics.Gdi.MONITORINFO.rcWork') | A <a href="https://docs.microsoft.com/windows/desktop/api/windef/ns-windef-rect">RECT</a> structure that specifies the work area rectangle of the display monitor, expressed in virtual-screen coordinates. Note that if the monitor is not the primary display monitor, some of the rectangle's coordinates may be negative values. |
