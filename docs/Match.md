#### [Portal](index.md 'index')
### [Portal.Detect](Portal.Detect.md 'Portal.Detect')

## Match Class

Result(s) of image detection is stored as a Match.

```csharp
public class Match :
System.IDisposable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Match

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')

| Constructors | |
| :--- | :--- |
| [Match(string, GameRegion, double, Mat)](Match.Match(string,GameRegion,double,Mat).md 'Portal.Detect.Match.Match(string, Portal.GameRegion, double, OpenCvSharp.Mat)') | Match constructor. |

| Properties | |
| :--- | :--- |
| [Confidence](Match.Confidence.md 'Portal.Detect.Match.Confidence') | Confidence of match. |
| [Frame](Match.Frame.md 'Portal.Detect.Match.Frame') | If [bWantsFrameCaptured](SearchOptions.bWantsFrameCaptured.md 'Portal.Detect.SearchOptions.bWantsFrameCaptured') is true, this will be the frame that was used for the search. |
| [Region](Match.Region.md 'Portal.Detect.Match.Region') | Region(coordinates) of match. |
| [Template](Match.Template.md 'Portal.Detect.Match.Template') | Template from search. |

| Methods | |
| :--- | :--- |
| [Click(Nullable&lt;InputData&gt;, Nullable&lt;InputOptions&gt;, Nullable&lt;MouseMoveOptions&gt;, bool)](Match.Click(Nullable_InputData_,Nullable_InputOptions_,Nullable_MouseMoveOptions_,bool).md 'Portal.Detect.Match.Click(System.Nullable<Portal.Input.InputData>, System.Nullable<Portal.Input.InputOptions>, System.Nullable<Portal.Input.MouseMoveOptions>, bool)') | Moves the mouse to the center of the result(match), and clicks. |
| [Dispose()](Match.Dispose().md 'Portal.Detect.Match.Dispose()') | Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources. |
| [Draw(int, Nullable&lt;Color4&gt;)](Match.Draw(int,Nullable_Color4_).md 'Portal.Detect.Match.Draw(int, System.Nullable<Vortice.Mathematics.Color4>)') | Draws the image detection result(match) on the screen. |
| [Move(Nullable&lt;MouseMoveOptions&gt;, bool)](Match.Move(Nullable_MouseMoveOptions_,bool).md 'Portal.Detect.Match.Move(System.Nullable<Portal.Input.MouseMoveOptions>, bool)') | Moves the mouse to the center of the result(match). |
| [ToString()](Match.ToString().md 'Portal.Detect.Match.ToString()') | Overridden ToString function. |
