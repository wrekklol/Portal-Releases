#### [Portal](index.md 'index')
### [Portal](Portal.md 'Portal')

## PointD Struct

Represents an ordered pair of x and y coordinates that define a point in a two-dimensional plane.

```csharp
public struct PointD :
System.IEquatable<Portal.PointD>
```

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[PointD](PointD.md 'Portal.PointD')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [PointD(double, double)](PointD.PointD(double,double).md 'Portal.PointD.PointD(double, double)') | Initializes a new instance of the [PointD](PointD.md 'Portal.PointD') class with the specified coordinates. |
| [PointD(Vector2)](PointD.PointD(Vector2).md 'Portal.PointD.PointD(System.Numerics.Vector2)') | Initializes a new instance of the [PointD](PointD.md 'Portal.PointD') struct from the specified<br/>[System.Numerics.Vector2](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.Vector2 'System.Numerics.Vector2'). |

| Fields | |
| :--- | :--- |
| [Empty](PointD.Empty.md 'Portal.PointD.Empty') | Creates a new instance of the [PointD](PointD.md 'Portal.PointD') class with member data left uninitialized. |

| Properties | |
| :--- | :--- |
| [IsEmpty](PointD.IsEmpty.md 'Portal.PointD.IsEmpty') | Gets a value indicating whether this [PointD](PointD.md 'Portal.PointD') is empty. |
| [X](PointD.X.md 'Portal.PointD.X') | Gets the x-coordinate of this [PointD](PointD.md 'Portal.PointD'). |
| [Y](PointD.Y.md 'Portal.PointD.Y') | Gets the y-coordinate of this [PointD](PointD.md 'Portal.PointD'). |

| Methods | |
| :--- | :--- |
| [Add(PointD, Size)](PointD.Add(PointD,Size).md 'Portal.PointD.Add(Portal.PointD, Portal.Size)') | Translates a [PointD](PointD.md 'Portal.PointD') by a given [Size](Size.md 'Portal.Size') . |
| [Add(PointD, SizeD)](PointD.Add(PointD,SizeD).md 'Portal.PointD.Add(Portal.PointD, Portal.SizeD)') | Translates a [PointD](PointD.md 'Portal.PointD') by a given [SizeD](SizeD.md 'Portal.SizeD') . |
| [Equals(object)](PointD.Equals(object).md 'Portal.PointD.Equals(object)') | Specifies whether this [Point](Point.md 'Portal.Point') contains the same coordinates as the specified<br/>[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object'). |
| [GetHashCode()](PointD.GetHashCode().md 'Portal.PointD.GetHashCode()') | Returns a hash code. |
| [Offset(double, double)](PointD.Offset(double,double).md 'Portal.PointD.Offset(double, double)') | Translates this [Point](Point.md 'Portal.Point') by the specified amount. |
| [Offset(PointD)](PointD.Offset(PointD).md 'Portal.PointD.Offset(Portal.PointD)') | Translates this [Point](Point.md 'Portal.Point') by the specified amount. |
| [Subtract(PointD, Size)](PointD.Subtract(PointD,Size).md 'Portal.PointD.Subtract(Portal.PointD, Portal.Size)') | Translates a [PointD](PointD.md 'Portal.PointD') by the negative of a given [Size](Size.md 'Portal.Size') . |
| [Subtract(PointD, SizeD)](PointD.Subtract(PointD,SizeD).md 'Portal.PointD.Subtract(Portal.PointD, Portal.SizeD)') | Translates a [PointD](PointD.md 'Portal.PointD') by the negative of a given [SizeD](SizeD.md 'Portal.SizeD') . |
| [ToString()](PointD.ToString().md 'Portal.PointD.ToString()') | Converts this [Point](Point.md 'Portal.Point') to a human readable string. |
| [ToVector2()](PointD.ToVector2().md 'Portal.PointD.ToVector2()') | Creates a new [System.Numerics.Vector2](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.Vector2 'System.Numerics.Vector2') from this [PointD](PointD.md 'Portal.PointD'). |

| Operators | |
| :--- | :--- |
| [operator +(PointD, Size)](PointD.operator+(PointD,Size).md 'Portal.PointD.op_Addition(Portal.PointD, Portal.Size)') | Translates a [PointD](PointD.md 'Portal.PointD') by a given [Size](Size.md 'Portal.Size') . |
| [operator +(PointD, SizeD)](PointD.operator+(PointD,SizeD).md 'Portal.PointD.op_Addition(Portal.PointD, Portal.SizeD)') | Translates a [PointD](PointD.md 'Portal.PointD') by a given [SizeD](SizeD.md 'Portal.SizeD') . |
| [operator ==(PointD, PointD)](PointD.operator(PointD,PointD).md 'Portal.PointD.op_Equality(Portal.PointD, Portal.PointD)') | Compares two [PointD](PointD.md 'Portal.PointD') objects. The result specifies whether the values of the<br/>[X](PointD.X.md 'Portal.PointD.X') and [Y](PointD.Y.md 'Portal.PointD.Y') properties of the two<br/>[PointD](PointD.md 'Portal.PointD') objects are equal. |
| [explicit operator Vector2(PointD)](PointD.explicitoperatorVector2(PointD).md 'Portal.PointD.op_Explicit System.Numerics.Vector2(Portal.PointD)') | Converts the specified [PointD](PointD.md 'Portal.PointD') to a [System.Numerics.Vector2](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.Vector2 'System.Numerics.Vector2'). |
| [operator !=(PointD, PointD)](PointD.operator!(PointD,PointD).md 'Portal.PointD.op_Inequality(Portal.PointD, Portal.PointD)') | Compares two [PointD](PointD.md 'Portal.PointD') objects. The result specifies whether the values of the<br/>[X](PointD.X.md 'Portal.PointD.X') or [Y](PointD.Y.md 'Portal.PointD.Y') properties of the two<br/>[PointD](PointD.md 'Portal.PointD') objects are unequal. |
| [operator -(PointD, Size)](PointD.operator-(PointD,Size).md 'Portal.PointD.op_Subtraction(Portal.PointD, Portal.Size)') | Translates a [PointD](PointD.md 'Portal.PointD') by the negative of a given [Size](Size.md 'Portal.Size') . |
| [operator -(PointD, SizeD)](PointD.operator-(PointD,SizeD).md 'Portal.PointD.op_Subtraction(Portal.PointD, Portal.SizeD)') | Translates a [PointD](PointD.md 'Portal.PointD') by the negative of a given [SizeD](SizeD.md 'Portal.SizeD') . |
