#### [Portal](index.md 'index')
### [Portal](Portal.md 'Portal')

## Size Struct

Represents the size of a rectangular region with an ordered pair of width and height.

```csharp
public struct Size :
System.IEquatable<Portal.Size>
```

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Size](Size.md 'Portal.Size')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [Size(int, int)](Size.Size(int,int).md 'Portal.Size.Size(int, int)') | Initializes a new instance of the [Size](Size.md 'Portal.Size') class from the specified dimensions. |
| [Size(Point)](Size.Size(Point).md 'Portal.Size.Size(Portal.Point)') | Initializes a new instance of the [Size](Size.md 'Portal.Size') class from the specified<br/>[Point](Point.md 'Portal.Point'). |

| Fields | |
| :--- | :--- |
| [Empty](Size.Empty.md 'Portal.Size.Empty') | Initializes a new instance of the [Size](Size.md 'Portal.Size') class. |

| Properties | |
| :--- | :--- |
| [Height](Size.Height.md 'Portal.Size.Height') | Represents the vertical component of this [Size](Size.md 'Portal.Size'). |
| [IsEmpty](Size.IsEmpty.md 'Portal.Size.IsEmpty') | Tests whether this [Size](Size.md 'Portal.Size') has zero width and height. |
| [Width](Size.Width.md 'Portal.Size.Width') | Represents the horizontal component of this [Size](Size.md 'Portal.Size'). |

| Methods | |
| :--- | :--- |
| [Add(Size, Size)](Size.Add(Size,Size).md 'Portal.Size.Add(Portal.Size, Portal.Size)') | Performs vector addition of two [Size](Size.md 'Portal.Size') objects. |
| [Ceiling(SizeD)](Size.Ceiling(SizeD).md 'Portal.Size.Ceiling(Portal.SizeD)') | Converts a SizeF to a Size by performing a ceiling operation on all the coordinates. |
| [Equals(object)](Size.Equals(object).md 'Portal.Size.Equals(object)') | Tests to see whether the specified object is a [Size](Size.md 'Portal.Size')  with the same dimensions<br/>as this [Size](Size.md 'Portal.Size'). |
| [GetHashCode()](Size.GetHashCode().md 'Portal.Size.GetHashCode()') | Returns a hash code. |
| [Multiply(Size, double)](Size.Multiply(Size,double).md 'Portal.Size.Multiply(Portal.Size, double)') | Multiplies [Size](Size.md 'Portal.Size') by a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') producing [SizeD](SizeD.md 'Portal.SizeD'). |
| [Multiply(Size, int)](Size.Multiply(Size,int).md 'Portal.Size.Multiply(Portal.Size, int)') | Multiplies [Size](Size.md 'Portal.Size') by an [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') producing [Size](Size.md 'Portal.Size'). |
| [Round(SizeD)](Size.Round(SizeD).md 'Portal.Size.Round(Portal.SizeD)') | Converts a SizeF to a Size by performing a round operation on all the coordinates. |
| [Subtract(Size, Size)](Size.Subtract(Size,Size).md 'Portal.Size.Subtract(Portal.Size, Portal.Size)') | Contracts a [Size](Size.md 'Portal.Size') by another [Size](Size.md 'Portal.Size') . |
| [ToString()](Size.ToString().md 'Portal.Size.ToString()') | Creates a human-readable string that represents this [Size](Size.md 'Portal.Size'). |
| [ToVector2()](Size.ToVector2().md 'Portal.Size.ToVector2()') | Creates a new [System.Numerics.Vector2](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.Vector2 'System.Numerics.Vector2') from this [PointD](PointD.md 'Portal.PointD'). |
| [Truncate(SizeD)](Size.Truncate(SizeD).md 'Portal.Size.Truncate(Portal.SizeD)') | Converts a SizeF to a Size by performing a truncate operation on all the coordinates. |

| Operators | |
| :--- | :--- |
| [operator +(Size, Size)](Size.operator+(Size,Size).md 'Portal.Size.op_Addition(Portal.Size, Portal.Size)') | Performs vector addition of two [Size](Size.md 'Portal.Size') objects. |
| [operator /(Size, double)](Size.operator/(Size,double).md 'Portal.Size.op_Division(Portal.Size, double)') | Divides [Size](Size.md 'Portal.Size') by a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') producing [SizeD](SizeD.md 'Portal.SizeD'). |
| [operator /(Size, int)](Size.operator/(Size,int).md 'Portal.Size.op_Division(Portal.Size, int)') | Divides [Size](Size.md 'Portal.Size') by an [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') producing [Size](Size.md 'Portal.Size'). |
| [operator ==(Size, Size)](Size.operator(Size,Size).md 'Portal.Size.op_Equality(Portal.Size, Portal.Size)') | Tests whether two [Size](Size.md 'Portal.Size') objects are identical. |
| [explicit operator Point(Size)](Size.explicitoperatorPoint(Size).md 'Portal.Size.op_Explicit Portal.Point(Portal.Size)') | Converts the specified [Size](Size.md 'Portal.Size') to a [Point](Point.md 'Portal.Point'). |
| [explicit operator Vector2(Size)](Size.explicitoperatorVector2(Size).md 'Portal.Size.op_Explicit System.Numerics.Vector2(Portal.Size)') | Converts the specified [PointD](PointD.md 'Portal.PointD') to a [System.Numerics.Vector2](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.Vector2 'System.Numerics.Vector2'). |
| [implicit operator SizeD(Size)](Size.implicitoperatorSizeD(Size).md 'Portal.Size.op_Implicit Portal.SizeD(Portal.Size)') | Converts the specified [Size](Size.md 'Portal.Size') to a [SizeD](SizeD.md 'Portal.SizeD'). |
| [operator !=(Size, Size)](Size.operator!(Size,Size).md 'Portal.Size.op_Inequality(Portal.Size, Portal.Size)') | Tests whether two [Size](Size.md 'Portal.Size') objects are different. |
| [operator *(double, Size)](Size.operator_(double,Size).md 'Portal.Size.op_Multiply(double, Portal.Size)') | Multiplies [Size](Size.md 'Portal.Size') by a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') producing [SizeD](SizeD.md 'Portal.SizeD'). |
| [operator *(int, Size)](Size.operator_(int,Size).md 'Portal.Size.op_Multiply(int, Portal.Size)') | Multiplies a [Size](Size.md 'Portal.Size') by an [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') producing [Size](Size.md 'Portal.Size'). |
| [operator *(Size, double)](Size.operator_(Size,double).md 'Portal.Size.op_Multiply(Portal.Size, double)') | Multiplies [Size](Size.md 'Portal.Size') by a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') producing [SizeD](SizeD.md 'Portal.SizeD'). |
| [operator *(Size, int)](Size.operator_(Size,int).md 'Portal.Size.op_Multiply(Portal.Size, int)') | Multiplies [Size](Size.md 'Portal.Size') by an [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') producing [Size](Size.md 'Portal.Size'). |
| [operator -(Size, Size)](Size.operator-(Size,Size).md 'Portal.Size.op_Subtraction(Portal.Size, Portal.Size)') | Contracts a [Size](Size.md 'Portal.Size') by another [Size](Size.md 'Portal.Size') |
