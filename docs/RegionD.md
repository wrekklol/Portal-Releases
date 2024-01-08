#### [Portal](index.md 'index')
### [Portal](Portal.md 'Portal')

## RegionD Struct

Stores the location and size of a rectangular region.

```csharp
public struct RegionD :
System.IEquatable<Portal.RegionD>
```

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[RegionD](RegionD.md 'Portal.RegionD')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [RegionD(double, double, double, double)](RegionD.RegionD(double,double,double,double).md 'Portal.RegionD.RegionD(double, double, double, double)') | Initializes a new instance of the [RegionD](RegionD.md 'Portal.RegionD') class with the specified location<br/>and size. |
| [RegionD(PointD, SizeD)](RegionD.RegionD(PointD,SizeD).md 'Portal.RegionD.RegionD(Portal.PointD, Portal.SizeD)') | Initializes a new instance of the [RegionD](RegionD.md 'Portal.RegionD') class with the specified location<br/>and size. |
| [RegionD(Vector4)](RegionD.RegionD(Vector4).md 'Portal.RegionD.RegionD(System.Numerics.Vector4)') | Initializes a new instance of the [RegionD](RegionD.md 'Portal.RegionD') struct from the specified<br/>[System.Numerics.Vector4](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.Vector4 'System.Numerics.Vector4'). |

| Fields | |
| :--- | :--- |
| [Empty](RegionD.Empty.md 'Portal.RegionD.Empty') | Initializes a new instance of the [RegionD](RegionD.md 'Portal.RegionD') class. |

| Properties | |
| :--- | :--- |
| [Bottom](RegionD.Bottom.md 'Portal.RegionD.Bottom') | Gets the y-coordinate of the lower-right corner of the rectangular region defined by this<br/>[RegionD](RegionD.md 'Portal.RegionD'). |
| [Center](RegionD.Center.md 'Portal.RegionD.Center') | Center of region in coordinates. |
| [Height](RegionD.Height.md 'Portal.RegionD.Height') | Gets or sets the height of the rectangular region defined by this [RegionD](RegionD.md 'Portal.RegionD'). |
| [IsEmpty](RegionD.IsEmpty.md 'Portal.RegionD.IsEmpty') | Tests whether this [RegionD](RegionD.md 'Portal.RegionD') has a [Width](RegionD.Width.md 'Portal.RegionD.Width') or a [Height](RegionD.Height.md 'Portal.RegionD.Height') of 0. |
| [Left](RegionD.Left.md 'Portal.RegionD.Left') | Gets the x-coordinate of the upper-left corner of the rectangular region defined by this<br/>[RegionD](RegionD.md 'Portal.RegionD') . |
| [Location](RegionD.Location.md 'Portal.RegionD.Location') | Gets or sets the coordinates of the upper-left corner of the rectangular region represented by this<br/>[RegionD](RegionD.md 'Portal.RegionD'). |
| [Right](RegionD.Right.md 'Portal.RegionD.Right') | Gets the x-coordinate of the lower-right corner of the rectangular region defined by this<br/>[RegionD](RegionD.md 'Portal.RegionD'). |
| [Size](RegionD.Size.md 'Portal.RegionD.Size') | Gets or sets the size of this [RegionD](RegionD.md 'Portal.RegionD'). |
| [Top](RegionD.Top.md 'Portal.RegionD.Top') | Gets the y-coordinate of the upper-left corner of the rectangular region defined by this<br/>[RegionD](RegionD.md 'Portal.RegionD'). |
| [Width](RegionD.Width.md 'Portal.RegionD.Width') | Gets or sets the width of the rectangular region defined by this [RegionD](RegionD.md 'Portal.RegionD'). |
| [X](RegionD.X.md 'Portal.RegionD.X') | Gets or sets the x-coordinate of the upper-left corner of the rectangular region defined by this<br/>[RegionD](RegionD.md 'Portal.RegionD'). |
| [Y](RegionD.Y.md 'Portal.RegionD.Y') | Gets or sets the y-coordinate of the upper-left corner of the rectangular region defined by this<br/>[RegionD](RegionD.md 'Portal.RegionD'). |

