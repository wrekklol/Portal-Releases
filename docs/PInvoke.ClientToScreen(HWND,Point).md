#### [Portal](index.md 'index')
### [Windows.Win32](Windows.Win32.md 'Windows.Win32').[PInvoke](PInvoke.md 'Windows.Win32.PInvoke')

## PInvoke.ClientToScreen(HWND, Point) Method

The ClientToScreen function converts the client-area coordinates of a specified point to screen coordinates.

```csharp
internal static Windows.Win32.Foundation.BOOL ClientToScreen(Windows.Win32.Foundation.HWND hWnd, ref System.Drawing.Point lpPoint);
```
#### Parameters

<a name='Windows.Win32.PInvoke.ClientToScreen(Windows.Win32.Foundation.HWND,System.Drawing.Point).hWnd'></a>

`hWnd` [Windows.Win32.Foundation.HWND](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Foundation.HWND 'Windows.Win32.Foundation.HWND')

A handle to the window whose client area is used for the conversion.

<a name='Windows.Win32.PInvoke.ClientToScreen(Windows.Win32.Foundation.HWND,System.Drawing.Point).lpPoint'></a>

`lpPoint` [System.Drawing.Point](https://docs.microsoft.com/en-us/dotnet/api/System.Drawing.Point 'System.Drawing.Point')

A pointer to a <a href="https://docs.microsoft.com/windows/win32/api/windef/ns-windef-point">POINT</a> structure that contains the client coordinates to be converted. The new screen coordinates are copied into this structure if the function succeeds.

#### Returns
[Windows.Win32.Foundation.BOOL](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Foundation.BOOL 'Windows.Win32.Foundation.BOOL')  
  
If the function succeeds, the return value is nonzero. If the function fails, the return value is zero.

### Remarks
  
The <b>ClientToScreen</b> function replaces the client-area coordinates in the <a href="https://docs.microsoft.com/windows/win32/api/windef/ns-windef-point">POINT</a> structure with the screen coordinates. The screen coordinates are relative to the upper-left corner of the screen. Note, a screen-coordinate point that is above the window's client area has a negative y-coordinate. Similarly, a screen coordinate to the left of a client area has a negative x-coordinate. All coordinates are device coordinates.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-clienttoscreen# 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-clienttoscreen#').