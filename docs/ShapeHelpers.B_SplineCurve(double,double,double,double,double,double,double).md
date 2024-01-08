#### [Portal](index.md 'index')
### [Portal.Utility](Portal.Utility.md 'Portal.Utility').[ShapeHelpers](ShapeHelpers.md 'Portal.Utility.ShapeHelpers')

## ShapeHelpers.B_SplineCurve(double, double, double, double, double, double, double) Method

B-スプライン曲線を求めます

```csharp
public static System.Numerics.Vector2 B_SplineCurve(double x1, double y1, double x2, double y2, double x3, double y3, double t);
```
#### Parameters

<a name='Portal.Utility.ShapeHelpers.B_SplineCurve(double,double,double,double,double,double,double).x1'></a>

`x1` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

始点の X 座標

<a name='Portal.Utility.ShapeHelpers.B_SplineCurve(double,double,double,double,double,double,double).y1'></a>

`y1` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

始点の Y 座標

<a name='Portal.Utility.ShapeHelpers.B_SplineCurve(double,double,double,double,double,double,double).x2'></a>

`x2` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

制御点 の X 座標

<a name='Portal.Utility.ShapeHelpers.B_SplineCurve(double,double,double,double,double,double,double).y2'></a>

`y2` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

制御点 の Y 座標

<a name='Portal.Utility.ShapeHelpers.B_SplineCurve(double,double,double,double,double,double,double).x3'></a>

`x3` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

終点の X 座標

<a name='Portal.Utility.ShapeHelpers.B_SplineCurve(double,double,double,double,double,double,double).y3'></a>

`y3` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

終点の Y 座標

<a name='Portal.Utility.ShapeHelpers.B_SplineCurve(double,double,double,double,double,double,double).t'></a>

`t` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

重み（ 0 ～ 1 ）

#### Returns
[System.Numerics.Vector2](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.Vector2 'System.Numerics.Vector2')