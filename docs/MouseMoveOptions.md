#### [Portal](index.md 'index')
### [Portal.Input](Portal.Input.md 'Portal.Input')

## MouseMoveOptions Struct

Mouse move options.

```csharp
public struct MouseMoveOptions
```

| Properties | |
| :--- | :--- |
| [bForceMove](MouseMoveOptions.bForceMove.md 'Portal.Input.MouseMoveOptions.bForceMove') | Moves even when script is stopped. |
| [Destination](MouseMoveOptions.Destination.md 'Portal.Input.MouseMoveOptions.Destination') | Destination to move mouse to. |
| [DestRange](MouseMoveOptions.DestRange.md 'Portal.Input.MouseMoveOptions.DestRange') | Random destination offset. |
| [Gravity](MouseMoveOptions.Gravity.md 'Portal.Input.MouseMoveOptions.Gravity') | Strength pulling the mouse towards the destination. |
| [MoveType](MouseMoveOptions.MoveType.md 'Portal.Input.MouseMoveOptions.MoveType') | If false, use human-like mouse movement. |
| [OnMoveEnd](MouseMoveOptions.OnMoveEnd.md 'Portal.Input.MouseMoveOptions.OnMoveEnd') | Action to be performed when the mouse reaches the destination. |
| [Speed](MouseMoveOptions.Speed.md 'Portal.Input.MouseMoveOptions.Speed') | Speed to move mouse with. |
| [TargetArea](MouseMoveOptions.TargetArea.md 'Portal.Input.MouseMoveOptions.TargetArea') | Radius of area around the destination that should trigger slowing, prevents spiraling. |
| [Wind](MouseMoveOptions.Wind.md 'Portal.Input.MouseMoveOptions.Wind') | Strength pulling the mouse in random directions. |

| Operators | |
| :--- | :--- |
| [implicit operator MouseMoveOptions(GamePoint)](MouseMoveOptions.implicitoperatorMouseMoveOptions(GamePoint).md 'Portal.Input.MouseMoveOptions.op_Implicit Portal.Input.MouseMoveOptions(Portal.GamePoint)') | Cast operator. <br/> Allows you to cast [GamePoint](GamePoint.md 'Portal.GamePoint') to mouse move options. |
