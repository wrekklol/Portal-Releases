#### [Portal](index.md 'index')
### [Portal.Input](Portal.Input.md 'Portal.Input').[InputManager](InputManager.md 'Portal.Input.InputManager')

## InputManager.MouseMove_Async(GamePoint, double, Action) Method

Moves the mouse mouse from one point to another with human like movement.

```csharp
public static System.Threading.Tasks.Task MouseMove_Async(Portal.GamePoint InDestination, double InSpeed, System.Action? OnMoveEnd=null);
```
#### Parameters

<a name='Portal.Input.InputManager.MouseMove_Async(Portal.GamePoint,double,System.Action).InDestination'></a>

`InDestination` [GamePoint](GamePoint.md 'Portal.GamePoint')

Move destination.

<a name='Portal.Input.InputManager.MouseMove_Async(Portal.GamePoint,double,System.Action).InSpeed'></a>

`InSpeed` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

Speed of the movement.

<a name='Portal.Input.InputManager.MouseMove_Async(Portal.GamePoint,double,System.Action).OnMoveEnd'></a>

`OnMoveEnd` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Action to be performed when the mouse reaches the destination.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')