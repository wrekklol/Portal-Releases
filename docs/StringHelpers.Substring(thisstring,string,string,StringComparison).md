#### [Portal](index.md 'index')
### [Portal.Utility](Portal.Utility.md 'Portal.Utility').[StringHelpers](StringHelpers.md 'Portal.Utility.StringHelpers')

## StringHelpers.Substring(this string, string, string, StringComparison) Method

Returns a substring of the current string, starting from the first occurrence of the specified from string, and ending at the first occurrence of the specified until string, or at the end of the string if the specified string is not found.

```csharp
public static string Substring(this string InSourceString, string? InFrom=null, string? InUntil=null, System.StringComparison InComparison=System.StringComparison.InvariantCulture);
```
#### Parameters

<a name='Portal.Utility.StringHelpers.Substring(thisstring,string,string,System.StringComparison).InSourceString'></a>

`InSourceString` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The string to search in.

<a name='Portal.Utility.StringHelpers.Substring(thisstring,string,string,System.StringComparison).InFrom'></a>

`InFrom` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The string to search from.

<a name='Portal.Utility.StringHelpers.Substring(thisstring,string,string,System.StringComparison).InUntil'></a>

`InUntil` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The string to search for as the end of the substring.

<a name='Portal.Utility.StringHelpers.Substring(thisstring,string,string,System.StringComparison).InComparison'></a>

`InComparison` [System.StringComparison](https://docs.microsoft.com/en-us/dotnet/api/System.StringComparison 'System.StringComparison')

The type of comparison to perform when searching for the specified string.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')