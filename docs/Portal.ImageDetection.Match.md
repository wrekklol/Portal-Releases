#### [Portal](index.md 'index')
### [Portal.ImageDetection](Portal.ImageDetection.md 'Portal.ImageDetection')

## Match Class

Result(s) of image detection is stored as a Match.

```csharp
public class Match
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Match

| Constructors | |
| :--- | :--- |
| [Match(GameRegion, double)](Portal.ImageDetection.Match.Match(Portal.GameRegion,double).md 'Portal.ImageDetection.Match.Match(Portal.GameRegion, double)') | Match constructor. |

| Properties | |
| :--- | :--- |
| [Confidence](Portal.ImageDetection.Match.Confidence.md 'Portal.ImageDetection.Match.Confidence') | Confidence of match. |
| [Region](Portal.ImageDetection.Match.Region.md 'Portal.ImageDetection.Match.Region') | Region(coordinates) of match. |

| Methods | |
| :--- | :--- |
| [Click(int, bool)](Portal.ImageDetection.Match.Click(int,bool).md 'Portal.ImageDetection.Match.Click(int, bool)') | Moves the cursor to the center of the result(match), and clicks. |
| [Draw(string, int)](Portal.ImageDetection.Match.Draw(string,int).md 'Portal.ImageDetection.Match.Draw(string, int)') | Draws the image detection result(match) on the screen. |
| [ToString()](Portal.ImageDetection.Match.ToString().md 'Portal.ImageDetection.Match.ToString()') | Overridden ToString function. |
