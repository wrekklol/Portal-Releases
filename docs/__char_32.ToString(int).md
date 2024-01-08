#### [Portal](index.md 'index')
### [Windows.Win32](Windows.Win32.md 'Windows.Win32').[__char_32](__char_32.md 'Windows.Win32.__char_32')

## __char_32.ToString(int) Method

Copies the fixed array to a new string up to the specified length regardless of whether there are null terminating characters.

```csharp
internal readonly string ToString(int length);
```
#### Parameters

<a name='Windows.Win32.__char_32.ToString(int).length'></a>

`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

#### Exceptions

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
Thrown when [length](__char_32.ToString(int).md#Windows.Win32.__char_32.ToString(int).length 'Windows.Win32.__char_32.ToString(int).length') is less than `0` or greater than [Length](__char_32.Length.md 'Windows.Win32.__char_32.Length').