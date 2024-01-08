#### [Portal](index.md 'index')
### [Portal.Input](Portal.Input.md 'Portal.Input').[InputManager](InputManager.md 'Portal.Input.InputManager')

## InputManager.IsExtendedKey(EKey) Method

Determines if the [EKey](EKey.md 'Portal.Input.EKey') is an ExtendedKey

```csharp
public static bool IsExtendedKey(Portal.Input.EKey InKeyCode);
```
#### Parameters

<a name='Portal.Input.InputManager.IsExtendedKey(Portal.Input.EKey).InKeyCode'></a>

`InKeyCode` [EKey](EKey.md 'Portal.Input.EKey')

The key code.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if the key code is an extended key; otherwise, false.

### Remarks
The extended keys consist of the ALT and CTRL keys on the right-hand side of the keyboard;   
the INS, DEL, HOME, END, PAGE UP, PAGE DOWN, and arrow keys in the clusters   
to the left of the numeric keypad; the NUM LOCK key; the BREAK (CTRL+PAUSE) key;   
the PRINT SCRN key; and the divide (/) and ENTER keys in the numeric keypad.  
  
See http://msdn.microsoft.com/en-us/library/ms646267(v=vs.85).aspx Section "Extended-Key Flag"