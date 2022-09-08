#### [Portal](index.md 'index')
### [Portal.Utility](Portal.Utility.md 'Portal.Utility').[ScriptHelpers](ScriptHelpers.md 'Portal.Utility.ScriptHelpers')

## ScriptHelpers.Draw(UIElement, int, string) Method

Draws a new element to the screen.

```csharp
public static void Draw(System.Windows.UIElement InElement, int InDuration=-1, string InID="Default");
```
#### Parameters

<a name='Portal.Utility.ScriptHelpers.Draw(System.Windows.UIElement,int,string).InElement'></a>

`InElement` [System.Windows.UIElement](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.UIElement 'System.Windows.UIElement')

Element to draw.

<a name='Portal.Utility.ScriptHelpers.Draw(System.Windows.UIElement,int,string).InDuration'></a>

`InDuration` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Duration in milliseconds until the drawing gets erased. If you want the drawing to last forever, set this to Timeout.Infinite.

<a name='Portal.Utility.ScriptHelpers.Draw(System.Windows.UIElement,int,string).InID'></a>

`InID` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

ID of the drawing.