#### [Portal](index.md 'index')
### [Portal.Printing](Portal.Printing.md 'Portal.Printing')

## PrintManager Class

Print manager, handles printing to the console and log file.

```csharp
public sealed class PrintManager : Portal.Singleton<Portal.Printing.PrintManager>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Portal.Singleton&lt;](https://docs.microsoft.com/en-us/dotnet/api/Portal.Singleton-1 'Portal.Singleton`1')[PrintManager](PrintManager.md 'Portal.Printing.PrintManager')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Portal.Singleton-1 'Portal.Singleton`1') &#129106; PrintManager

| Methods | |
| :--- | :--- |
| [Print(object, PrintOptions)](PrintManager.Print(object,PrintOptions).md 'Portal.Printing.PrintManager.Print(object, Portal.Printing.PrintOptions)') | Prints a message to the console, with a vital info type and white color. |
| [PrintAction(object, PrintOptions)](PrintManager.PrintAction(object,PrintOptions).md 'Portal.Printing.PrintManager.PrintAction(object, Portal.Printing.PrintOptions)') | Prints a message to the console, with an info type and action prefix and cornflower blue color. |
| [PrintEmptyLine()](PrintManager.PrintEmptyLine().md 'Portal.Printing.PrintManager.PrintEmptyLine()') | Prints an empty line to the console. |
| [PrintError(object, PrintOptions)](PrintManager.PrintError(object,PrintOptions).md 'Portal.Printing.PrintManager.PrintError(object, Portal.Printing.PrintOptions)') | Prints a message to the console, with an error type and prefix and red color. |
| [PrintException(Exception)](PrintManager.PrintException(Exception).md 'Portal.Printing.PrintManager.PrintException(System.Exception)') | Prints an exception to the console. |
| [PrintMinor(object, PrintOptions)](PrintManager.PrintMinor(object,PrintOptions).md 'Portal.Printing.PrintManager.PrintMinor(object, Portal.Printing.PrintOptions)') | Prints a message to the console, with a minor info type and gray color. |
| [PrintResult(object, PrintOptions)](PrintManager.PrintResult(object,PrintOptions).md 'Portal.Printing.PrintManager.PrintResult(object, Portal.Printing.PrintOptions)') | Prints a message to the console, with an info type and result prefix and lime green color. |
| [PrintResultFail(object, PrintOptions)](PrintManager.PrintResultFail(object,PrintOptions).md 'Portal.Printing.PrintManager.PrintResultFail(object, Portal.Printing.PrintOptions)') | Prints a message to the console, with a vital info type and result prefix and red color. |
| [PrintWarning(object, PrintOptions)](PrintManager.PrintWarning(object,PrintOptions).md 'Portal.Printing.PrintManager.PrintWarning(object, Portal.Printing.PrintOptions)') | Prints a message to the console, with a warning type and prefix and yellow color. |
