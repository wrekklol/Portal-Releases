#### [Portal](index.md 'index')
### [Portal.Input](Portal.Input.md 'Portal.Input').[Input](Portal.Input.Input.md 'Portal.Input.Input')

## Input.CursorMove(GamePoint, double, double, double, double) Method

Moves the mouse cursor from one point to another with human like movement.

```csharp
public static void CursorMove(Portal.GamePoint InDestination, double InSpeed, double InGravity, double InWind, double InTargetArea);
```
#### Parameters

<a name='Portal.Input.Input.CursorMove(Portal.GamePoint,double,double,double,double).InDestination'></a>

`InDestination` [Portal.GamePoint](https://docs.microsoft.com/en-us/dotnet/api/Portal.GamePoint 'Portal.GamePoint')

Move destination.

<a name='Portal.Input.Input.CursorMove(Portal.GamePoint,double,double,double,double).InSpeed'></a>

`InSpeed` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

Speed of the movement.

<a name='Portal.Input.Input.CursorMove(Portal.GamePoint,double,double,double,double).InGravity'></a>

`InGravity` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

Strength pulling the position towards the destination.

<a name='Portal.Input.Input.CursorMove(Portal.GamePoint,double,double,double,double).InWind'></a>

`InWind` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

Strength pulling the position in random directions.

<a name='Portal.Input.Input.CursorMove(Portal.GamePoint,double,double,double,double).InTargetArea'></a>

`InTargetArea` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

Radius of area around the destination that should trigger slowing, prevents spiraling.