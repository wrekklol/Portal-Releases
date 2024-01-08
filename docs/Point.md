#### [Portal](index.md 'index')
### [Portal](Portal.md 'Portal')

## Point Struct

Represents an ordered pair of x and y coordinates that define a point in a two-dimensional plane.

```csharp
public struct Point :
System.IEquatable<Portal.Point>
```

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Point](Point.md 'Portal.Point')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [Point(int, int)](Point.Point(int,int).md 'Portal.Point.Point(int, int)') | Initializes a new instance of the [Point](Point.md 'Portal.Point') class with the specified coordinates. |
| [Point(int)](Point.Point(int).md 'Portal.Point.Point(int)') | Initializes a new instance of the Point class using coordinates specified by an integer value. |
| [Point(Size)](Point.Point(Size).md 'Portal.Point.Point(Portal.Size)') | Initializes a new instance of the [Point](Point.md 'Portal.Point') class from a [Size](Size.md 'Portal.Size') . |

| Fields | |
| :--- | :--- |
| [Empty](Point.Empty.md 'Portal.Point.Empty') | Creates a new instance of the [Point](Point.md 'Portal.Point') class with member data left uninitialized. |

| Properties | |
| :--- | :--- |
| [IsEmpty](Point.IsEmpty.md 'Portal.Point.IsEmpty') | Gets a value indicating whether this [Point](Point.md 'Portal.Point') is empty. |
| [X](Point.X.md 'Portal.Point.X') | Gets the x-coordinate of this [Point](Point.md 'Portal.Point'). |
| [Y](Point.Y.md 'Portal.Point.Y') | Gets the y-coordinate of this [Point](Point.md 'Portal.Point'). |

| Methods | |
| :--- | :--- |
| [Add(Point, Point)](Point.Add(Point,Point).md 'Portal.Point.Add(Portal.Point, Portal.Point)') | Translates a [Point](Point.md 'Portal.Point') by a given [Point](Point.md 'Portal.Point') . |
| [Add(Point, Size)](Point.Add(Point,Size).md 'Portal.Point.Add(Portal.Point, Portal.Size)') | Translates a [Point](Point.md 'Portal.Point') by a given [Size](Size.md 'Portal.Size') . |
| [Ceiling(PointD)](Point.Ceiling(PointD).md 'Portal.Point.Ceiling(Portal.PointD)') | Converts a PointF to a Point by performing a ceiling operation on all the coordinates. |
| [Equals(object)](Point.Equals(object).md 'Portal.Point.Equals(object)') | Specifies whether this [Point](Point.md 'Portal.Point') contains the same coordinates as the specified<br/>[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object'). |
| [GetHashCode()](Point.GetHashCode().md 'Portal.Point.GetHashCode()') | Returns a hash code. |
| [Offset(int, int)](Point.Offset(int,int).md 'Portal.Point.Offset(int, int)') | Translates this [Point](Point.md 'Portal.Point') by the specified amount. |
| [Offset(Point)](Point.Offset(Point).md 'Portal.Point.Offset(Portal.Point)') | Translates this [Point](Point.md 'Portal.Point') by the specified amount. |
| [Round(PointD)](Point.Round(PointD).md 'Portal.Point.Round(Portal.PointD)') | Converts a PointF to a Point by performing a round operation on all the coordinates. |
| [Subtract(Point, Point)](Point.Subtract(Point,Point).md 'Portal.Point.Subtract(Portal.Point, Portal.Point)') | Translates a [Point](Point.md 'Portal.Point') by the negative of a given [Point](Point.md 'Portal.Point') . |
| [Subtract(Point, Size)](Point.Subtract(Point,Size).md 'Portal.Point.Subtract(Portal.Point, Portal.Size)') | Translates a [Point](Point.md 'Portal.Point') by the negative of a given [Size](Size.md 'Portal.Size') . |
| [ToString()](Point.ToString().md 'Portal.Point.ToString()') | Converts this [Point](Point.md 'Portal.Point') to a human readable string. |
| [ToVector2()](Point.ToVector2().md 'Portal.Point.ToVector2()') | Creates a new [System.Numerics.Vector2](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.Vector2 'System.Numerics.Vector2') from this [PointD](PointD.md 'Portal.PointD'). |
| [Truncate(PointD)](Point.Truncate(PointD).md 'Portal.Point.Truncate(Portal.PointD)') | Converts a PointF to a Point by performing a truncate operation on all the coordinates. |

| Operators | |
| :--- | :--- |
| [operator +(Point, Point)](Point.operator+(Point,Point).md 'Portal.Point.op_Addition(Portal.Point, Portal.Point)') | Translates a [Point](Point.md 'Portal.Point') by a given [Point](Point.md 'Portal.Point') . |
| [operator +(Point, Size)](Point.operator+(Point,Size).md 'Portal.Point.op_Addition(Portal.Point, Portal.Size)') | Translates a [Point](Point.md 'Portal.Point') by a given [Size](Size.md 'Portal.Size') . |
| [operator ==(Point, Point)](Point.operator(Point,Point).md 'Portal.Point.op_Equality(Portal.Point, Portal.Point)') | Compares two [Point](Point.md 'Portal.Point') objects. The result specifies whether the values of the<br/>[X](Point.X.md 'Portal.Point.X') and [Y](Point.Y.md 'Portal.Point.Y') properties of the two<br/>[Point](Point.md 'Portal.Point') objects are equal. |
| [explicit operator Size(Point)](Point.explicitoperatorSize(Point).md 'Portal.Point.op_Explicit Portal.Size(Portal.Point)') | Creates a [Size](Size.md 'Portal.Size') with the coordinates of the specified [Point](Point.md 'Portal.Point') . |
| [explicit operator Vector2(Point)](Point.explicitoperatorVector2(Point).md 'Portal.Point.op_Explicit System.Numerics.Vector2(Portal.Point)') | Converts the specified [Point](Point.md 'Portal.Point') to a [System.Numerics.Vector2](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.Vector2 'System.Numerics.Vector2'). |
| [implicit operator PointD(Point)](Point.implicitoperatorPointD(Point).md 'Portal.Point.op_Implicit Portal.PointD(Portal.Point)') | Creates a [PointD](PointD.md 'Portal.PointD') with the coordinates of the specified [Point](Point.md 'Portal.Point') |
| [operator !=(Point, Point)](Point.operator!(Point,Point).md 'Portal.Point.op_Inequality(Portal.Point, Portal.Point)') | Compares two [Point](Point.md 'Portal.Point') objects. The result specifies whether the values of the<br/>[X](Point.X.md 'Portal.Point.X') or [Y](Point.Y.md 'Portal.Point.Y') properties of the two<br/>[Point](Point.md 'Portal.Point')  objects are unequal. |
| [operator -(Point, Point)](Point.operator-(Point,Point).md 'Portal.Point.op_Subtraction(Portal.Point, Portal.Point)') | Translates a [Point](Point.md 'Portal.Point') by the negative of a given [Point](Point.md 'Portal.Point') . |
| [operator -(Point, Size)](Point.operator-(Point,Size).md 'Portal.Point.op_Subtraction(Portal.Point, Portal.Size)') | Translates a [Point](Point.md 'Portal.Point') by the negative of a given [Size](Size.md 'Portal.Size') . |
