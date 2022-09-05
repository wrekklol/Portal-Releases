#### [Portal](index.md 'index')
### [Portal.Input](Portal.Input.md 'Portal.Input').[Input](Input.md 'Portal.Input.Input')

## Input.CursorMove(GamePoint, double, double, double, double, GamePoint) Method

Moves the mouse cursor from one point to another with human like movement.

```csharp
public static void CursorMove(Portal.GamePoint InDestination, double InSpeed, double InGravity, double InWind, double InTargetArea, Portal.GamePoint InDestRange);
```
#### Parameters

<a name='Portal.Input.Input.CursorMove(Portal.GamePoint,double,double,double,double,Portal.GamePoint).InDestination'></a>

`InDestination` [GamePoint](GamePoint.md 'Portal.GamePoint')

Move destination.

<a name='Portal.Input.Input.CursorMove(Portal.GamePoint,double,double,double,double,Portal.GamePoint).InSpeed'></a>

`InSpeed` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

Speed of the movement.

<a name='Portal.Input.Input.CursorMove(Portal.GamePoint,double,double,double,double,Portal.GamePoint).InGravity'></a>

`InGravity` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

Strength pulling the position towards the destination.

<a name='Portal.Input.Input.CursorMove(Portal.GamePoint,double,double,double,double,Portal.GamePoint).InWind'></a>

`InWind` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

Strength pulling the position in random directions.

<a name='Portal.Input.Input.CursorMove(Portal.GamePoint,double,double,double,double,Portal.GamePoint).InTargetArea'></a>

`InTargetArea` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

Radius of area around the destination that should trigger slowing, prevents spiraling.

<a name='Portal.Input.Input.CursorMove(Portal.GamePoint,double,double,double,double,Portal.GamePoint).InDestRange'></a>

`InDestRange` [GamePoint](GamePoint.md 'Portal.GamePoint')

Random destination offset.