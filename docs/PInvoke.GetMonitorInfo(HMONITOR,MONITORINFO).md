#### [Portal](index.md 'index')
### [Windows.Win32](Windows.Win32.md 'Windows.Win32').[PInvoke](PInvoke.md 'Windows.Win32.PInvoke')

## PInvoke.GetMonitorInfo(HMONITOR, MONITORINFO) Method

The GetMonitorInfo function retrieves information about a display monitor. (Unicode)

```csharp
internal static Windows.Win32.Foundation.BOOL GetMonitorInfo(Windows.Win32.Graphics.Gdi.HMONITOR hMonitor, ref Windows.Win32.Graphics.Gdi.MONITORINFO lpmi);
```
#### Parameters

<a name='Windows.Win32.PInvoke.GetMonitorInfo(Windows.Win32.Graphics.Gdi.HMONITOR,Windows.Win32.Graphics.Gdi.MONITORINFO).hMonitor'></a>

`hMonitor` [Windows.Win32.Graphics.Gdi.HMONITOR](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Graphics.Gdi.HMONITOR 'Windows.Win32.Graphics.Gdi.HMONITOR')

A handle to the display monitor of interest.

<a name='Windows.Win32.PInvoke.GetMonitorInfo(Windows.Win32.Graphics.Gdi.HMONITOR,Windows.Win32.Graphics.Gdi.MONITORINFO).lpmi'></a>

`lpmi` [MONITORINFO](MONITORINFO.md 'Windows.Win32.Graphics.Gdi.MONITORINFO')

  
A pointer to a <a href="https://docs.microsoft.com/windows/desktop/api/winuser/ns-winuser-monitorinfo">MONITORINFO</a> or <a href="https://docs.microsoft.com/windows/desktop/api/winuser/ns-winuser-monitorinfoexa">MONITORINFOEX</a> structure that receives information about the specified display monitor. You must set the <b>cbSize</b> member of the structure to sizeof(MONITORINFO) or sizeof(MONITORINFOEX) before calling the <b>GetMonitorInfo</b> function. Doing so lets the function determine the type of structure you are passing to it. The <a href="https://docs.microsoft.com/windows/desktop/api/winuser/ns-winuser-monitorinfoexa">MONITORINFOEX</a> structure is a superset of the <a href="https://docs.microsoft.com/windows/desktop/api/winuser/ns-winuser-monitorinfo">MONITORINFO</a> structure. It has one additional member: a string that contains a name for the display monitor. Most applications have no use for a display monitor name, and so can save some bytes by using a <b>MONITORINFO</b> structure.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getmonitorinfow#parameters 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getmonitorinfow#parameters').

#### Returns
[Windows.Win32.Foundation.BOOL](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Foundation.BOOL 'Windows.Win32.Foundation.BOOL')  
  
If the function succeeds, the return value is nonzero. If the function fails, the return value is zero.

### Remarks
  
> [!NOTE] > The winuser.h header defines GetMonitorInfo as an alias which automatically selects the ANSI or Unicode version of this function based on the definition of the UNICODE preprocessor constant. Mixing usage of the encoding-neutral alias with code that not encoding-neutral can lead to mismatches that result in compilation or runtime errors. For more information, see [Conventions for Function Prototypes](/windows/win32/intl/conventions-for-function-prototypes).  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getmonitorinfow# 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getmonitorinfow#').