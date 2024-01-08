#### [Portal](index.md 'index')
### [Portal](Portal.md 'Portal')

## Region Struct

Stores the location and size of a rectangular region.

```csharp
public struct Region :
System.IEquatable<Portal.Region>
```

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Region](Region.md 'Portal.Region')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [Region(int, int, int, int)](Region.Region(int,int,int,int).md 'Portal.Region.Region(int, int, int, int)') | Initializes a new instance of the [Region](Region.md 'Portal.Region') class with the specified location<br/>and size. |
| [Region(Point, Size)](Region.Region(Point,Size).md 'Portal.Region.Region(Portal.Point, Portal.Size)') | Initializes a new instance of the Rectangle class with the specified location and size. |

| Properties | |
| :--- | :--- |
| [Bottom](Region.Bottom.md 'Portal.Region.Bottom') | Gets the y-coordinate of the lower-right corner of the rectangular region defined by this<br/>[Region](Region.md 'Portal.Region'). |
| [Center](Region.Center.md 'Portal.Region.Center') | Center of region in coordinates. |
| [Height](Region.Height.md 'Portal.Region.Height') | Gets or sets the width of the rectangular region defined by this [Region](Region.md 'Portal.Region'). |
| [IsEmpty](Region.IsEmpty.md 'Portal.Region.IsEmpty') | Tests whether this [Region](Region.md 'Portal.Region') has a [Width](Region.Width.md 'Portal.Region.Width')<br/>or a [Height](Region.Height.md 'Portal.Region.Height') of 0. |
| [Left](Region.Left.md 'Portal.Region.Left') | Gets the x-coordinate of the upper-left corner of the rectangular region defined by this<br/>[Region](Region.md 'Portal.Region') . |
| [Location](Region.Location.md 'Portal.Region.Location') | Gets or sets the coordinates of the upper-left corner of the rectangular region represented by this<br/>[Region](Region.md 'Portal.Region'). |
| [Right](Region.Right.md 'Portal.Region.Right') | Gets the x-coordinate of the lower-right corner of the rectangular region defined by this<br/>[Region](Region.md 'Portal.Region'). |
| [Size](Region.Size.md 'Portal.Region.Size') | Gets or sets the size of this [Region](Region.md 'Portal.Region'). |
| [Top](Region.Top.md 'Portal.Region.Top') | Gets the y-coordinate of the upper-left corner of the rectangular region defined by this<br/>[Region](Region.md 'Portal.Region'). |
| [Width](Region.Width.md 'Portal.Region.Width') | Gets or sets the width of the rectangular region defined by this [Region](Region.md 'Portal.Region'). |
| [X](Region.X.md 'Portal.Region.X') | Gets or sets the x-coordinate of the upper-left corner of the rectangular region defined by this<br/>[Region](Region.md 'Portal.Region'). |
| [Y](Region.Y.md 'Portal.Region.Y') | Gets or sets the y-coordinate of the upper-left corner of the rectangular region defined by this<br/>[Region](Region.md 'Portal.Region'). |

| Methods | |
| :--- | :--- |
| [Ceiling(RegionD)](Region.Ceiling(RegionD).md 'Portal.Region.Ceiling(Portal.RegionD)') | Converts a RectangleF to a Rectangle by performing a ceiling operation on all the coordinates. |
| [Contains(int, int)](Region.Contains(int,int).md 'Portal.Region.Contains(int, int)') | Determines if the specified point is contained within the rectangular region defined by this<br/>[Region](Region.md 'Portal.Region') . |
| [Contains(Point)](Region.Contains(Point).md 'Portal.Region.Contains(Portal.Point)') | Determines if the specified point is contained within the rectangular region defined by this<br/>[Region](Region.md 'Portal.Region') . |
| [Contains(Region)](Region.Contains(Region).md 'Portal.Region.Contains(Portal.Region)') | Determines if the rectangular region represented by [rect](Region.Contains(Region).md#Portal.Region.Contains(Portal.Region).rect 'Portal.Region.Contains(Portal.Region).rect') is entirely contained within the<br/>rectangular region represented by this [Region](Region.md 'Portal.Region') . |
| [Equals(object)](Region.Equals(object).md 'Portal.Region.Equals(object)') | Tests whether [obj](Region.Equals(object).md#Portal.Region.Equals(object).obj 'Portal.Region.Equals(object).obj') is a [Region](Region.md 'Portal.Region') with the same location<br/>and size of this Rectangle. |
| [FromLTRB(int, int, int, int)](Region.FromLTRB(int,int,int,int).md 'Portal.Region.FromLTRB(int, int, int, int)') | Creates a new [Region](Region.md 'Portal.Region') with the specified location and size. |
| [FromString(string)](Region.FromString(string).md 'Portal.Region.FromString(string)') | Converts the string representation of a region to its [Region](Region.md 'Portal.Region') equivalent. |
| [Inflate(int, int)](Region.Inflate(int,int).md 'Portal.Region.Inflate(int, int)') | Inflates this [Region](Region.md 'Portal.Region') by the specified amount. |
| [Inflate(Region, int, int)](Region.Inflate(Region,int,int).md 'Portal.Region.Inflate(Portal.Region, int, int)') | Creates a [Region](Region.md 'Portal.Region') that is inflated by the specified amount. |
| [Inflate(Size)](Region.Inflate(Size).md 'Portal.Region.Inflate(Portal.Size)') | Inflates this [Region](Region.md 'Portal.Region') by the specified amount. |
| [Intersect(Region, Region)](Region.Intersect(Region,Region).md 'Portal.Region.Intersect(Portal.Region, Portal.Region)') | Creates a rectangle that represents the intersection between a and b. If there is no intersection, an<br/>empty rectangle is returned. |
| [Intersect(Region)](Region.Intersect(Region).md 'Portal.Region.Intersect(Portal.Region)') | Creates a Rectangle that represents the intersection between this Rectangle and rect. |
| [IntersectsWith(Region)](Region.IntersectsWith(Region).md 'Portal.Region.IntersectsWith(Portal.Region)') | Determines if this rectangle intersects with rect. |
| [Offset(int, int)](Region.Offset(int,int).md 'Portal.Region.Offset(int, int)') | Adjusts the location of this rectangle by the specified amount. |
| [Offset(Point)](Region.Offset(Point).md 'Portal.Region.Offset(Portal.Point)') | Adjusts the location of this rectangle by the specified amount. |
| [Round(RegionD)](Region.Round(RegionD).md 'Portal.Region.Round(Portal.RegionD)') | Converts a RectangleF to a Rectangle by performing a round operation on all the coordinates. |
| [ToString()](Region.ToString().md 'Portal.Region.ToString()') | Converts the attributes of this [Region](Region.md 'Portal.Region') to a human readable string. |
| [Truncate(RegionD)](Region.Truncate(RegionD).md 'Portal.Region.Truncate(Portal.RegionD)') | Converts a RectangleF to a Rectangle by performing a truncate operation on all the coordinates. |
| [Union(Region, Region)](Region.Union(Region,Region).md 'Portal.Region.Union(Portal.Region, Portal.Region)') | Creates a rectangle that represents the union between a and b. |

| Operators | |
| :--- | :--- |
| [operator ==(Region, Region)](Region.operator(Region,Region).md 'Portal.Region.op_Equality(Portal.Region, Portal.Region)') | Tests whether two [Region](Region.md 'Portal.Region') objects have equal location and size. |
| [operator !=(Region, Region)](Region.operator!(Region,Region).md 'Portal.Region.op_Inequality(Portal.Region, Portal.Region)') | Tests whether two [Region](Region.md 'Portal.Region') objects differ in location or size. |
