#### [Portal](index.md 'index')
### [Portal.Script](Portal.Script.md 'Portal.Script')

## ScriptCallables Class

Most script callabes are defined here.  
Should be used in scripts, to perform various actions.

```csharp
public static class ScriptCallables
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ScriptCallables

| Properties | |
| :--- | :--- |
| [RandGen](ScriptCallables.RandGen.md 'Portal.Script.ScriptCallables.RandGen') | Is idle mouse moving? |

| Methods | |
| :--- | :--- |
| [FindMatch(string, SearchOptions, RepeatOptions, Action, bool)](ScriptCallables.FindMatch(string,SearchOptions,RepeatOptions,Action,bool).md 'Portal.Script.ScriptCallables.FindMatch(string, Portal.Detect.SearchOptions, Portal.Detect.RepeatOptions, System.Action, bool)') | Tries to find best match with specified template, with an optional action called when not found, synchronously. |
| [FindMatch(List&lt;string&gt;, SearchOptions, RepeatOptions, Action, bool)](ScriptCallables.FindMatch(List_string_,SearchOptions,RepeatOptions,Action,bool).md 'Portal.Script.ScriptCallables.FindMatch(System.Collections.Generic.List<string>, Portal.Detect.SearchOptions, Portal.Detect.RepeatOptions, System.Action, bool)') | Tries to find best match with specified templates, with an optional action called when not found, synchronously. |
| [FindMatchAsync(string, SearchOptions, RepeatOptions, Action, bool)](ScriptCallables.FindMatchAsync(string,SearchOptions,RepeatOptions,Action,bool).md 'Portal.Script.ScriptCallables.FindMatchAsync(string, Portal.Detect.SearchOptions, Portal.Detect.RepeatOptions, System.Action, bool)') | Tries to find best match with specified template, with an optional action called when not found, asynchronously. |
| [FindMatchAsync(List&lt;string&gt;, SearchOptions, RepeatOptions, Action, bool)](ScriptCallables.FindMatchAsync(List_string_,SearchOptions,RepeatOptions,Action,bool).md 'Portal.Script.ScriptCallables.FindMatchAsync(System.Collections.Generic.List<string>, Portal.Detect.SearchOptions, Portal.Detect.RepeatOptions, System.Action, bool)') | Tries to find best match with specified templates, with an optional action called when not found, asynchronously. |
| [FindMatches(string, SearchOptions, RepeatOptions, Action, bool)](ScriptCallables.FindMatches(string,SearchOptions,RepeatOptions,Action,bool).md 'Portal.Script.ScriptCallables.FindMatches(string, Portal.Detect.SearchOptions, Portal.Detect.RepeatOptions, System.Action, bool)') | Tries to find all matches with specified template, with an optional action called when not found, synchronously. |
| [FindMatches(List&lt;string&gt;, SearchOptions, RepeatOptions, Action, bool)](ScriptCallables.FindMatches(List_string_,SearchOptions,RepeatOptions,Action,bool).md 'Portal.Script.ScriptCallables.FindMatches(System.Collections.Generic.List<string>, Portal.Detect.SearchOptions, Portal.Detect.RepeatOptions, System.Action, bool)') | Tries to find all matches with specified templates, with an optional action called when not found, synchronously. |
| [FindMatchesAsync(string, SearchOptions, RepeatOptions, Action, bool)](ScriptCallables.FindMatchesAsync(string,SearchOptions,RepeatOptions,Action,bool).md 'Portal.Script.ScriptCallables.FindMatchesAsync(string, Portal.Detect.SearchOptions, Portal.Detect.RepeatOptions, System.Action, bool)') | Tries to find all matches with specified template, with an optional action called when not found, asynchronously. |
| [FindMatchesAsync(List&lt;string&gt;, SearchOptions, RepeatOptions, Action, bool)](ScriptCallables.FindMatchesAsync(List_string_,SearchOptions,RepeatOptions,Action,bool).md 'Portal.Script.ScriptCallables.FindMatchesAsync(System.Collections.Generic.List<string>, Portal.Detect.SearchOptions, Portal.Detect.RepeatOptions, System.Action, bool)') | Tries to find all matches with specified templates, with an optional action called when not found, asynchronously. |
| [RepeatAction(Action, RepeatOptions, bool)](ScriptCallables.RepeatAction(Action,RepeatOptions,bool).md 'Portal.Script.ScriptCallables.RepeatAction(System.Action, Portal.Detect.RepeatOptions, bool)') | Repeats specified action, for a specified amount of loops. |
| [RepeatUntil&lt;T&gt;(Func&lt;T&gt;, Predicate&lt;T&gt;, RepeatOptions, bool)](ScriptCallables.RepeatUntil_T_(Func_T_,Predicate_T_,RepeatOptions,bool).md 'Portal.Script.ScriptCallables.RepeatUntil<T>(System.Func<T>, System.Predicate<T>, Portal.Detect.RepeatOptions, bool)') | Repeats specified action, for a specified amount of loops, until predicate is true. |
| [ShowLatestFrame(int)](ScriptCallables.ShowLatestFrame(int).md 'Portal.Script.ScriptCallables.ShowLatestFrame(int)') | Shows the latest captured frame.<br/>Useful for debugging. |
| [Wait(int, bool)](ScriptCallables.Wait(int,bool).md 'Portal.Script.ScriptCallables.Wait(int, bool)') | Waits for a specified number of milliseconds. |
| [WaitAsync(int, Nullable&lt;CancellationToken&gt;, bool)](ScriptCallables.WaitAsync(int,Nullable_CancellationToken_,bool).md 'Portal.Script.ScriptCallables.WaitAsync(int, System.Nullable<System.Threading.CancellationToken>, bool)') | Waits for a specified number of milliseconds. |
| [WaitRandom(int, int, bool)](ScriptCallables.WaitRandom(int,int,bool).md 'Portal.Script.ScriptCallables.WaitRandom(int, int, bool)') | Waits for a random number of milliseconds within specified range. |
| [WaitRandomAsync(int, int, Nullable&lt;CancellationToken&gt;, bool)](ScriptCallables.WaitRandomAsync(int,int,Nullable_CancellationToken_,bool).md 'Portal.Script.ScriptCallables.WaitRandomAsync(int, int, System.Nullable<System.Threading.CancellationToken>, bool)') | Waits for a random number of milliseconds within specified range. |
