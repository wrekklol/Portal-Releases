#### [Portal](index.md 'index')
### [Portal](Portal.md 'Portal')

## SizeD Struct

Represents the size of a rectangular region with an ordered pair of width and height.

```csharp
public struct SizeD :
System.IEquatable<Portal.SizeD>
```

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[SizeD](SizeD.md 'Portal.SizeD')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [SizeD(double, double)](SizeD.SizeD(double,double).md 'Portal.SizeD.SizeD(double, double)') | Initializes a new instance of the [SizeD](SizeD.md 'Portal.SizeD') class from the specified dimensions. |
| [SizeD(PointD)](SizeD.SizeD(PointD).md 'Portal.SizeD.SizeD(Portal.PointD)') | Initializes a new instance of the [SizeD](SizeD.md 'Portal.SizeD') class from the specified<br/>[PointD](PointD.md 'Portal.PointD'). |
| [SizeD(SizeD)](SizeD.SizeD(SizeD).md 'Portal.SizeD.SizeD(Portal.SizeD)') | Initializes a new instance of the [SizeD](SizeD.md 'Portal.SizeD') class from the specified<br/>existing [SizeD](SizeD.md 'Portal.SizeD'). |
| [SizeD(Vector2)](SizeD.SizeD(Vector2).md 'Portal.SizeD.SizeD(System.Numerics.Vector2)') | Initializes a new instance of the [SizeD](SizeD.md 'Portal.SizeD') struct from the specified<br/>[System.Numerics.Vector2](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.Vector2 'System.Numerics.Vector2'). |

| Fields | |
| :--- | :--- |
| [Empty](SizeD.Empty.md 'Portal.SizeD.Empty') | Initializes a new instance of the [SizeD](SizeD.md 'Portal.SizeD') class. |

| Properties | |
| :--- | :--- |
| [Height](SizeD.Height.md 'Portal.SizeD.Height') | Represents the vertical component of this [SizeD](SizeD.md 'Portal.SizeD'). |
| [IsEmpty](SizeD.IsEmpty.md 'Portal.SizeD.IsEmpty') | Tests whether this [SizeD](SizeD.md 'Portal.SizeD') has zero width and height. |
| [Width](SizeD.Width.md 'Portal.SizeD.Width') | Represents the horizontal component of this [SizeD](SizeD.md 'Portal.SizeD'). |

| Methods | |
| :--- | :--- |
| [Add(SizeD, SizeD)](SizeD.Add(SizeD,SizeD).md 'Portal.SizeD.Add(Portal.SizeD, Portal.SizeD)') | Performs vector addition of two [SizeD](SizeD.md 'Portal.SizeD') objects. |
| [Equals(object)](SizeD.Equals(object).md 'Portal.SizeD.Equals(object)') | Tests to see whether the specified object is a [SizeD](SizeD.md 'Portal.SizeD')  with the same dimensions<br/>as this [SizeD](SizeD.md 'Portal.SizeD'). |
| [Multiply(SizeD, double)](SizeD.Multiply(SizeD,double).md 'Portal.SizeD.Multiply(Portal.SizeD, double)') | Multiplies [SizeD](SizeD.md 'Portal.SizeD') by a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') producing [SizeD](SizeD.md 'Portal.SizeD'). |
| [Subtract(SizeD, SizeD)](SizeD.Subtract(SizeD,SizeD).md 'Portal.SizeD.Subtract(Portal.SizeD, Portal.SizeD)') | Contracts a [SizeD](SizeD.md 'Portal.SizeD') by another [SizeD](SizeD.md 'Portal.SizeD'). |
| [ToString()](SizeD.ToString().md 'Portal.SizeD.ToString()') | Creates a human-readable string that represents this [SizeD](SizeD.md 'Portal.SizeD'). |
| [ToVector2()](SizeD.ToVector2().md 'Portal.SizeD.ToVector2()') | Creates a new [System.Numerics.Vector2](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.Vector2 'System.Numerics.Vector2') from this [SizeD](SizeD.md 'Portal.SizeD'). |

| Operators | |
| :--- | :--- |
| [operator +(SizeD, SizeD)](SizeD.operator+(SizeD,SizeD).md 'Portal.SizeD.op_Addition(Portal.SizeD, Portal.SizeD)') | Performs vector addition of two [SizeD](SizeD.md 'Portal.SizeD') objects. |
| [operator /(SizeD, double)](SizeD.operator/(SizeD,double).md 'Portal.SizeD.op_Division(Portal.SizeD, double)') | Divides [SizeD](SizeD.md 'Portal.SizeD') by a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') producing [SizeD](SizeD.md 'Portal.SizeD'). |
| [operator ==(SizeD, SizeD)](SizeD.operator(SizeD,SizeD).md 'Portal.SizeD.op_Equality(Portal.SizeD, Portal.SizeD)') | Tests whether two [SizeD](SizeD.md 'Portal.SizeD') objects are identical. |
| [explicit operator PointD(SizeD)](SizeD.explicitoperatorPointD(SizeD).md 'Portal.SizeD.op_Explicit Portal.PointD(Portal.SizeD)') | Converts the specified [SizeD](SizeD.md 'Portal.SizeD') to a [PointD](PointD.md 'Portal.PointD'). |
| [explicit operator SizeD(Vector2)](SizeD.explicitoperatorSizeD(Vector2).md 'Portal.SizeD.op_Explicit Portal.SizeD(System.Numerics.Vector2)') | Converts the specified [System.Numerics.Vector2](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.Vector2 'System.Numerics.Vector2') to a [SizeD](SizeD.md 'Portal.SizeD'). |
| [explicit operator Vector2(SizeD)](SizeD.explicitoperatorVector2(SizeD).md 'Portal.SizeD.op_Explicit System.Numerics.Vector2(Portal.SizeD)') | Converts the specified [SizeD](SizeD.md 'Portal.SizeD') to a [System.Numerics.Vector2](https://docs.microsoft.com/en-us/dotnet/api/System.Numerics.Vector2 'System.Numerics.Vector2'). |
| [operator !=(SizeD, SizeD)](SizeD.operator!(SizeD,SizeD).md 'Portal.SizeD.op_Inequality(Portal.SizeD, Portal.SizeD)') | Tests whether two [SizeD](SizeD.md 'Portal.SizeD') objects are different. |
| [operator *(double, SizeD)](SizeD.operator_(double,SizeD).md 'Portal.SizeD.op_Multiply(double, Portal.SizeD)') | Multiplies [SizeD](SizeD.md 'Portal.SizeD') by a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') producing [SizeD](SizeD.md 'Portal.SizeD'). |
| [operator *(SizeD, double)](SizeD.operator_(SizeD,double).md 'Portal.SizeD.op_Multiply(Portal.SizeD, double)') | Multiplies [SizeD](SizeD.md 'Portal.SizeD') by a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') producing [SizeD](SizeD.md 'Portal.SizeD'). |
| [operator -(SizeD, SizeD)](SizeD.operator-(SizeD,SizeD).md 'Portal.SizeD.op_Subtraction(Portal.SizeD, Portal.SizeD)') | Contracts a [SizeD](SizeD.md 'Portal.SizeD') by another [SizeD](SizeD.md 'Portal.SizeD') |
