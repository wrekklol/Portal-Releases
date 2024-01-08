#### [Portal](index.md 'index')
### [Portal.Utility](Portal.Utility.md 'Portal.Utility').[AssertHelpers](AssertHelpers.md 'Portal.Utility.AssertHelpers')

## AssertHelpers.Ensure<T>(this T, Predicate<T>, string, PrintOptions) Method

Checks if specified predicate with specified object is true.  
If false, throws.

```csharp
public static void Ensure<T>(this T? InObject, System.Predicate<T?> InPred, string? InMessage=null, Portal.Printing.PrintOptions? InOptions=null);
```
#### Type parameters

<a name='Portal.Utility.AssertHelpers.Ensure_T_(thisT,System.Predicate_T_,string,Portal.Printing.PrintOptions).T'></a>

`T`
#### Parameters

<a name='Portal.Utility.AssertHelpers.Ensure_T_(thisT,System.Predicate_T_,string,Portal.Printing.PrintOptions).InObject'></a>

`InObject` [T](AssertHelpers.Ensure_T_(thisT,Predicate_T_,string,PrintOptions).md#Portal.Utility.AssertHelpers.Ensure_T_(thisT,System.Predicate_T_,string,Portal.Printing.PrintOptions).T 'Portal.Utility.AssertHelpers.Ensure<T>(this T, System.Predicate<T>, string, Portal.Printing.PrintOptions).T')

Object to call predicate with.

<a name='Portal.Utility.AssertHelpers.Ensure_T_(thisT,System.Predicate_T_,string,Portal.Printing.PrintOptions).InPred'></a>

`InPred` [System.Predicate&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')[T](AssertHelpers.Ensure_T_(thisT,Predicate_T_,string,PrintOptions).md#Portal.Utility.AssertHelpers.Ensure_T_(thisT,System.Predicate_T_,string,Portal.Printing.PrintOptions).T 'Portal.Utility.AssertHelpers.Ensure<T>(this T, System.Predicate<T>, string, Portal.Printing.PrintOptions).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')

Predicate to ensure is true.

<a name='Portal.Utility.AssertHelpers.Ensure_T_(thisT,System.Predicate_T_,string,Portal.Printing.PrintOptions).InMessage'></a>

`InMessage` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Portal.Utility.AssertHelpers.Ensure_T_(thisT,System.Predicate_T_,string,Portal.Printing.PrintOptions).InOptions'></a>

`InOptions` [PrintOptions](PrintOptions.md 'Portal.Printing.PrintOptions')