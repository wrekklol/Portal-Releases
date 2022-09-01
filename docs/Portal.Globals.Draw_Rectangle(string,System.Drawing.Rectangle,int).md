#### [Portal](index.md 'index')
### [Portal](Portal.md 'Portal').[Globals](Portal.Globals.md 'Portal.Globals')

## Globals.Draw_Rectangle(string, Rectangle, int) Method

Helper function to draw a rectangle on the screen. <br/> See [Draw(string, Action&lt;Graphics&gt;, int)](Portal.Globals.Draw(string,System.Action_System.Drawing.Graphics_,int).md 'Portal.Globals.Draw(string, System.Action<System.Drawing.Graphics>, int)') for more information.

```csharp
public static void Draw_Rectangle(string InID, System.Drawing.Rectangle InRect, int InDuration=-1);
```
#### Parameters

<a name='Portal.Globals.Draw_Rectangle(string,System.Drawing.Rectangle,int).InID'></a>

`InID` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

ID of the drawing.

<a name='Portal.Globals.Draw_Rectangle(string,System.Drawing.Rectangle,int).InRect'></a>

`InRect` [System.Drawing.Rectangle](https://docs.microsoft.com/en-us/dotnet/api/System.Drawing.Rectangle 'System.Drawing.Rectangle')

Rectangle to draw.

<a name='Portal.Globals.Draw_Rectangle(string,System.Drawing.Rectangle,int).InDuration'></a>

`InDuration` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

How long the rectangle will be drawn for, if Timeout.Infinite is specified, it will stay drawn until [Erase()](Portal.Globals.Erase().md 'Portal.Globals.Erase()') is called.