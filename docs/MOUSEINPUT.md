#### [Portal](index.md 'index')
### [Windows.Win32.UI.Input.KeyboardAndMouse](Windows.Win32.UI.Input.KeyboardAndMouse.md 'Windows.Win32.UI.Input.KeyboardAndMouse')

## MOUSEINPUT Struct

Contains information about a simulated mouse event.

```csharp
internal struct MOUSEINPUT
```

### Remarks
  
If the mouse has moved, indicated by **MOUSEEVENTF_MOVE**, **dx** and **dy** specify information about that movement. The information is specified as absolute or relative integer values. If **MOUSEEVENTF_ABSOLUTE** value is specified, **dx** and **dy** contain normalized absolute coordinates between 0 and 65,535. The event procedure maps these coordinates onto the display surface. Coordinate (0,0) maps onto the upper-left corner of the display surface; coordinate (65535,65535) maps onto the lower-right corner. In a multimonitor system, the coordinates map to the primary monitor. If **MOUSEEVENTF_VIRTUALDESK** is specified, the coordinates map to the entire virtual desktop. If the **MOUSEEVENTF_ABSOLUTE** value is not specified, **dx**and **dy** specify movement relative to the previous mouse event (the last reported position). Positive values mean the mouse moved right (or down); negative values mean the mouse moved left (or up). Relative mouse motion is subject to the effects of the mouse speed and the two-mouse threshold values. A user sets these three values with the **Pointer Speed** slider of the Control Panel's **Mouse Properties** sheet. You can obtain and set these values using the [SystemParametersInfo](/windows/desktop/api/winuser/nf-winuser-systemparametersinfoa) function. The system applies two tests to the specified relative mouse movement. If the specified distance along either the x or y axis is greater than the first mouse threshold value, and the mouse speed is not zero, the system doubles the distance. If the specified distance along either the x or y axis is greater than the second mouse threshold value, and the mouse speed is equal to two, the system doubles the distance that resulted from applying the first threshold test. It is thus possible for the system to multiply specified relative mouse movement along the x or y axis by up to four times.  
  
[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-mouseinput# 'https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-mouseinput#').

| Fields | |
| :--- | :--- |
| [dwExtraInfo](MOUSEINPUT.dwExtraInfo.md 'Windows.Win32.UI.Input.KeyboardAndMouse.MOUSEINPUT.dwExtraInfo') | <br/><br/>Type: **ULONG_PTR** An additional value associated with the mouse event. An application calls [GetMessageExtraInfo](/windows/desktop/api/winuser/nf-winuser-getmessageextrainfo) to obtain this extra information.<br/><br/>[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-mouseinput#members 'https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-mouseinput#members'). |
| [dwFlags](MOUSEINPUT.dwFlags.md 'Windows.Win32.UI.Input.KeyboardAndMouse.MOUSEINPUT.dwFlags') | Type: **DWORD** |
| [dx](MOUSEINPUT.dx.md 'Windows.Win32.UI.Input.KeyboardAndMouse.MOUSEINPUT.dx') | <br/><br/>Type: **LONG** The absolute position of the mouse, or the amount of motion since the last mouse event was generated, depending on the value of the **dwFlags** member. Absolute data is specified as the x coordinate of the mouse; relative data is specified as the number of pixels moved.<br/><br/>[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-mouseinput#members 'https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-mouseinput#members'). |
| [dy](MOUSEINPUT.dy.md 'Windows.Win32.UI.Input.KeyboardAndMouse.MOUSEINPUT.dy') | <br/><br/>Type: **LONG** The absolute position of the mouse, or the amount of motion since the last mouse event was generated, depending on the value of the **dwFlags** member. Absolute data is specified as the y coordinate of the mouse; relative data is specified as the number of pixels moved.<br/><br/>[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-mouseinput#members 'https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-mouseinput#members'). |
| [time](MOUSEINPUT.time.md 'Windows.Win32.UI.Input.KeyboardAndMouse.MOUSEINPUT.time') | <br/><br/>Type: **DWORD** The time stamp for the event, in milliseconds. If this parameter is 0, the system will provide its own time stamp.<br/><br/>[Read more on docs.microsoft.com](https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-mouseinput#members 'https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-mouseinput#members'). |
