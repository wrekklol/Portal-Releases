#### [Portal](index.md 'index')
### [Portal](Portal.md 'Portal').[GamePoint](GamePoint.md 'Portal.GamePoint')

## GamePoint.MakeFromCoords(int, int) Method

Converts the specified screen coordinates to game coordinates.

```csharp
public static Portal.GamePoint MakeFromCoords(int InX, int InY);
```
#### Parameters

<a name='Portal.GamePoint.MakeFromCoords(int,int).InX'></a>

`InX` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The X coordinate on the screen. ((InX - (double)GameRegion.X) / GameRegion.Width * 100d)

<a name='Portal.GamePoint.MakeFromCoords(int,int).InY'></a>

`InY` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The Y coordinate on the screen. ((InY - (double)GameRegion.Y) / GameRegion.Height * 100d)

#### Returns
[GamePoint](GamePoint.md 'Portal.GamePoint')  
A [GamePoint](GamePoint.md 'Portal.GamePoint') representing the game coordinates.