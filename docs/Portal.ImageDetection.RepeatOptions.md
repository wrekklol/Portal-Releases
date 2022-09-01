#### [Portal](index.md 'index')
### [Portal.ImageDetection](Portal.ImageDetection.md 'Portal.ImageDetection')

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
RepeatOptions MyRepeatOptions = RepeatOptions.None; // Translates to new(0, 0);  
RepeatOptions MyRepeatOptions = RepeatOptions.Default; // Translates to new(3, 50);  
RepeatOptions MyRepeatOptions = RepeatOptions.HighDelay; // Translates to new(3, 250);  
```

| Constructors | |
| :--- | :--- |
| [RepeatOptions(int, int)](Portal.ImageDetection.RepeatOptions.RepeatOptions(int,int).md 'Portal.ImageDetection.RepeatOptions.RepeatOptions(int, int)') | RepeatOptions constructor. |

| Properties | |
| :--- | :--- |
| [DelayBetweenSearches](Portal.ImageDetection.RepeatOptions.DelayBetweenSearches.md 'Portal.ImageDetection.RepeatOptions.DelayBetweenSearches') | Delay between each try. |
| [MaxTries](Portal.ImageDetection.RepeatOptions.MaxTries.md 'Portal.ImageDetection.RepeatOptions.MaxTries') | Maximum amount of tries. |

| Methods | |
| :--- | :--- |
| [ToString()](Portal.ImageDetection.RepeatOptions.ToString().md 'Portal.ImageDetection.RepeatOptions.ToString()') | Overridden ToString function. |
