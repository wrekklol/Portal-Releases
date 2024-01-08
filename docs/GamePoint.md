#### [Portal](index.md 'index')
### [Portal](Portal.md 'Portal')

## GamePoint Struct

Represents a point/position/location in the game.

```csharp
public struct GamePoint
```

| Constructors | |
| :--- | :--- |
| [GamePoint(double, double)](GamePoint.GamePoint(double,double).md 'Portal.GamePoint.GamePoint(double, double)') | Creates a new [GamePoint](GamePoint.md 'Portal.GamePoint') with the specified percentage values. |
| [GamePoint(double)](GamePoint.GamePoint(double).md 'Portal.GamePoint.GamePoint(double)') | Creates a new [GamePoint](GamePoint.md 'Portal.GamePoint') with the specified absolute values. |
| [GamePoint(Point)](GamePoint.GamePoint(Point).md 'Portal.GamePoint.GamePoint(OpenCvSharp.Point)') | Creates a new [GamePoint](GamePoint.md 'Portal.GamePoint') by converting the specified [OpenCvSharp.Point](https://docs.microsoft.com/en-us/dotnet/api/OpenCvSharp.Point 'OpenCvSharp.Point') to game coordinates. |
| [GamePoint(Point)](GamePoint.GamePoint(Point).md 'Portal.GamePoint.GamePoint(Portal.Point)') | Creates a new [GamePoint](GamePoint.md 'Portal.GamePoint') by converting the specified [Point](Point.md 'Portal.Point') to game coordinates. |
| [GamePoint(Point)](GamePoint.GamePoint(Point).md 'Portal.GamePoint.GamePoint(System.Drawing.Point)') | Creates a new [GamePoint](GamePoint.md 'Portal.GamePoint') by converting the specified [System.Drawing.Point](https://docs.microsoft.com/en-us/dotnet/api/System.Drawing.Point 'System.Drawing.Point') to game coordinates. |
| [GamePoint(POINT)](GamePoint.GamePoint(POINT).md 'Portal.GamePoint.GamePoint(Windows.Win32.Foundation.POINT)') | Creates a new [GamePoint](GamePoint.md 'Portal.GamePoint') by converting the specified [Windows.Win32.Foundation.POINT](https://docs.microsoft.com/en-us/dotnet/api/Windows.Win32.Foundation.POINT 'Windows.Win32.Foundation.POINT') to game coordinates. |

| Properties | |
| :--- | :--- |
| [Left](GamePoint.Left.md 'Portal.GamePoint.Left') | Left in game coordinates. |
| [LeftGlobal](GamePoint.LeftGlobal.md 'Portal.GamePoint.LeftGlobal') | Left in screen coordinates. |
| [LeftPercent](GamePoint.LeftPercent.md 'Portal.GamePoint.LeftPercent') | Left percent. |
| [Top](GamePoint.Top.md 'Portal.GamePoint.Top') | Top in game coordinates. |
| [TopGlobal](GamePoint.TopGlobal.md 'Portal.GamePoint.TopGlobal') | Top in screen coordinates. |
| [TopPercent](GamePoint.TopPercent.md 'Portal.GamePoint.TopPercent') | Top percent. |
| [X](GamePoint.X.md 'Portal.GamePoint.X') | X coordinate. |
| [XGlobal](GamePoint.XGlobal.md 'Portal.GamePoint.XGlobal') | X in screen coordinates. |
| [Y](GamePoint.Y.md 'Portal.GamePoint.Y') | Y coordinate. |
| [YGlobal](GamePoint.YGlobal.md 'Portal.GamePoint.YGlobal') | Y in screen coordinates. |

| Methods | |
| :--- | :--- |
| [Click(Nullable&lt;InputData&gt;, Nullable&lt;InputOptions&gt;, Nullable&lt;MouseMoveOptions&gt;)](GamePoint.Click(Nullable_InputData_,Nullable_InputOptions_,Nullable_MouseMoveOptions_).md 'Portal.GamePoint.Click(System.Nullable<Portal.Input.InputData>, System.Nullable<Portal.Input.InputOptions>, System.Nullable<Portal.Input.MouseMoveOptions>)') | Moves the mouse to this point, and clicks. |
| [Draw(int, Nullable&lt;Color4&gt;)](GamePoint.Draw(int,Nullable_Color4_).md 'Portal.GamePoint.Draw(int, System.Nullable<Vortice.Mathematics.Color4>)') | Draws the point on the screen. |
| [Inflate(double, double)](GamePoint.Inflate(double,double).md 'Portal.GamePoint.Inflate(double, double)') | Inflates the point by the specified values. |
| [InflateRelative(int, int)](GamePoint.InflateRelative(int,int).md 'Portal.GamePoint.InflateRelative(int, int)') | Inflates the point by the specified values. |
| [MakeFromCoords(int, int)](GamePoint.MakeFromCoords(int,int).md 'Portal.GamePoint.MakeFromCoords(int, int)') | Converts the specified screen coordinates to game coordinates. |
| [MakeFromRelativeCoords(int, int)](GamePoint.MakeFromRelativeCoords(int,int).md 'Portal.GamePoint.MakeFromRelativeCoords(int, int)') | Converts the specified relative screen coordinates to game coordinates. |
| [Move(Nullable&lt;MouseMoveOptions&gt;)](GamePoint.Move(Nullable_MouseMoveOptions_).md 'Portal.GamePoint.Move(System.Nullable<Portal.Input.MouseMoveOptions>)') | Moves the mouse to this point. |
| [Offset(double, double)](GamePoint.Offset(double,double).md 'Portal.GamePoint.Offset(double, double)') | Offsets the point by the specified values. |
| [OffsetRelative(int, int)](GamePoint.OffsetRelative(int,int).md 'Portal.GamePoint.OffsetRelative(int, int)') | Offsets the point by the specified values. |
