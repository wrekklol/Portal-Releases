#### [Portal](index.md 'index')
### [Portal.Detect](Portal.Detect.md 'Portal.Detect')

## RepeatOptions Class

Repeat options for image detection.

```csharp
public class RepeatOptions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; RepeatOptions

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
Can also be created using builder pattern.  
Example:  
  
```csharp  
RepeatOptions MyRepeatOptions = new()  
    .WithMaxTries(100)  
    .WithDelayBetweenSearches(50);  
```

| Constructors | |
| :--- | :--- |
| [RepeatOptions()](RepeatOptions.RepeatOptions().md 'Portal.Detect.RepeatOptions.RepeatOptions()') | RepeatOptions constructor.<br/>Is the same as [Default](RepeatOptions.Default.md 'Portal.Detect.RepeatOptions.Default'). |
| [RepeatOptions(int, int)](RepeatOptions.RepeatOptions(int,int).md 'Portal.Detect.RepeatOptions.RepeatOptions(int, int)') | RepeatOptions constructor. |

| Properties | |
| :--- | :--- |
| [Default](RepeatOptions.Default.md 'Portal.Detect.RepeatOptions.Default') | Creates a new [RepeatOptions](RepeatOptions.md 'Portal.Detect.RepeatOptions') with the values 1 and 0 for [MaxTries](RepeatOptions.MaxTries.md 'Portal.Detect.RepeatOptions.MaxTries') and [DelayBetweenSearches](RepeatOptions.DelayBetweenSearches.md 'Portal.Detect.RepeatOptions.DelayBetweenSearches') respectively. |
| [DelayBetweenSearches](RepeatOptions.DelayBetweenSearches.md 'Portal.Detect.RepeatOptions.DelayBetweenSearches') | Delay between each try. |
| [HighDelay](RepeatOptions.HighDelay.md 'Portal.Detect.RepeatOptions.HighDelay') | Creates a new [RepeatOptions](RepeatOptions.md 'Portal.Detect.RepeatOptions') with the values 3 and 250 for [MaxTries](RepeatOptions.MaxTries.md 'Portal.Detect.RepeatOptions.MaxTries') and [DelayBetweenSearches](RepeatOptions.DelayBetweenSearches.md 'Portal.Detect.RepeatOptions.DelayBetweenSearches') respectively. |
| [LowDelay](RepeatOptions.LowDelay.md 'Portal.Detect.RepeatOptions.LowDelay') | Creates a new [RepeatOptions](RepeatOptions.md 'Portal.Detect.RepeatOptions') with the values 3 and 50 for [MaxTries](RepeatOptions.MaxTries.md 'Portal.Detect.RepeatOptions.MaxTries') and [DelayBetweenSearches](RepeatOptions.DelayBetweenSearches.md 'Portal.Detect.RepeatOptions.DelayBetweenSearches') respectively. |
| [MaxTries](RepeatOptions.MaxTries.md 'Portal.Detect.RepeatOptions.MaxTries') | Maximum amount of tries. |

| Methods | |
| :--- | :--- |
| [ToString()](RepeatOptions.ToString().md 'Portal.Detect.RepeatOptions.ToString()') | Overridden ToString function. |
| [WithDelayBetweenSearches(int)](RepeatOptions.WithDelayBetweenSearches(int).md 'Portal.Detect.RepeatOptions.WithDelayBetweenSearches(int)') | Sets [DelayBetweenSearches](RepeatOptions.DelayBetweenSearches.md 'Portal.Detect.RepeatOptions.DelayBetweenSearches') to [InDelayBetweenSearches](RepeatOptions.WithDelayBetweenSearches(int).md#Portal.Detect.RepeatOptions.WithDelayBetweenSearches(int).InDelayBetweenSearches 'Portal.Detect.RepeatOptions.WithDelayBetweenSearches(int).InDelayBetweenSearches'). |
| [WithMaxTries(int)](RepeatOptions.WithMaxTries(int).md 'Portal.Detect.RepeatOptions.WithMaxTries(int)') | Sets [MaxTries](RepeatOptions.MaxTries.md 'Portal.Detect.RepeatOptions.MaxTries') to [InMaxTries](RepeatOptions.WithMaxTries(int).md#Portal.Detect.RepeatOptions.WithMaxTries(int).InMaxTries 'Portal.Detect.RepeatOptions.WithMaxTries(int).InMaxTries'). |
