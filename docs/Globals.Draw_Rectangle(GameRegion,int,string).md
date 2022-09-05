#### [Portal](index.md 'index')
### [Portal](Portal.md 'Portal').[Globals](Globals.md 'Portal.Globals')

## Globals.Draw_Rectangle(GameRegion, int, string) Method

Helper function to draw a rectangle on the screen. <br/> See [Draw(UIElement, int, string)](Globals.Draw(UIElement,int,string).md 'Portal.Globals.Draw(System.Windows.UIElement, int, string)') for more information.

```csharp
public static void Draw_Rectangle(Portal.GameRegion InRegion, int InDuration=-1, string InID="Default");
```
#### Parameters

<a name='Portal.Globals.Draw_Rectangle(Portal.GameRegion,int,string).InRegion'></a>

`InRegion` [GameRegion](GameRegion.md 'Portal.GameRegion')

Rectangle to draw.

<a name='Portal.Globals.Draw_Rectangle(Portal.GameRegion,int,string).InDuration'></a>

`InDuration` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

How long the rectangle will be drawn for, if Timeout.Infinite is specified, it will stay drawn until [Erase()](Globals.Erase().md 'Portal.Globals.Erase()') is called.

<a name='Portal.Globals.Draw_Rectangle(Portal.GameRegion,int,string).InID'></a>

`InID` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

ID of the drawing.