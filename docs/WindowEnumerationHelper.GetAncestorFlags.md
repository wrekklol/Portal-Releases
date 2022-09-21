#### [Portal](index.md 'index')
### [Portal.Detection.Capture](Portal.Detection.Capture.md 'Portal.Detection.Capture').[WindowEnumerationHelper](WindowEnumerationHelper.md 'Portal.Detection.Capture.WindowEnumerationHelper')

## WindowEnumerationHelper.GetAncestorFlags Enum

```csharp
private enum WindowEnumerationHelper.GetAncestorFlags
```
### Fields

<a name='Portal.Detection.Capture.WindowEnumerationHelper.GetAncestorFlags.GetParent'></a>

`GetParent` 1

Retrieves the parent window. This does not include the owner, as it does with the GetParent function.

<a name='Portal.Detection.Capture.WindowEnumerationHelper.GetAncestorFlags.GetRoot'></a>

`GetRoot` 2

Retrieves the root window by walking the chain of parent windows.

<a name='Portal.Detection.Capture.WindowEnumerationHelper.GetAncestorFlags.GetRootOwner'></a>

`GetRootOwner` 3

Retrieves the owned root window by walking the chain of parent and owner windows returned by GetParent.