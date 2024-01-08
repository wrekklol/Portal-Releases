#### [Portal](index.md 'index')
### [Portal.Script](Portal.Script.md 'Portal.Script').[ScriptCallables](ScriptCallables.md 'Portal.Script.ScriptCallables')

## ScriptCallables.WaitAsync(int, Nullable<CancellationToken>, bool) Method

Waits for a specified number of milliseconds.

```csharp
public static System.Threading.Tasks.Task WaitAsync(int InMilliseconds, System.Nullable<System.Threading.CancellationToken> InToken=null, bool InbShouldPrint=false);
```
#### Parameters

<a name='Portal.Script.ScriptCallables.WaitAsync(int,System.Nullable_System.Threading.CancellationToken_,bool).InMilliseconds'></a>

`InMilliseconds` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Number of milliseconds to wait.

<a name='Portal.Script.ScriptCallables.WaitAsync(int,System.Nullable_System.Threading.CancellationToken_,bool).InToken'></a>

`InToken` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

Cancellation token.

<a name='Portal.Script.ScriptCallables.WaitAsync(int,System.Nullable_System.Threading.CancellationToken_,bool).InbShouldPrint'></a>

`InbShouldPrint` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')