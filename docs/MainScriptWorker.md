#### [Portal](index.md 'index')
### [Portal.Script.Workers](Portal.Script.Workers.md 'Portal.Script.Workers')

## MainScriptWorker Class

Main script worker, this is the worker that runs scripts.

```csharp
public sealed class MainScriptWorker : Portal.Script.ScriptWorker
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [ScriptWorker](ScriptWorker.md 'Portal.Script.ScriptWorker') &#129106; MainScriptWorker

| Properties | |
| :--- | :--- |
| [bRequireScriptRunning](MainScriptWorker.bRequireScriptRunning.md 'Portal.Script.Workers.MainScriptWorker.bRequireScriptRunning') | If true, worker can only be started when script is running. |
| [LoopedAmount](MainScriptWorker.LoopedAmount.md 'Portal.Script.Workers.MainScriptWorker.LoopedAmount') | Amount of times the script has looped. |
| [RunningBehavior](MainScriptWorker.RunningBehavior.md 'Portal.Script.Workers.MainScriptWorker.RunningBehavior') | The behavior that is currently running. |
| [TickInterval](MainScriptWorker.TickInterval.md 'Portal.Script.Workers.MainScriptWorker.TickInterval') | Interval between ticks in milliseconds. |

| Methods | |
| :--- | :--- |
| [OnStart()](MainScriptWorker.OnStart().md 'Portal.Script.Workers.MainScriptWorker.OnStart()') | Called when worker is started. |
| [OnStop()](MainScriptWorker.OnStop().md 'Portal.Script.Workers.MainScriptWorker.OnStop()') | Called when worker is stopped. |
| [OnTick()](MainScriptWorker.OnTick().md 'Portal.Script.Workers.MainScriptWorker.OnTick()') | Called when worker ticks. |
