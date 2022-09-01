#### [Portal](index.md 'index')
### [Portal](Portal.md 'Portal').[Globals](Portal.Globals.md 'Portal.Globals')

## Globals.Draw(string, Action<Graphics>, int) Method

Draws a new element to the screen.

```csharp
public static void Draw(string InID, System.Action<System.Drawing.Graphics> InElement, int InDuration=-1);
```
#### Parameters

<a name='Portal.Globals.Draw(string,System.Action_System.Drawing.Graphics_,int).InID'></a>

`InID` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

ID of the drawing.

<a name='Portal.Globals.Draw(string,System.Action_System.Drawing.Graphics_,int).InElement'></a>

`InElement` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Drawing.Graphics](https://docs.microsoft.com/en-us/dotnet/api/System.Drawing.Graphics 'System.Drawing.Graphics')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Element to draw.

<a name='Portal.Globals.Draw(string,System.Action_System.Drawing.Graphics_,int).InDuration'></a>

`InDuration` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Duration in milliseconds until the drawing gets erased. If you want the drawing to last forever, set this to Timeout.Infinite.