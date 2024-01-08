#### [Portal](index.md 'index')
### [Portal.Input](Portal.Input.md 'Portal.Input')

## InputManager Class

Input manager, responsible for sending input, and handling keybinds.

```csharp
public class InputManager : Portal.Singleton<Portal.Input.InputManager>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Portal.Singleton&lt;](https://docs.microsoft.com/en-us/dotnet/api/Portal.Singleton-1 'Portal.Singleton`1')[InputManager](InputManager.md 'Portal.Input.InputManager')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Portal.Singleton-1 'Portal.Singleton`1') &#129106; InputManager

| Properties | |
| :--- | :--- |
| [BindableFunctions](InputManager.BindableFunctions.md 'Portal.Input.InputManager.BindableFunctions') | Bindable functions. |
| [bIsMovingMouse](InputManager.bIsMovingMouse.md 'Portal.Input.InputManager.bIsMovingMouse') | True if mouse is moving. |
| [Keybinds](InputManager.Keybinds.md 'Portal.Input.InputManager.Keybinds') | Keybinds. |
| [MousePosition](InputManager.MousePosition.md 'Portal.Input.InputManager.MousePosition') | Mouse position in game coordinates. |
| [MousePositionGlobal](InputManager.MousePositionGlobal.md 'Portal.Input.InputManager.MousePositionGlobal') | Mouse position in global coordinates. |
| [PressedKeys](InputManager.PressedKeys.md 'Portal.Input.InputManager.PressedKeys') | Currently pressed keys. |
| [PressedModifierKeys](InputManager.PressedModifierKeys.md 'Portal.Input.InputManager.PressedModifierKeys') | Currently pressed modifier keys. |
| [TicksSinceLastMouseMove](InputManager.TicksSinceLastMouseMove.md 'Portal.Input.InputManager.TicksSinceLastMouseMove') | Ticks since last mouse move. |

| Methods | |
| :--- | :--- |
| [BindKey(EKey, Action, bool, bool)](InputManager.BindKey(EKey,Action,bool,bool).md 'Portal.Input.InputManager.BindKey(Portal.Input.EKey, System.Action, bool, bool)') | Binds a key to an action. |
| [BindKey(EKey, Action, bool)](InputManager.BindKey(EKey,Action,bool).md 'Portal.Input.InputManager.BindKey(Portal.Input.EKey, System.Action, bool)') | Binds a key to an action. |
| [BindKey(EKey, Action, EKeyModifier, bool)](InputManager.BindKey(EKey,Action,EKeyModifier,bool).md 'Portal.Input.InputManager.BindKey(Portal.Input.EKey, System.Action, Portal.Input.EKeyModifier, bool)') | Binds a key to an action. |
| [BindKey(EKey, Action, EKeyModifier)](InputManager.BindKey(EKey,Action,EKeyModifier).md 'Portal.Input.InputManager.BindKey(Portal.Input.EKey, System.Action, Portal.Input.EKeyModifier)') | Binds a key to an action. |
| [BindKey(EKey, Action, EKeyState, bool, bool)](InputManager.BindKey(EKey,Action,EKeyState,bool,bool).md 'Portal.Input.InputManager.BindKey(Portal.Input.EKey, System.Action, Portal.Input.EKeyState, bool, bool)') | Binds a key to an action. |
| [BindKey(EKey, Action, EKeyState, bool)](InputManager.BindKey(EKey,Action,EKeyState,bool).md 'Portal.Input.InputManager.BindKey(Portal.Input.EKey, System.Action, Portal.Input.EKeyState, bool)') | Binds a key to an action. |
| [BindKey(EKey, Action, EKeyState, EKeyModifier, bool, bool)](InputManager.BindKey(EKey,Action,EKeyState,EKeyModifier,bool,bool).md 'Portal.Input.InputManager.BindKey(Portal.Input.EKey, System.Action, Portal.Input.EKeyState, Portal.Input.EKeyModifier, bool, bool)') | Binds a key to an action. |
| [BindKey(EKey, Action, EKeyState, EKeyModifier)](InputManager.BindKey(EKey,Action,EKeyState,EKeyModifier).md 'Portal.Input.InputManager.BindKey(Portal.Input.EKey, System.Action, Portal.Input.EKeyState, Portal.Input.EKeyModifier)') | Binds a key to an action. |
| [BindKey(EKey, Action, EKeyState)](InputManager.BindKey(EKey,Action,EKeyState).md 'Portal.Input.InputManager.BindKey(Portal.Input.EKey, System.Action, Portal.Input.EKeyState)') | Binds a key to an action. |
| [BindKey(EKey, Action)](InputManager.BindKey(EKey,Action).md 'Portal.Input.InputManager.BindKey(Portal.Input.EKey, System.Action)') | Binds a key to an action. |
| [BindKey(InputBinding)](InputManager.BindKey(InputBinding).md 'Portal.Input.InputManager.BindKey(Portal.Input.InputBinding)') | Binds a key to an action. |
| [ClearState()](InputManager.ClearState().md 'Portal.Input.InputManager.ClearState()') | Clears the current state of the input manager. |
| [Click(double, double, Nullable&lt;InputData&gt;, Nullable&lt;InputOptions&gt;, Nullable&lt;MouseMoveOptions&gt;, bool)](InputManager.Click(double,double,Nullable_InputData_,Nullable_InputOptions_,Nullable_MouseMoveOptions_,bool).md 'Portal.Input.InputManager.Click(double, double, System.Nullable<Portal.Input.InputData>, System.Nullable<Portal.Input.InputOptions>, System.Nullable<Portal.Input.MouseMoveOptions>, bool)') | Moves mouse to specified coordinates, and clicks. |
| [Click(Nullable&lt;InputData&gt;, Nullable&lt;InputOptions&gt;, Nullable&lt;MouseMoveOptions&gt;, bool)](InputManager.Click(Nullable_InputData_,Nullable_InputOptions_,Nullable_MouseMoveOptions_,bool).md 'Portal.Input.InputManager.Click(System.Nullable<Portal.Input.InputData>, System.Nullable<Portal.Input.InputOptions>, System.Nullable<Portal.Input.MouseMoveOptions>, bool)') | Sends down and up input, with optional movement options. |
| [IsCurrentMoveID(Nullable&lt;Guid&gt;)](InputManager.IsCurrentMoveID(Nullable_Guid_).md 'Portal.Input.InputManager.IsCurrentMoveID(System.Nullable<System.Guid>)') | Determines if the current mouse move is the specified ID. |
| [IsExtendedKey(EKey)](InputManager.IsExtendedKey(EKey).md 'Portal.Input.InputManager.IsExtendedKey(Portal.Input.EKey)') | Determines if the [EKey](EKey.md 'Portal.Input.EKey') is an ExtendedKey |
| [IsKeyPressed(EKey)](InputManager.IsKeyPressed(EKey).md 'Portal.Input.InputManager.IsKeyPressed(Portal.Input.EKey)') | Checks if the specified key is pressed. |
| [IsModifiersPressed(EKeyModifier, bool)](InputManager.IsModifiersPressed(EKeyModifier,bool).md 'Portal.Input.InputManager.IsModifiersPressed(Portal.Input.EKeyModifier, bool)') | Checks if the specified key modifiers are pressed. |
| [MouseMove_Async(MouseMoveOptions, bool)](InputManager.MouseMove_Async(MouseMoveOptions,bool).md 'Portal.Input.InputManager.MouseMove_Async(Portal.Input.MouseMoveOptions, bool)') | Moves the mouse from one point to another with human like movement or instant, asynchronously. |
| [MouseMove(double, double, Nullable&lt;MouseMoveOptions&gt;, bool)](InputManager.MouseMove(double,double,Nullable_MouseMoveOptions_,bool).md 'Portal.Input.InputManager.MouseMove(double, double, System.Nullable<Portal.Input.MouseMoveOptions>, bool)') | Moves the mouse from one point to another with human like movement or instant, synchronously. |
| [MouseMove(MouseMoveOptions, bool)](InputManager.MouseMove(MouseMoveOptions,bool).md 'Portal.Input.InputManager.MouseMove(Portal.Input.MouseMoveOptions, bool)') | Moves the mouse from one point to another with human like movement or instant, synchronously. |
| [MouseMoveMulti_Async(List&lt;GamePoint&gt;, Nullable&lt;MouseMoveOptions&gt;, bool)](InputManager.MouseMoveMulti_Async(List_GamePoint_,Nullable_MouseMoveOptions_,bool).md 'Portal.Input.InputManager.MouseMoveMulti_Async(System.Collections.Generic.List<Portal.GamePoint>, System.Nullable<Portal.Input.MouseMoveOptions>, bool)') | Moves the mouse through a list of points with human like movement or instant, asynchronously. |
| [MouseMoveMulti(List&lt;GamePoint&gt;, Nullable&lt;MouseMoveOptions&gt;, bool)](InputManager.MouseMoveMulti(List_GamePoint_,Nullable_MouseMoveOptions_,bool).md 'Portal.Input.InputManager.MouseMoveMulti(System.Collections.Generic.List<Portal.GamePoint>, System.Nullable<Portal.Input.MouseMoveOptions>, bool)') | Moves the mouse through a list of points with human like movement or instant, synchronously. |
| [SendInput_Async(InputData, Nullable&lt;InputOptions&gt;, Action, bool)](InputManager.SendInput_Async(InputData,Nullable_InputOptions_,Action,bool).md 'Portal.Input.InputManager.SendInput_Async(Portal.Input.InputData, System.Nullable<Portal.Input.InputOptions>, System.Action, bool)') | Sends input to the system, asynchronously. |
| [SendInput_Async(List&lt;InputData&gt;, Nullable&lt;InputOptions&gt;, Action, bool)](InputManager.SendInput_Async(List_InputData_,Nullable_InputOptions_,Action,bool).md 'Portal.Input.InputManager.SendInput_Async(System.Collections.Generic.List<Portal.Input.InputData>, System.Nullable<Portal.Input.InputOptions>, System.Action, bool)') | Sends input to the system, asynchronously. |
| [SendInput(InputData, Nullable&lt;InputOptions&gt;, bool)](InputManager.SendInput(InputData,Nullable_InputOptions_,bool).md 'Portal.Input.InputManager.SendInput(Portal.Input.InputData, System.Nullable<Portal.Input.InputOptions>, bool)') | Sends input to the system, synchronously. |
| [SendInput(List&lt;InputData&gt;, Nullable&lt;InputOptions&gt;, bool)](InputManager.SendInput(List_InputData_,Nullable_InputOptions_,bool).md 'Portal.Input.InputManager.SendInput(System.Collections.Generic.List<Portal.Input.InputData>, System.Nullable<Portal.Input.InputOptions>, bool)') | Sends input to the system, synchronously. |
| [StopMouseMove()](InputManager.StopMouseMove().md 'Portal.Input.InputManager.StopMouseMove()') | Stops the current mouse move. |
