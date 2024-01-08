#### [Portal](index.md 'index')
### [Portal.Input](Portal.Input.md 'Portal.Input').[InputManager](InputManager.md 'Portal.Input.InputManager')

## InputManager.MouseMoveMulti(List<GamePoint>, Nullable<MouseMoveOptions>, bool) Method

Moves the mouse through a list of points with human like movement or instant, synchronously.

```csharp
public static void MouseMoveMulti(System.Collections.Generic.List<Portal.GamePoint> InPoints, System.Nullable<Portal.Input.MouseMoveOptions> InMouseMoveOptions=null, bool InbShouldPrint=true);
```
#### Parameters

<a name='Portal.Input.InputManager.MouseMoveMulti(System.Collections.Generic.List_Portal.GamePoint_,System.Nullable_Portal.Input.MouseMoveOptions_,bool).InPoints'></a>

`InPoints` [System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[GamePoint](GamePoint.md 'Portal.GamePoint')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

List of points to move through.

<a name='Portal.Input.InputManager.MouseMoveMulti(System.Collections.Generic.List_Portal.GamePoint_,System.Nullable_Portal.Input.MouseMoveOptions_,bool).InMouseMoveOptions'></a>

`InMouseMoveOptions` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[MouseMoveOptions](MouseMoveOptions.md 'Portal.Input.MouseMoveOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

Mouse move options to send with.

<a name='Portal.Input.InputManager.MouseMoveMulti(System.Collections.Generic.List_Portal.GamePoint_,System.Nullable_Portal.Input.MouseMoveOptions_,bool).InbShouldPrint'></a>

`InbShouldPrint` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Wheter to print.

### Remarks
[InMouseMoveOptions](https://docs.microsoft.com/en-us/dotnet/api/InMouseMoveOptions 'InMouseMoveOptions')' [Destination](MouseMoveOptions.Destination.md 'Portal.Input.MouseMoveOptions.Destination') will be overridden for each point.