#### [Portal](index.md 'index')
### [Portal.Script](Portal.Script.md 'Portal.Script').[ScriptCallables](ScriptCallables.md 'Portal.Script.ScriptCallables')

## ScriptCallables.WaitRandomAsync(int, int, Nullable<CancellationToken>, bool) Method

Waits for a random number of milliseconds within specified range.

```csharp
public static System.Threading.Tasks.Task WaitRandomAsync(int InMinMilliseconds, int InMaxMilliseconds, System.Nullable<System.Threading.CancellationToken> InToken=null, bool InbShouldPrint=false);
```
#### Parameters

<a name='Portal.Script.ScriptCallables.WaitRandomAsync(int,int,System.Nullable_System.Threading.CancellationToken_,bool).InMinMilliseconds'></a>

`InMinMilliseconds` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Minimum number of milliseconds to wait.

<a name='Portal.Script.ScriptCallables.WaitRandomAsync(int,int,System.Nullable_System.Threading.CancellationToken_,bool).InMaxMilliseconds'></a>

`InMaxMilliseconds` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Maximum number of milliseconds to wait.

<a name='Portal.Script.ScriptCallables.WaitRandomAsync(int,int,System.Nullable_System.Threading.CancellationToken_,bool).InToken'></a>

`InToken` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

Cancellation token.

<a name='Portal.Script.ScriptCallables.WaitRandomAsync(int,int,System.Nullable_System.Threading.CancellationToken_,bool).InbShouldPrint'></a>

`InbShouldPrint` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Whether to print.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')