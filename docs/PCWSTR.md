#### [Portal](index.md 'index')
### [Windows.Win32.Foundation](Windows.Win32.Foundation.md 'Windows.Win32.Foundation')

## PCWSTR Struct

A pointer to a null-terminated, constant character string.

```csharp
internal readonly struct PCWSTR :
System.IEquatable<Windows.Win32.Foundation.PCWSTR>
```

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[PCWSTR](PCWSTR.md 'Windows.Win32.Foundation.PCWSTR')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Fields | |
| :--- | :--- |
| [Value](PCWSTR.Value.md 'Windows.Win32.Foundation.PCWSTR.Value') | A pointer to the first character in the string. The content should be considered readonly, as it was typed as constant in the SDK. |

| Properties | |
| :--- | :--- |
| [Length](PCWSTR.Length.md 'Windows.Win32.Foundation.PCWSTR.Length') | Gets the number of characters up to the first null character (exclusive). |

| Methods | |
| :--- | :--- |
| [AsSpan()](PCWSTR.AsSpan().md 'Windows.Win32.Foundation.PCWSTR.AsSpan()') | Returns a span of the characters in this string, up to the first null character (exclusive). |
| [ToString()](PCWSTR.ToString().md 'Windows.Win32.Foundation.PCWSTR.ToString()') | Returns a [string](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/string 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/string') with a copy of this character array, up to the first null character (exclusive). |
