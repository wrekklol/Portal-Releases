#### [Portal](index.md 'index')
### [Portal.Detection](Portal.Detection.md 'Portal.Detection')

## Match Class

Result(s) of image detection is stored as a Match.

```csharp
public class Match
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Match

| Constructors | |
| :--- | :--- |
| [Match(GameRegion, double)](Match.Match(GameRegion,double).md 'Portal.Detection.Match.Match(Portal.GameRegion, double)') | Match constructor. |

| Properties | |
| :--- | :--- |
| [Confidence](Match.Confidence.md 'Portal.Detection.Match.Confidence') | Confidence of match. |
| [Region](Match.Region.md 'Portal.Detection.Match.Region') | Region(coordinates) of match. |

| Methods | |
| :--- | :--- |
| [Click(int, bool)](Match.Click(int,bool).md 'Portal.Detection.Match.Click(int, bool)') | Moves the mouse to the center of the result(match), and clicks. |
| [Draw(int, string)](Match.Draw(int,string).md 'Portal.Detection.Match.Draw(int, string)') | Draws the image detection result(match) on the screen. |
| [ToString()](Match.ToString().md 'Portal.Detection.Match.ToString()') | Overridden ToString function. |
