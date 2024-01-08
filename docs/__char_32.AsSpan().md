#### [Portal](index.md 'index')
### [Windows.Win32](Windows.Win32.md 'Windows.Win32').[__char_32](__char_32.md 'Windows.Win32.__char_32')

## __char_32.AsSpan() Method

Gets this inline array as a span.

```csharp
internal System.Span<char> AsSpan();
```

#### Returns
[System.Span&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1')[System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1')

### Remarks
⚠ Important ⚠: When this struct is on the stack, do not let the returned span outlive the stack frame that defines it.