| Methods | |
| :--- | :--- |
| [Contains(double, double)](RegionD.Contains(double,double).md 'Portal.RegionD.Contains(double, double)') | Determines if the specified point is contained within the rectangular region defined by this<br/>[Region](Region.md 'Portal.Region') . |
| [Contains(PointD)](RegionD.Contains(PointD).md 'Portal.RegionD.Contains(Portal.PointD)') | Determines if the specified point is contained within the rectangular region defined by this<br/>[Region](Region.md 'Portal.Region') . |
| [Contains(RegionD)](RegionD.Contains(RegionD).md 'Portal.RegionD.Contains(Portal.RegionD)') | Determines if the rectangular region represented by [rect](RegionD.Contains(RegionD).md#Portal.RegionD.Contains(Portal.RegionD).rect 'Portal.RegionD.Contains(Portal.RegionD).rect') is entirely contained within<br/>the rectangular region represented by this [Region](Region.md 'Portal.Region') . |
| [Equals(object)](RegionD.Equals(object).md 'Portal.RegionD.Equals(object)') | Tests whether [obj](RegionD.Equals(object).md#Portal.RegionD.Equals(object).obj 'Portal.RegionD.Equals(object).obj') is a [RegionD](RegionD.md 'Portal.RegionD') with the same location and<br/>size of this [RegionD](RegionD.md 'Portal.RegionD'). |
| [FromLTRB(double, double, double, double)](RegionD.FromLTRB(double,double,double,double).md 'Portal.RegionD.FromLTRB(double, double, double, double)') | Creates a new [RegionD](RegionD.md 'Portal.RegionD') with the specified location and size. |
| [GetHashCode()](RegionD.GetHashCode().md 'Portal.RegionD.GetHashCode()') | Gets the hash code for this [RegionD](RegionD.md 'Portal.RegionD'). |
| [Inflate(double, double)](RegionD.Inflate(double,double).md 'Portal.RegionD.Inflate(double, double)') | Inflates this [Region](Region.md 'Portal.Region') by the specified amount. |
| [Inflate(RegionD, double, double)](RegionD.Inflate(RegionD,double,double).md 'Portal.RegionD.Inflate(Portal.RegionD, double, double)') | Creates a [Region](Region.md 'Portal.Region') that is inflated by the specified amount. |
| [Inflate(SizeD)](RegionD.Inflate(SizeD).md 'Portal.RegionD.Inflate(Portal.SizeD)') | Inflates this [Region](Region.md 'Portal.Region') by the specified amount. |
| [Intersect(RegionD, RegionD)](RegionD.Intersect(RegionD,RegionD).md 'Portal.RegionD.Intersect(Portal.RegionD, Portal.RegionD)') | Creates a rectangle that represents the intersection between a and b. If there is no intersection, an<br/>empty rectangle is returned. |
| [Intersect(RegionD)](RegionD.Intersect(RegionD).md 'Portal.RegionD.Intersect(Portal.RegionD)') | Creates a Rectangle that represents the intersection between this Rectangle and rect. |
| [IntersectsWith(RegionD)](RegionD.IntersectsWith(RegionD).md 'Portal.RegionD.IntersectsWith(Portal.RegionD)') | Determines if this rectangle intersects with rect. |
| [Offset(double, double)](RegionD.Offset(double,double).md 'Portal.RegionD.Offset(double, double)') | Adjusts the location of this rectangle by the specified amount. |
| [Offset(PointD)](RegionD.Offset(PointD).md 'Portal.RegionD.Offset(Portal.PointD)') | Adjusts the location of this rectangle by the specified amount. |
| [ToString()](RegionD.ToString().md 'Portal.RegionD.ToString()') | Converts the [Location](RegionD.Location.md 'Portal.RegionD.Location') and [Size](RegionD.Size.md 'Portal.RegionD.Size')<br/>of this [RegionD](RegionD.md 'Portal.RegionD') to a human-readable string. |
| [ToVector4()](RegionD.ToVector4().md 'Portal.RegionD.ToVector4()') | Creates a new [System.Numerics.Vector4](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.Vector4 'System.Numerics.Vector4') from this [RegionD](RegionD.md 'Portal.RegionD'). |
| [Union(RegionD, RegionD)](RegionD.Union(RegionD,RegionD).md 'Portal.RegionD.Union(Portal.RegionD, Portal.RegionD)') | Creates a rectangle that represents the union between a and b. |

| Operators | |
| :--- | :--- |
| [operator ==(RegionD, RegionD)](RegionD.operator(RegionD,RegionD).md 'Portal.RegionD.op_Equality(Portal.RegionD, Portal.RegionD)') | Tests whether two [RegionD](RegionD.md 'Portal.RegionD') objects have equal location and size. |
| [explicit operator RegionD(Vector4)](RegionD.explicitoperatorRegionD(Vector4).md 'Portal.RegionD.op_Explicit Portal.RegionD(System.Numerics.Vector4)') | Converts the specified [System.Numerics.Vector2](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.Vector2 'System.Numerics.Vector2') to a [RegionD](RegionD.md 'Portal.RegionD'). |
| [explicit operator Vector4(RegionD)](RegionD.explicitoperatorVector4(RegionD).md 'Portal.RegionD.op_Explicit System.Numerics.Vector4(Portal.RegionD)') | Converts the specified [RegionD](RegionD.md 'Portal.RegionD') to a [System.Numerics.Vector4](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.Vector4 'System.Numerics.Vector4'). |
| [implicit operator RegionD(Region)](RegionD.implicitoperatorRegionD(Region).md 'Portal.RegionD.op_Implicit Portal.RegionD(Portal.Region)') | Converts the specified [Region](Region.md 'Portal.Region') to a<br/>[RegionD](RegionD.md 'Portal.RegionD'). |
| [operator !=(RegionD, RegionD)](RegionD.operator!(RegionD,RegionD).md 'Portal.RegionD.op_Inequality(Portal.RegionD, Portal.RegionD)') | Tests whether two [RegionD](RegionD.md 'Portal.RegionD') objects differ in location or size. |
