#### [Portal](index.md 'index')
### [Portal.Input](Portal.Input.md 'Portal.Input').[Input](Input.md 'Portal.Input.Input')

## Input.CursorMove_Async(GamePoint, Action) Method

Moves the mouse cursor from one point to another with human like movement.

```csharp
public static System.Threading.Tasks.Task CursorMove_Async(Portal.GamePoint InDestination, System.Action? OnMoveEnd=null);
```
#### Parameters

<a name='Portal.Input.Input.CursorMove_Async(Portal.GamePoint,System.Action).InDestination'></a>

`InDestination` [GamePoint](GamePoint.md 'Portal.GamePoint')

Move destination.

<a name='Portal.Input.Input.CursorMove_Async(Portal.GamePoint,System.Action).OnMoveEnd'></a>

`OnMoveEnd` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Action to be performed when the cursor reaches the destination.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')