#### [Portal](index.md 'index')
### [Portal.Utility](Portal.Utility.md 'Portal.Utility').[ScriptHelpers](ScriptHelpers.md 'Portal.Utility.ScriptHelpers')

## ScriptHelpers.Draw_Text(string, GameRegion, Color, string, int, int, string) Method

Helper function to draw text on the screen. <br/> See [Draw(UIElement, int, string)](ScriptHelpers.Draw(UIElement,int,string).md 'Portal.Utility.ScriptHelpers.Draw(System.Windows.UIElement, int, string)') for more information.

```csharp
public static void Draw_Text(string InText, Portal.GameRegion InRegion, System.Drawing.Color InColor, string InFont, int InFontSize, int InDuration=-1, string InID="Default");
```
#### Parameters

<a name='Portal.Utility.ScriptHelpers.Draw_Text(string,Portal.GameRegion,System.Drawing.Color,string,int,int,string).InText'></a>

`InText` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Text to draw.

<a name='Portal.Utility.ScriptHelpers.Draw_Text(string,Portal.GameRegion,System.Drawing.Color,string,int,int,string).InRegion'></a>

`InRegion` [GameRegion](GameRegion.md 'Portal.GameRegion')

Region to draw text.

<a name='Portal.Utility.ScriptHelpers.Draw_Text(string,Portal.GameRegion,System.Drawing.Color,string,int,int,string).InColor'></a>

`InColor` [System.Drawing.Color](https://docs.microsoft.com/en-us/dotnet/api/System.Drawing.Color 'System.Drawing.Color')

Color of the text.

<a name='Portal.Utility.ScriptHelpers.Draw_Text(string,Portal.GameRegion,System.Drawing.Color,string,int,int,string).InFont'></a>

`InFont` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Font of the text.

<a name='Portal.Utility.ScriptHelpers.Draw_Text(string,Portal.GameRegion,System.Drawing.Color,string,int,int,string).InFontSize'></a>

`InFontSize` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Font size of the text.

<a name='Portal.Utility.ScriptHelpers.Draw_Text(string,Portal.GameRegion,System.Drawing.Color,string,int,int,string).InDuration'></a>

`InDuration` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

How long the rectangle will be drawn for, if Timeout.Infinite is specified, it will stay drawn until [Erase()](ScriptHelpers.Erase().md 'Portal.Utility.ScriptHelpers.Erase()') is called.

<a name='Portal.Utility.ScriptHelpers.Draw_Text(string,Portal.GameRegion,System.Drawing.Color,string,int,int,string).InID'></a>

`InID` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

ID of the drawing.