#### [Portal](index.md 'index')
### [Portal.Script](Portal.Script.md 'Portal.Script')

## ScriptWorker Class

Base class for script workers.

```csharp
public abstract class ScriptWorker
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ScriptWorker

Derived  
&#8627; [MainScriptWorker](MainScriptWorker.md 'Portal.Script.Workers.MainScriptWorker')

| Properties | |
| :--- | :--- |
| [bIsPaused](ScriptWorker.bIsPaused.md 'Portal.Script.ScriptWorker.bIsPaused') | If true, worker is paused. |
| [bIsWorking](ScriptWorker.bIsWorking.md 'Portal.Script.ScriptWorker.bIsWorking') | If true, worker is running. |
| [bRequireScriptRunning](ScriptWorker.bRequireScriptRunning.md 'Portal.Script.ScriptWorker.bRequireScriptRunning') | If true, worker can only be started when script is running. |
| [bStartPaused](ScriptWorker.bStartPaused.md 'Portal.Script.ScriptWorker.bStartPaused') | If true, worker will start paused. |
| [Cancellation](ScriptWorker.Cancellation.md 'Portal.Script.ScriptWorker.Cancellation') | Cancellation token source for worker. |
| [CancelToken](ScriptWorker.CancelToken.md 'Portal.Script.ScriptWorker.CancelToken') | Cancellation token for worker. |
| [TickInterval](ScriptWorker.TickInterval.md 'Portal.Script.ScriptWorker.TickInterval') | Interval between ticks in milliseconds. |
| [WorkerTask](ScriptWorker.WorkerTask.md 'Portal.Script.ScriptWorker.WorkerTask') | Task that runs worker. |

| Methods | |
| :--- | :--- |
| [OnPause()](ScriptWorker.OnPause().md 'Portal.Script.ScriptWorker.OnPause()') | Called when worker is paused. |
| [OnStart()](ScriptWorker.OnStart().md 'Portal.Script.ScriptWorker.OnStart()') | Called when worker is started. |
| [OnStop()](ScriptWorker.OnStop().md 'Portal.Script.ScriptWorker.OnStop()') | Called when worker is stopped. |
| [OnTick()](ScriptWorker.OnTick().md 'Portal.Script.ScriptWorker.OnTick()') | Called when worker ticks. |
| [OnUnpause()](ScriptWorker.OnUnpause().md 'Portal.Script.ScriptWorker.OnUnpause()') | Called when worker is unpaused. |
| [Pause()](ScriptWorker.Pause().md 'Portal.Script.ScriptWorker.Pause()') | Pauses worker.<br/>Worker will not tick while paused. |
| [Start()](ScriptWorker.Start().md 'Portal.Script.ScriptWorker.Start()') | Starts new script worker.<br/>A script worker is a task that runs on a separate thread, and can be paused and unpaused. |
| [Stop()](ScriptWorker.Stop().md 'Portal.Script.ScriptWorker.Stop()') | Stops worker. |
| [Unpause()](ScriptWorker.Unpause().md 'Portal.Script.ScriptWorker.Unpause()') | Unpauses worker.<br/>Worker will tick while unpaused. |
