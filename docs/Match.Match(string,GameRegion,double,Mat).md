#### [Portal](index.md 'index')
### [Portal.Detect](Portal.Detect.md 'Portal.Detect').[Match](Match.md 'Portal.Detect.Match')

## Match(string, GameRegion, double, Mat) Constructor

Match constructor.

```csharp
public Match(string InTemplate, Portal.GameRegion InRegion, double InConfidence, OpenCvSharp.Mat? InFrame=null);
```
#### Parameters

<a name='Portal.Detect.Match.Match(string,Portal.GameRegion,double,OpenCvSharp.Mat).InTemplate'></a>

`InTemplate` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Portal.Detect.Match.Match(string,Portal.GameRegion,double,OpenCvSharp.Mat).InRegion'></a>

`InRegion` [GameRegion](GameRegion.md 'Portal.GameRegion')

<a name='Portal.Detect.Match.Match(string,Portal.GameRegion,double,OpenCvSharp.Mat).InConfidence'></a>

`InConfidence` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='Portal.Detect.Match.Match(string,Portal.GameRegion,double,OpenCvSharp.Mat).InFrame'></a>

`InFrame` [OpenCvSharp.Mat](https://docs.microsoft.com/en-us/dotnet/api/OpenCvSharp.Mat 'OpenCvSharp.Mat')

Will only be set if [bWantsFrameCaptured](SearchOptions.bWantsFrameCaptured.md 'Portal.Detect.SearchOptions.bWantsFrameCaptured') is true.