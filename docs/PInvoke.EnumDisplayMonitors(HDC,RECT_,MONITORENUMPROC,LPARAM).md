#### [Portal](index.md 'index')
### [Windows.Win32](Windows.Win32.md 'Windows.Win32').[PInvoke](PInvoke.md 'Windows.Win32.PInvoke')

## PInvoke.EnumDisplayMonitors(HDC, RECT*, MONITORENUMPROC, LPARAM) Method

The EnumDisplayMonitors function enumerates display monitors (including invisible pseudo-monitors associated with the mirroring drivers) that intersect a region formed by the intersection of a specified clipping rectangle and the visible region of a device context. EnumDisplayMonitors calls an application-defined MonitorEnumProc callback function once for each monitor that is enumerated. Note that GetSystemMetrics (SM_CMONITORS) counts only the display monitors.

```csharp
internal static Windows.Win32.Foundation.BOOL EnumDisplayMonitors(Windows.Win32.Graphics.Gdi.HDC hdc, Windows.Win32.Foundation.RECT* lprcClip, Windows.Win32.Graphics.Gdi.MONITORENUMPROC lpfnEnum, Windows.Win32.Foundation.LPARAM dwData);
```
#### Parameters

<a name='Windows.Win32.PInvoke.EnumDisplayMonitors(Windows.Win32.Graphics.Gdi.HDC,Windows.Win32.Foundation.RECT_,Windows.Win32.Graphics.Gdi.MONITORENUMPROC,Windows.Win32.Foundation.LPARAM).hdc'></a>

`hdc` [Windows.Win32.Graphics.Gdi.HDC](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Graphics.Gdi.HDC 'Windows.Win32.Graphics.Gdi.HDC')

  
A handle to a display device context that defines the visible region of interest. If this parameter is <b>NULL</b>, the <i>hdcMonitor</i> parameter passed to the callback function will be <b>NULL</b>, and the visible region of interest is the virtual screen that encompasses all the displays on the desktop.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-enumdisplaymonitors#parameters 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-enumdisplaymonitors#parameters').

<a name='Windows.Win32.PInvoke.EnumDisplayMonitors(Windows.Win32.Graphics.Gdi.HDC,Windows.Win32.Foundation.RECT_,Windows.Win32.Graphics.Gdi.MONITORENUMPROC,Windows.Win32.Foundation.LPARAM).lprcClip'></a>

`lprcClip` [Windows.Win32.Foundation.RECT](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Foundation.RECT 'Windows.Win32.Foundation.RECT')*

  
A pointer to a <a href="https://docs.microsoft.com/windows/desktop/api/windef/ns-windef-rect">RECT</a> structure that specifies a clipping rectangle. The region of interest is the intersection of the clipping rectangle with the visible region specified by <i>hdc</i>. If <i>hdc</i> is non-<b>NULL</b>, the coordinates of the clipping rectangle are relative to the origin of the <i>hdc</i>. If <i>hdc</i> is <b>NULL</b>, the coordinates are virtual-screen coordinates. This parameter can be <b>NULL</b> if you don't want to clip the region specified by <i>hdc</i>.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-enumdisplaymonitors#parameters 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-enumdisplaymonitors#parameters').

<a name='Windows.Win32.PInvoke.EnumDisplayMonitors(Windows.Win32.Graphics.Gdi.HDC,Windows.Win32.Foundation.RECT_,Windows.Win32.Graphics.Gdi.MONITORENUMPROC,Windows.Win32.Foundation.LPARAM).lpfnEnum'></a>

`lpfnEnum` [Windows.Win32.Graphics.Gdi.MONITORENUMPROC](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Graphics.Gdi.MONITORENUMPROC 'Windows.Win32.Graphics.Gdi.MONITORENUMPROC')

A pointer to a <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nc-winuser-monitorenumproc">MonitorEnumProc</a> application-defined callback function.

<a name='Windows.Win32.PInvoke.EnumDisplayMonitors(Windows.Win32.Graphics.Gdi.HDC,Windows.Win32.Foundation.RECT_,Windows.Win32.Graphics.Gdi.MONITORENUMPROC,Windows.Win32.Foundation.LPARAM).dwData'></a>

`dwData` [Windows.Win32.Foundation.LPARAM](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Foundation.LPARAM 'Windows.Win32.Foundation.LPARAM')

Application-defined data that <b>EnumDisplayMonitors</b> passes directly to the <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nc-winuser-monitorenumproc">MonitorEnumProc</a> function.

#### Returns
[Windows.Win32.Foundation.BOOL](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Foundation.BOOL 'Windows.Win32.Foundation.BOOL')  
  
If the function succeeds, the return value is nonzero. If the function fails, the return value is zero.

### Remarks
  
There are two reasons to call the <b>EnumDisplayMonitors</b> function:  
  
This doc was truncated.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-enumdisplaymonitors# 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-enumdisplaymonitors#').