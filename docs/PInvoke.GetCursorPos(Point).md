#### [Portal](index.md 'index')
### [Windows.Win32](Windows.Win32.md 'Windows.Win32').[PInvoke](PInvoke.md 'Windows.Win32.PInvoke')

## PInvoke.GetCursorPos(Point) Method

Retrieves the position of the mouse cursor, in screen coordinates.

```csharp
internal static Windows.Win32.Foundation.BOOL GetCursorPos(out System.Drawing.Point lpPoint);
```
#### Parameters

<a name='Windows.Win32.PInvoke.GetCursorPos(System.Drawing.Point).lpPoint'></a>

`lpPoint` [System.Drawing.Point](https://docs.microsoft.com/en-us/dotnet/api/System.Drawing.Point 'System.Drawing.Point')

  
Type: <b>LPPOINT</b> A pointer to a <a href="https://docs.microsoft.com/windows/win32/api/windef/ns-windef-point">POINT</a> structure that receives the screen coordinates of the cursor.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getcursorpos#parameters 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getcursorpos#parameters').

#### Returns
[Windows.Win32.Foundation.BOOL](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Foundation.BOOL 'Windows.Win32.Foundation.BOOL')  
  
Type: <b>BOOL</b> Returns nonzero if successful or zero otherwise. To get extended error information, call <a href="https://docs.microsoft.com/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a>.

### Remarks
  
The cursor position is always specified in screen coordinates and is not affected by the mapping mode of the window that contains the cursor. The calling process must have <b>WINSTA_READATTRIBUTES</b> access to the window station. The input desktop must be the current desktop when you call <b>GetCursorPos</b>. Call <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-openinputdesktop">OpenInputDesktop</a> to determine whether the current desktop is the input desktop. If it is not, call <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-setthreaddesktop">SetThreadDesktop</a> with the <b>HDESK</b> returned by <b>OpenInputDesktop</b> to switch to that desktop.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getcursorpos# 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-getcursorpos#').