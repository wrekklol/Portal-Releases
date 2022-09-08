#### [Portal](index.md 'index')
### [WPFCaptureSample](WPFCaptureSample.md 'WPFCaptureSample').[WindowEnumerationHelper](WindowEnumerationHelper.md 'WPFCaptureSample.WindowEnumerationHelper')

## WindowEnumerationHelper.GetAncestorFlags Enum

```csharp
private enum WindowEnumerationHelper.GetAncestorFlags
```
### Fields

<a name='WPFCaptureSample.WindowEnumerationHelper.GetAncestorFlags.GetParent'></a>

`GetParent` 1

Retrieves the parent window. This does not include the owner, as it does with the GetParent function.

<a name='WPFCaptureSample.WindowEnumerationHelper.GetAncestorFlags.GetRoot'></a>

`GetRoot` 2

Retrieves the root window by walking the chain of parent windows.

<a name='WPFCaptureSample.WindowEnumerationHelper.GetAncestorFlags.GetRootOwner'></a>

`GetRootOwner` 3

Retrieves the owned root window by walking the chain of parent and owner windows returned by GetParent.