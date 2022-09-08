#### [Portal](index.md 'index')
### [Portal.Detection](Portal.Detection.md 'Portal.Detection')

## RepeatOptions Struct

Repeat options for image detection.

```csharp
public struct RepeatOptions
```

### Example
Usage:  
  
```csharp  
RepeatOptions MyRepeatOptions = new(100, 50);  
```  
Default values can also be used.  
Example:  
  
```csharp  
RepeatOptions MyRepeatOptions = RepeatOptions.Default; // Translates to new(1, 0);  
RepeatOptions MyRepeatOptions = RepeatOptions.LowDelay; // Translates to new(3, 50);  
RepeatOptions MyRepeatOptions = RepeatOptions.HighDelay; // Translates to new(3, 250);  
```

| Constructors | |
| :--- | :--- |
| [RepeatOptions(int, int)](RepeatOptions.RepeatOptions(int,int).md 'Portal.Detection.RepeatOptions.RepeatOptions(int, int)') | RepeatOptions constructor. |

| Properties | |
| :--- | :--- |
| [DelayBetweenSearches](RepeatOptions.DelayBetweenSearches.md 'Portal.Detection.RepeatOptions.DelayBetweenSearches') | Delay between each try. |
| [MaxTries](RepeatOptions.MaxTries.md 'Portal.Detection.RepeatOptions.MaxTries') | Maximum amount of tries. |

| Methods | |
| :--- | :--- |
| [ToString()](RepeatOptions.ToString().md 'Portal.Detection.RepeatOptions.ToString()') | Overridden ToString function. |
