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
| [Match(GameRegion, double)](Match.Match(GameRegion,double).md 'Portal.ImageDetection.Match.Match(Portal.GameRegion, double)') | Match constructor. |

| Properties | |
| :--- | :--- |
| [Confidence](Match.Confidence.md 'Portal.ImageDetection.Match.Confidence') | Confidence of match. |
| [Region](Match.Region.md 'Portal.ImageDetection.Match.Region') | Region(coordinates) of match. |

| Methods | |
| :--- | :--- |
| [Click(int, bool)](Match.Click(int,bool).md 'Portal.ImageDetection.Match.Click(int, bool)') | Moves the cursor to the center of the result(match), and clicks. |
| [Draw(int, string)](Match.Draw(int,string).md 'Portal.ImageDetection.Match.Draw(int, string)') | Draws the image detection result(match) on the screen. |
| [ToString()](Match.ToString().md 'Portal.ImageDetection.Match.ToString()') | Overridden ToString function. |
