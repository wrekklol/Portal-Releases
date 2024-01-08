#### [Portal](index.md 'index')
### [Portal.Script](Portal.Script.md 'Portal.Script').[ScriptCallables](ScriptCallables.md 'Portal.Script.ScriptCallables')

## ScriptCallables.FindMatches(string, SearchOptions, RepeatOptions, Action, bool) Method

Tries to find all matches with specified template, with an optional action called when not found, synchronously.

```csharp
public static System.Collections.Generic.List<Portal.Detect.Match>? FindMatches(string InTemplateName, Portal.Detect.SearchOptions? InSearchOptions=null, Portal.Detect.RepeatOptions? InRepeatOptions=null, System.Action? InOnNotFound=null, bool InbShouldPrint=true);
```
#### Parameters

<a name='Portal.Script.ScriptCallables.FindMatches(string,Portal.Detect.SearchOptions,Portal.Detect.RepeatOptions,System.Action,bool).InTemplateName'></a>

`InTemplateName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Name of the template.

<a name='Portal.Script.ScriptCallables.FindMatches(string,Portal.Detect.SearchOptions,Portal.Detect.RepeatOptions,System.Action,bool).InSearchOptions'></a>

`InSearchOptions` [SearchOptions](SearchOptions.md 'Portal.Detect.SearchOptions')

Options for searching.

<a name='Portal.Script.ScriptCallables.FindMatches(string,Portal.Detect.SearchOptions,Portal.Detect.RepeatOptions,System.Action,bool).InRepeatOptions'></a>

`InRepeatOptions` [RepeatOptions](RepeatOptions.md 'Portal.Detect.RepeatOptions')

Options for repeating.

<a name='Portal.Script.ScriptCallables.FindMatches(string,Portal.Detect.SearchOptions,Portal.Detect.RepeatOptions,System.Action,bool).InOnNotFound'></a>

`InOnNotFound` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Action to call when not found.

<a name='Portal.Script.ScriptCallables.FindMatches(string,Portal.Detect.SearchOptions,Portal.Detect.RepeatOptions,System.Action,bool).InbShouldPrint'></a>

`InbShouldPrint` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Whether to print.

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Match](Match.md 'Portal.Detect.Match')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
Returns all matches found.