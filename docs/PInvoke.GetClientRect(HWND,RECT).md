#### [Portal](index.md 'index')
### [Windows.Win32](Windows.Win32.md 'Windows.Win32').[PInvoke](PInvoke.md 'Windows.Win32.PInvoke')

## PInvoke.GetClientRect(HWND, RECT) Method

Retrieves the coordinates of a window's client area.

```csharp
internal static Windows.Win32.Foundation.BOOL GetClientRect(Windows.Win32.Foundation.HWND hWnd, out Windows.Win32.Foundation.RECT lpRect);
```
#### Parameters

<a name='Windows.Win32.PInvoke.GetClientRect(Windows.Win32.Foundation.HWND,Windows.Win32.Foundation.RECT).hWnd'></a>

`hWnd` [Windows.Win32.Foundation.HWND](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Foundation.HWND 'Windows.Win32.Foundation.HWND')

  
Type: <b>HWND</b> A handle to the window whose client coordinates are to be retrieved.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getclientrect#parameters 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getclientrect#parameters').

<a name='Windows.Win32.PInvoke.GetClientRect(Windows.Win32.Foundation.HWND,Windows.Win32.Foundation.RECT).lpRect'></a>

`lpRect` [Windows.Win32.Foundation.RECT](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Foundation.RECT 'Windows.Win32.Foundation.RECT')

  
Type: <b>LPRECT</b> A pointer to a <a href="https://docs.microsoft.com/windows/desktop/api/windef/ns-windef-rect">RECT</a> structure that receives the client coordinates. The <b>left</b> and <b>top</b> members are zero. The <b>right</b> and <b>bottom</b> members contain the width and height of the window.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getclientrect#parameters 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getclientrect#parameters').

#### Returns
[Windows.Win32.Foundation.BOOL](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Foundation.BOOL 'Windows.Win32.Foundation.BOOL')  
  
Type: <b>BOOL</b> If the function succeeds, the return value is nonzero. If the function fails, the return value is zero. To get extended error information, call <a href="https://docs.microsoft.com/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a>.

### Remarks
In conformance with conventions for the <a href="https://docs.microsoft.com/windows/desktop/api/windef/ns-windef-rect">RECT</a> structure, the bottom-right coordinates of the returned rectangle are exclusive. In other words, the pixel at (<b>right</b>, <b>bottom</b>) lies immediately outside the rectangle.