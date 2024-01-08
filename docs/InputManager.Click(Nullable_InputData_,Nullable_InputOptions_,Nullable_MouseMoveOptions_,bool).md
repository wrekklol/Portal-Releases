#### [Portal](index.md 'index')
### [Portal.Input](Portal.Input.md 'Portal.Input').[InputManager](InputManager.md 'Portal.Input.InputManager')

## InputManager.Click(Nullable<InputData>, Nullable<InputOptions>, Nullable<MouseMoveOptions>, bool) Method

Sends down and up input, with optional movement options.

```csharp
public static void Click(System.Nullable<Portal.Input.InputData> InInput=null, System.Nullable<Portal.Input.InputOptions> InOptions=null, System.Nullable<Portal.Input.MouseMoveOptions> InMouseMoveOptions=null, bool InbShouldPrint=true);
```
#### Parameters

<a name='Portal.Input.InputManager.Click(System.Nullable_Portal.Input.InputData_,System.Nullable_Portal.Input.InputOptions_,System.Nullable_Portal.Input.MouseMoveOptions_,bool).InInput'></a>

`InInput` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[InputData](InputData.md 'Portal.Input.InputData')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

Input to send.

<a name='Portal.Input.InputManager.Click(System.Nullable_Portal.Input.InputData_,System.Nullable_Portal.Input.InputOptions_,System.Nullable_Portal.Input.MouseMoveOptions_,bool).InOptions'></a>

`InOptions` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[InputOptions](InputOptions.md 'Portal.Input.InputOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

Input options to send with.

<a name='Portal.Input.InputManager.Click(System.Nullable_Portal.Input.InputData_,System.Nullable_Portal.Input.InputOptions_,System.Nullable_Portal.Input.MouseMoveOptions_,bool).InMouseMoveOptions'></a>

`InMouseMoveOptions` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[MouseMoveOptions](MouseMoveOptions.md 'Portal.Input.MouseMoveOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

Mouse move options to send with.

<a name='Portal.Input.InputManager.Click(System.Nullable_Portal.Input.InputData_,System.Nullable_Portal.Input.InputOptions_,System.Nullable_Portal.Input.MouseMoveOptions_,bool).InbShouldPrint'></a>

`InbShouldPrint` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Wheter to print.

### Remarks
If movement is specified, [OnMoveEnd](MouseMoveOptions.OnMoveEnd.md 'Portal.Input.MouseMoveOptions.OnMoveEnd') is overridden to send input when move ends.