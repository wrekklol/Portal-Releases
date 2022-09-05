#### [Portal](index.md 'index')
### [Portal.Utility](Portal.Utility.md 'Portal.Utility')

## ScriptHelpers Class

Functions to make scripting less tedious.

```csharp
public static class ScriptHelpers
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ScriptHelpers

| Methods | |
| :--- | :--- |
| [DoUntilFound(string, Action, Nullable&lt;SearchOptions&gt;, Nullable&lt;RepeatOptions&gt;)](ScriptHelpers.DoUntilFound(string,Action,Nullable_SearchOptions_,Nullable_RepeatOptions_).md 'Portal.Utility.ScriptHelpers.DoUntilFound(string, System.Action, System.Nullable<Portal.ImageDetection.SearchOptions>, System.Nullable<Portal.ImageDetection.RepeatOptions>)') | Repeatedly executes the given action until the template is found, synchronously. |
| [DoUntilFound_Async(string, Action, Nullable&lt;SearchOptions&gt;, Nullable&lt;RepeatOptions&gt;)](ScriptHelpers.DoUntilFound_Async(string,Action,Nullable_SearchOptions_,Nullable_RepeatOptions_).md 'Portal.Utility.ScriptHelpers.DoUntilFound_Async(string, System.Action, System.Nullable<Portal.ImageDetection.SearchOptions>, System.Nullable<Portal.ImageDetection.RepeatOptions>)') | Repeatedly executes the given action until the template is found, asynchronously. |
| [DoUntilFoundMulti(string, Action, Nullable&lt;SearchOptions&gt;, Nullable&lt;RepeatOptions&gt;)](ScriptHelpers.DoUntilFoundMulti(string,Action,Nullable_SearchOptions_,Nullable_RepeatOptions_).md 'Portal.Utility.ScriptHelpers.DoUntilFoundMulti(string, System.Action, System.Nullable<Portal.ImageDetection.SearchOptions>, System.Nullable<Portal.ImageDetection.RepeatOptions>)') | Repeatedly executes the given action until the template is found, synchronously. |
| [DoUntilFoundMulti_Async(string, Action, Nullable&lt;SearchOptions&gt;, Nullable&lt;RepeatOptions&gt;)](ScriptHelpers.DoUntilFoundMulti_Async(string,Action,Nullable_SearchOptions_,Nullable_RepeatOptions_).md 'Portal.Utility.ScriptHelpers.DoUntilFoundMulti_Async(string, System.Action, System.Nullable<Portal.ImageDetection.SearchOptions>, System.Nullable<Portal.ImageDetection.RepeatOptions>)') | Repeatedly executes the given action until the template is found, asynchronously. |
| [DoUntilPredicate(string, Action, Predicate&lt;Match&gt;, Nullable&lt;SearchOptions&gt;, Nullable&lt;RepeatOptions&gt;)](ScriptHelpers.DoUntilPredicate(string,Action,Predicate_Match_,Nullable_SearchOptions_,Nullable_RepeatOptions_).md 'Portal.Utility.ScriptHelpers.DoUntilPredicate(string, System.Action, System.Predicate<Portal.ImageDetection.Match>, System.Nullable<Portal.ImageDetection.SearchOptions>, System.Nullable<Portal.ImageDetection.RepeatOptions>)') | Repeatedly executes the given action until the specified predicate is true, synchronously. |
| [DoUntilPredicate_Async(string, Action, Predicate&lt;Match&gt;, Nullable&lt;SearchOptions&gt;, Nullable&lt;RepeatOptions&gt;)](ScriptHelpers.DoUntilPredicate_Async(string,Action,Predicate_Match_,Nullable_SearchOptions_,Nullable_RepeatOptions_).md 'Portal.Utility.ScriptHelpers.DoUntilPredicate_Async(string, System.Action, System.Predicate<Portal.ImageDetection.Match>, System.Nullable<Portal.ImageDetection.SearchOptions>, System.Nullable<Portal.ImageDetection.RepeatOptions>)') | Repeatedly executes the given action until the specified predicate is true, asynchronously. |
| [DoUntilPredicateMulti(string, Action, Predicate&lt;List&lt;Match&gt;&gt;, Nullable&lt;SearchOptions&gt;, Nullable&lt;RepeatOptions&gt;)](ScriptHelpers.DoUntilPredicateMulti(string,Action,Predicate_List_Match__,Nullable_SearchOptions_,Nullable_RepeatOptions_).md 'Portal.Utility.ScriptHelpers.DoUntilPredicateMulti(string, System.Action, System.Predicate<System.Collections.Generic.List<Portal.ImageDetection.Match>>, System.Nullable<Portal.ImageDetection.SearchOptions>, System.Nullable<Portal.ImageDetection.RepeatOptions>)') | Repeatedly executes the given action until the specified predicate is true, synchronously. |
| [DoUntilPredicateMulti_Async(string, Action, Predicate&lt;List&lt;Match&gt;&gt;, Nullable&lt;SearchOptions&gt;, Nullable&lt;RepeatOptions&gt;)](ScriptHelpers.DoUntilPredicateMulti_Async(string,Action,Predicate_List_Match__,Nullable_SearchOptions_,Nullable_RepeatOptions_).md 'Portal.Utility.ScriptHelpers.DoUntilPredicateMulti_Async(string, System.Action, System.Predicate<System.Collections.Generic.List<Portal.ImageDetection.Match>>, System.Nullable<Portal.ImageDetection.SearchOptions>, System.Nullable<Portal.ImageDetection.RepeatOptions>)') | Repeatedly executes the given action until the specified predicate is true, asynchronously. |
| [Wait(int)](ScriptHelpers.Wait(int).md 'Portal.Utility.ScriptHelpers.Wait(int)') | Waits for a specified number of milliseconds. |
| [WaitUntilFound(string, Nullable&lt;SearchOptions&gt;, Nullable&lt;RepeatOptions&gt;)](ScriptHelpers.WaitUntilFound(string,Nullable_SearchOptions_,Nullable_RepeatOptions_).md 'Portal.Utility.ScriptHelpers.WaitUntilFound(string, System.Nullable<Portal.ImageDetection.SearchOptions>, System.Nullable<Portal.ImageDetection.RepeatOptions>)') | Waits until the template is found. |
| [WaitUntilFoundMulti(string, Nullable&lt;SearchOptions&gt;, Nullable&lt;RepeatOptions&gt;)](ScriptHelpers.WaitUntilFoundMulti(string,Nullable_SearchOptions_,Nullable_RepeatOptions_).md 'Portal.Utility.ScriptHelpers.WaitUntilFoundMulti(string, System.Nullable<Portal.ImageDetection.SearchOptions>, System.Nullable<Portal.ImageDetection.RepeatOptions>)') | Waits until the template is found. |
| [WaitUntilPredicate(string, Predicate&lt;Match&gt;, Nullable&lt;SearchOptions&gt;, Nullable&lt;RepeatOptions&gt;)](ScriptHelpers.WaitUntilPredicate(string,Predicate_Match_,Nullable_SearchOptions_,Nullable_RepeatOptions_).md 'Portal.Utility.ScriptHelpers.WaitUntilPredicate(string, System.Predicate<Portal.ImageDetection.Match>, System.Nullable<Portal.ImageDetection.SearchOptions>, System.Nullable<Portal.ImageDetection.RepeatOptions>)') | Waits until the specified predicate is true. |
| [WaitUntilPredicateMulti(string, Predicate&lt;List&lt;Match&gt;&gt;, Nullable&lt;SearchOptions&gt;, Nullable&lt;RepeatOptions&gt;)](ScriptHelpers.WaitUntilPredicateMulti(string,Predicate_List_Match__,Nullable_SearchOptions_,Nullable_RepeatOptions_).md 'Portal.Utility.ScriptHelpers.WaitUntilPredicateMulti(string, System.Predicate<System.Collections.Generic.List<Portal.ImageDetection.Match>>, System.Nullable<Portal.ImageDetection.SearchOptions>, System.Nullable<Portal.ImageDetection.RepeatOptions>)') | Waits until the specified predicate is true. |