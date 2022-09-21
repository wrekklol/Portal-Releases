#### [Portal](index.md 'index')
### [Portal.Input](Portal.Input.md 'Portal.Input').[InputOptions](InputOptions.md 'Portal.Input.InputOptions')

## InputOptions.implicit operator InputOptions(string) Operator

Cast operator.   
           Allows you to cast an input binding string to input options.

```csharp
public static Portal.Input.InputOptions implicit operator InputOptions(string InKeybindString);
```
#### Parameters

<a name='Portal.Input.InputOptions.op_ImplicitPortal.Input.InputOptions(string).InKeybindString'></a>

`InKeybindString` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

#### Returns
[InputOptions](InputOptions.md 'Portal.Input.InputOptions')

### Example
Example of how to create input options from a string:  
  
```csharp  
InputOptions MyOptions = "c+d+u+c+rd100+pd50+rm1";  
```  
Which translates to:  
  
```csharp  
InputOptions MyOptions = new(EKeys.C, EKeyState.Down | EKeyState.Up, EKeyModifiers.Control, 100, 50, true);  
```

### Remarks
Order of string "arguments" is irrelevant except for the key, which has to be at the start.  
It is case insensitive as well, so typing "DOWN" or "down" is the same.  
  
Valid values are:  
Key codes from [EKeys](EKeys.md 'Portal.Input.EKeys') enum  
"down" or "d"  
"up" or "u"  
"control" or "c"  
"alt" or "a"  
"shift" or "s"  
"pressdelay" or "pdelay" or "pd", with an integer like "pd50"  
"releasedelay" or "rdelay" or "rd", with an integer like "rd50"  
"autoreleasemodifiers" or "relmods" or "rm", with an (boolean)integer like "rm1"  
"data", with an unsigned integer like "data1"