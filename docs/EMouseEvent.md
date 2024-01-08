#### [Portal](index.md 'index')
### [Portal.Input](Portal.Input.md 'Portal.Input')

## EMouseEvent Enum

Mouse events

```csharp
public enum EMouseEvent : System.UInt32
```
### Fields

<a name='Portal.Input.EMouseEvent.Absolute'></a>

`Absolute` 32768

The dx and dy parameters contain normalized absolute coordinates. If not set,  
those parameters contain relative data: the change in position since the last  
reported position. This flag can be set, or not set, regardless of what kind  
of mouse or mouse-like device, if any, is connected to the system. For further  
information about relative mouse motion, see the following Remarks section.

<a name='Portal.Input.EMouseEvent.HWheel'></a>

`HWheel` 4096

The wheel button is tilted.

<a name='Portal.Input.EMouseEvent.LeftDown'></a>

`LeftDown` 2

Left button down.

<a name='Portal.Input.EMouseEvent.LeftUp'></a>

`LeftUp` 4

Left button up.

<a name='Portal.Input.EMouseEvent.MiddleDown'></a>

`MiddleDown` 32

Middle button down.

<a name='Portal.Input.EMouseEvent.MiddleUp'></a>

`MiddleUp` 64

Middle button up.

<a name='Portal.Input.EMouseEvent.Move'></a>

`Move` 1

Movement occurred.

<a name='Portal.Input.EMouseEvent.RightDown'></a>

`RightDown` 8

Right button down.

<a name='Portal.Input.EMouseEvent.RightUp'></a>

`RightUp` 16

Right button up.

<a name='Portal.Input.EMouseEvent.Wheel'></a>

`Wheel` 2048

The wheel has been moved, if the mouse has a wheel. The amount of movement is specified in dwData

<a name='Portal.Input.EMouseEvent.XDown'></a>

`XDown` 128

X button down.

<a name='Portal.Input.EMouseEvent.XUp'></a>

`XUp` 256

X button up.