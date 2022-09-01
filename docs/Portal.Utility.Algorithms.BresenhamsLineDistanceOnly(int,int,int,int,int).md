#### [Portal](index.md 'index')
### [Portal.Utility](Portal.Utility.md 'Portal.Utility').[Algorithms](Portal.Utility.Algorithms.md 'Portal.Utility.Algorithms')

## Algorithms.BresenhamsLineDistanceOnly(int, int, int, int, int) Method

Generates a list of points that are on the line between the start and end points.

```csharp
public static System.Collections.Generic.List<(int,int)> BresenhamsLineDistanceOnly(int InStartX, int InStartY, int InEndX, int InEndY, int InMaxPoints);
```
#### Parameters

<a name='Portal.Utility.Algorithms.BresenhamsLineDistanceOnly(int,int,int,int,int).InStartX'></a>

`InStartX` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

X coordinate of the starting point of the line.

<a name='Portal.Utility.Algorithms.BresenhamsLineDistanceOnly(int,int,int,int,int).InStartY'></a>

`InStartY` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Y coordinate of the starting point of the line.

<a name='Portal.Utility.Algorithms.BresenhamsLineDistanceOnly(int,int,int,int,int).InEndX'></a>

`InEndX` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

X coordinate of the end point of the line.

<a name='Portal.Utility.Algorithms.BresenhamsLineDistanceOnly(int,int,int,int,int).InEndY'></a>

`InEndY` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Y coordinate of the end point of the line.

<a name='Portal.Utility.Algorithms.BresenhamsLineDistanceOnly(int,int,int,int,int).InMaxPoints'></a>

`InMaxPoints` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Maximum number of points to return.

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')