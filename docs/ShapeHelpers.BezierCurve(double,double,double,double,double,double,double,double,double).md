#### [Portal](index.md 'index')
### [Portal.Utility](Portal.Utility.md 'Portal.Utility').[ShapeHelpers](ShapeHelpers.md 'Portal.Utility.ShapeHelpers')

## ShapeHelpers.BezierCurve(double, double, double, double, double, double, double, double, double) Method

ベジェ曲線を求めます

```csharp
public static System.Numerics.Vector2 BezierCurve(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, double t);
```
#### Parameters

<a name='Portal.Utility.ShapeHelpers.BezierCurve(double,double,double,double,double,double,double,double,double).x1'></a>

`x1` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

始点の X 座標

<a name='Portal.Utility.ShapeHelpers.BezierCurve(double,double,double,double,double,double,double,double,double).y1'></a>

`y1` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

始点の Y 座標

<a name='Portal.Utility.ShapeHelpers.BezierCurve(double,double,double,double,double,double,double,double,double).x2'></a>

`x2` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

制御点1 の X 座標

<a name='Portal.Utility.ShapeHelpers.BezierCurve(double,double,double,double,double,double,double,double,double).y2'></a>

`y2` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

制御点1 の Y 座標

<a name='Portal.Utility.ShapeHelpers.BezierCurve(double,double,double,double,double,double,double,double,double).x3'></a>

`x3` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

制御点2 の X 座標

<a name='Portal.Utility.ShapeHelpers.BezierCurve(double,double,double,double,double,double,double,double,double).y3'></a>

`y3` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

制御点2 の Y 座標

<a name='Portal.Utility.ShapeHelpers.BezierCurve(double,double,double,double,double,double,double,double,double).x4'></a>

`x4` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

終点の X 座標

<a name='Portal.Utility.ShapeHelpers.BezierCurve(double,double,double,double,double,double,double,double,double).y4'></a>

`y4` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

終点の Y 座標

<a name='Portal.Utility.ShapeHelpers.BezierCurve(double,double,double,double,double,double,double,double,double).t'></a>

`t` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

重み（ 0 ～ 1 ）

#### Returns
[System.Numerics.Vector2](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.Vector2 'System.Numerics.Vector2')