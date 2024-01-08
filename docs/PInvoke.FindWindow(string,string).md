#### [Portal](index.md 'index')
### [Windows.Win32](Windows.Win32.md 'Windows.Win32').[PInvoke](PInvoke.md 'Windows.Win32.PInvoke')

## PInvoke.FindWindow(string, string) Method

Retrieves a handle to the top-level window whose class name and window name match the specified strings. This function does not search child windows. This function does not perform a case-sensitive search. (Unicode)

```csharp
internal static Windows.Win32.Foundation.HWND FindWindow(string lpClassName, string lpWindowName);
```
#### Parameters

<a name='Windows.Win32.PInvoke.FindWindow(string,string).lpClassName'></a>

`lpClassName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

  
Type: <b>LPCTSTR</b> The class name or a class atom created by a previous call to the <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-registerclassa">RegisterClass</a> or <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-registerclassexa">RegisterClassEx</a> function. The atom must be in the low-order word of <i>lpClassName</i>; the high-order word must be zero. If <i>lpClassName</i> points to a string, it specifies the window class name. The class name can be any name registered with <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-registerclassa">RegisterClass</a> or <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-registerclassexa">RegisterClassEx</a>, or any of the predefined control-class names. If <i>lpClassName</i> is <b>NULL</b>, it finds any window whose title matches the <i>lpWindowName</i> parameter.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-findwindoww#parameters 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-findwindoww#parameters').

<a name='Windows.Win32.PInvoke.FindWindow(string,string).lpWindowName'></a>

`lpWindowName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

  
Type: <b>LPCTSTR</b> The window name (the window's title). If this parameter is <b>NULL</b>, all window names match.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-findwindoww#parameters 'https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-findwindoww#parameters').

#### Returns
[Windows.Win32.Foundation.HWND](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Foundation.HWND 'Windows.Win32.Foundation.HWND')  
  
Type: <b>HWND</b> If the function succeeds, the return value is a handle to the window that has the specified class name and window name. If the function fails, the return value is <b>NULL</b>. To get extended error information, call <a href="https://docs.microsoft.com/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a>.

### Remarks
If the <i>lpWindowName</i> parameter is not <b>NULL</b>, <b>FindWindow</b> calls the <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-getwindowtexta">GetWindowText</a> function to retrieve the window name for comparison. For a description of a potential problem that can arise, see the Remarks for <b>GetWindowText</b>.