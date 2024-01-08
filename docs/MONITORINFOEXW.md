#### [Portal](index.md 'index')
### [Windows.Win32.Graphics.Gdi](Windows.Win32.Graphics.Gdi.md 'Windows.Win32.Graphics.Gdi')

## MONITORINFOEXW Struct

The MONITORINFOEX structure contains information about a display monitor.The GetMonitorInfo function stores information into a MONITORINFOEX structure or a MONITORINFO structure.The MONITORINFOEX structure is a superset of the MONITORINFO structure. (Unicode)

```csharp
internal struct MONITORINFOEXW
```

### Remarks
  
> [!NOTE] > The winuser.h header defines MONITORINFOEX as an alias which automatically selects the ANSI or Unicode version of this function based on the definition of the UNICODE preprocessor constant. Mixing usage of the encoding-neutral alias with code that not encoding-neutral can lead to mismatches that result in compilation or runtime errors. For more information, see [Conventions for Function Prototypes](/windows/win32/intl/conventions-for-function-prototypes).  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-monitorinfoexw# 'https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-monitorinfoexw#').

| Fields | |
| :--- | :--- |
| [szDevice](MONITORINFOEXW.szDevice.md 'Windows.Win32.Graphics.Gdi.MONITORINFOEXW.szDevice') | A string that specifies the device name of the monitor being used.  Most applications have no use for a display monitor name, and so can save some bytes by using a <a href="https://docs.microsoft.com/windows/desktop/api/winuser/ns-winuser-monitorinfo">MONITORINFO</a> structure. |
