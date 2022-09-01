#### [Portal](index.md 'index')
### [Portal.Input](Portal.Input.md 'Portal.Input').[Input](Portal.Input.Input.md 'Portal.Input.Input')

## Input.CursorMove_Async(GamePoint, double, double, double, double, Action) Method

Moves the mouse cursor from one point to another with human like movement.

```csharp
public static System.Threading.Tasks.Task CursorMove_Async(Portal.GamePoint InDestination, double InSpeed, double InGravity, double InWind, double InTargetArea, System.Action? OnMoveEnd=null);
```
#### Parameters

<a name='Portal.Input.Input.CursorMove_Async(Portal.GamePoint,double,double,double,double,System.Action).InDestination'></a>

`InDestination` [Portal.GamePoint](https://docs.microsoft.com/en-us/dotnet/api/Portal.GamePoint 'Portal.GamePoint')

Move destination.

<a name='Portal.Input.Input.CursorMove_Async(Portal.GamePoint,double,double,double,double,System.Action).InSpeed'></a>

`InSpeed` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

Speed of the movement.

<a name='Portal.Input.Input.CursorMove_Async(Portal.GamePoint,double,double,double,double,System.Action).InGravity'></a>

`InGravity` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

Strength pulling the position towards the destination.

<a name='Portal.Input.Input.CursorMove_Async(Portal.GamePoint,double,double,double,double,System.Action).InWind'></a>

`InWind` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

Strength pulling the position in random directions.

<a name='Portal.Input.Input.CursorMove_Async(Portal.GamePoint,double,double,double,double,System.Action).InTargetArea'></a>

`InTargetArea` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

Radius of area around the destination that should trigger slowing, prevents spiraling.

<a name='Portal.Input.Input.CursorMove_Async(Portal.GamePoint,double,double,double,double,System.Action).OnMoveEnd'></a>

`OnMoveEnd` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Action to be performed when the cursor reaches the destination.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')