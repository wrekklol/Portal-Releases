#### [Portal](index.md 'index')
### [Portal](Portal.md 'Portal').[GamePoint](GamePoint.md 'Portal.GamePoint')

## GamePoint.MakeFromRelativeCoords(int, int) Method

Converts the specified relative screen coordinates to game coordinates.

```csharp
public static Portal.GamePoint MakeFromRelativeCoords(int InX, int InY);
```
#### Parameters

<a name='Portal.GamePoint.MakeFromRelativeCoords(int,int).InX'></a>

`InX` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The X coordinate on the screen, relative to the game region's width.

<a name='Portal.GamePoint.MakeFromRelativeCoords(int,int).InY'></a>

`InY` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The Y coordinate on the screen, relative to the game region's height.

#### Returns
[GamePoint](GamePoint.md 'Portal.GamePoint')  
A [GamePoint](GamePoint.md 'Portal.GamePoint') representing the game coordinates.