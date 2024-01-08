#### [Portal](index.md 'index')
### [Windows.Win32](Windows.Win32.md 'Windows.Win32').[PInvoke](PInvoke.md 'Windows.Win32.PInvoke')

## PInvoke.MonitorFromWindow(HWND, MONITOR_FROM_FLAGS) Method

The MonitorFromWindow function retrieves a handle to the display monitor that has the largest area of intersection with the bounding rectangle of a specified window.

```csharp
internal static Windows.Win32.Graphics.Gdi.HMONITOR MonitorFromWindow(Windows.Win32.Foundation.HWND hwnd, Windows.Win32.Graphics.Gdi.MONITOR_FROM_FLAGS dwFlags);
```
#### Parameters

<a name='Windows.Win32.PInvoke.MonitorFromWindow(Windows.Win32.Foundation.HWND,Windows.Win32.Graphics.Gdi.MONITOR_FROM_FLAGS).hwnd'></a>

`hwnd` [Windows.Win32.Foundation.HWND](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Foundation.HWND 'Windows.Win32.Foundation.HWND')

A handle to the window of interest.

<a name='Windows.Win32.PInvoke.MonitorFromWindow(Windows.Win32.Foundation.HWND,Windows.Win32.Graphics.Gdi.MONITOR_FROM_FLAGS).dwFlags'></a>

`dwFlags` [Windows.Win32.Graphics.Gdi.MONITOR_FROM_FLAGS](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Graphics.Gdi.MONITOR_FROM_FLAGS 'Windows.Win32.Graphics.Gdi.MONITOR_FROM_FLAGS')

Determines the function's return value if the window does not intersect any display monitor.

#### Returns
[Windows.Win32.Graphics.Gdi.HMONITOR](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Graphics.Gdi.HMONITOR 'Windows.Win32.Graphics.Gdi.HMONITOR')  
  
If the window intersects one or more display monitor rectangles, the return value is an <b>HMONITOR</b> handle to the display monitor that has the largest area of intersection with the window. If the window does not intersect a display monitor, the return value depends on the value of <i>dwFlags</i>.

### Remarks
If the window is currently minimized, <b>MonitorFromWindow</b> uses the rectangle of the window before it was minimized.