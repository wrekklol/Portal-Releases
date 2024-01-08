#### [Portal](index.md 'index')
### [Windows.Win32](Windows.Win32.md 'Windows.Win32').[__char_32](__char_32.md 'Windows.Win32.__char_32')

## __char_32.AsReadOnlySpan() Method

Gets this inline array as a span.

```csharp
internal readonly System.ReadOnlySpan<char> AsReadOnlySpan();
```

#### Returns
[System.ReadOnlySpan&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')[System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')

### Remarks
⚠ Important ⚠: When this struct is on the stack, do not let the returned span outlive the stack frame that defines it.