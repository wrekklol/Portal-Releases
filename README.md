# Portal
 Portal is a scripting framework for automating tasks.

Download the [latest release](https://github.com/wrekklol/Portal-Releases/releases/latest), and have a look at the documentation.

[**Documentation here.**](https://github.com/wrekklol/Portal-Releases/blob/main/docs/index.md)<br>
Information on how to create a module is on [this page.](https://github.com/wrekklol/Portal-Releases/blob/main/docs/ScriptModule.md)

After running the app the first time, a config.ini file will be generated.<br>
It should be edited to your game etc. There will be UI for this at some point.

Features:
* Image Detection
* Human-like mouse movement
* C# Scripting

Planned Features:
* Visual Scripting
* More Image Detection algorithms, currently only OpenCV is used
* OCR
* Maybe more?

# Examples
To start scripting, simply edit the example behaviour located in your Modules folder (Portal/Modules/ExampleModule/Behaviours/ExampleBehaviour.cs).

You can easily start detecting templates and sending input etc.  
To detect a template, capture an image you want to detect, put it inside the Templates folder in your module folder (Portal/Modules/ExampleModule/Templates/), and call it from your behaviour with one of the UntilFound functions from [ScriptHelpers](https://github.com/wrekklol/Portal-Releases/blob/main/docs/ScriptHelpers.md).

## Detection

### [WaitUntilFound](https://github.com/wrekklol/Portal-Releases/blob/main/docs/ScriptHelpers.WaitUntilFound(string,Nullable_SearchOptions_,Nullable_RepeatOptions_).md)
This is the most basic one. It will simply try to find your template by its filename, and return the [Match](https://github.com/wrekklol/Portal-Releases/blob/main/docs/Match.md) found.  
You can specify some [SearchOptions](https://github.com/wrekklol/Portal-Releases/blob/main/docs/SearchOptions.md) to narrow down your search a bit, and [RepeatOptions](https://github.com/wrekklol/Portal-Releases/blob/main/docs/RepeatOptions.md) to specify how many times it should try to find the template.

Example:
```C#
WaitUntilFound("MyTemplate", new SearchOptions(new GameRegion(250, 250, 750, 750)), new RepeatOptions(5, 100));
```
This will try to find the template with the filename "MyTemplate" in a region (250, 250, 750, 750), and will repeat 5 times(or until found) with 100ms intervals. 

<br/>

### [DoUntilFound](https://github.com/wrekklol/Portal-Releases/blob/main/docs/ScriptHelpers.DoUntilFound(string,Action,Nullable_SearchOptions_,Nullable_RepeatOptions_).md)
This one is a little bit more advanced.  
In addition to the above, you can also give it an [Action](https://learn.microsoft.com/en-us/dotnet/api/system.action?view=net-6.0).

Example:
```C#
var MyIntVar = 0;
DoUntilFound("MyTemplate", () => { MyIntVar++; }, new SearchOptions(new GameRegion(250, 250, 750, 750)), new RepeatOptions(5, 100));
```
This will increment MyIntVar every iteration.

<br/>

### [DoUntilPredicate](https://github.com/wrekklol/Portal-Releases/blob/main/docs/ScriptHelpers.DoUntilPredicate(string,Action,Predicate_Match_,Nullable_SearchOptions_,Nullable_RepeatOptions_).md)
This is the most advanced one.  
In addition to the above, you can also give it a [Predicate](https://learn.microsoft.com/en-us/dotnet/api/system.predicate-1?view=net-6.0).  
Note that this won't just stop when a template is found, it will continue until the specified Predicate is true.

Example:
```C#
var MyIntVar = 0;
DoUntilPredicate("MyTemplate", () => { MyIntVar++; }, MyMatchVar => MyMatchVar != null && MyIntVar > 3, new SearchOptions(new GameRegion(250, 250, 750, 750)), new RepeatOptions(5, 100));
```
In addtion to incrementing MyIntVar every iteration, it will check if the found match at this iteration is not null, and if MyIntVar is greater than 3, and then return the match.

<br/>

## Sending Input

### [MouseMove](https://github.com/wrekklol/Portal-Releases/blob/main/docs/InputManager.MouseMove(GamePoint).md) 
This will move your mouse with human-like movements towards the given [GamePoint](https://github.com/wrekklol/Portal-Releases/blob/main/docs/GamePoint.md).  
It has [overloads](https://github.com/wrekklol/Portal-Releases/blob/main/docs/InputManager.md) where you can specify how "random" it should be, but those options can also be adjusted globally in the config.

Example:
```C#
MouseMove(new GamePoint(500, 500));
```
Which will move the mouse to x coordinate 500 and y coordinate 500.  
If you already have a match stored as a variable you could do:
```C#
MouseMove(MyMatchVar.Region.Center);
```
Which will move the mouse to the center of the match's region.

<br/>

### [MouseMove_Instant](https://github.com/wrekklol/Portal-Releases/blob/main/docs/InputManager.MouseMove_Instant(GamePoint,GamePoint).md)
This will move your mouse to the specified [GamePoint](https://github.com/wrekklol/Portal-Releases/blob/main/docs/GamePoint.md) instantly, without human-like movement.

Example:
```C#
MouseMove_Instant(new GamePoint(500, 500));
```
Which will move the mouse to x coordinate 500 and y coordinate 500.  
If you already have a match stored as a variable you could do:
```C#
MouseMove_Instant(MyMatchVar.Region.Center);
```
Which will move the mouse to the center of the match's region.

<br/>

### [Click](https://github.com/wrekklol/Portal-Releases/blob/main/docs/InputManager.Click(InputOptions).md)
This will send down and up input, and you can go into more details with the options parameter, like modifiers(ctrl, shift etc), delays and data(mouse wheel direction etc).  
[InputOptions](https://github.com/wrekklol/Portal-Releases/blob/main/docs/InputOptions.md) can be implicitly converted to from an [EKeys](https://github.com/wrekklol/Portal-Releases/blob/main/docs/EKeys.md) enum, like EKeys.LButton, which is the left mouse button.

Example:
```C#
Click(EKeys.LButton);
```
Will send a left mouse button "click"(down and up input).

<br/>

### [SendInput](https://github.com/wrekklol/Portal-Releases/blob/main/docs/InputManager.SendInput(InputOptions).md)
This will send the specified input options, where you have to specify [EKeys](https://github.com/wrekklol/Portal-Releases/blob/main/docs/EKeys.md) as well as [EKeyState](https://github.com/wrekklol/Portal-Releases/blob/main/docs/EKeyState.md) (Up or Down). If InKeyState is not specified it will default to EKeyState.Down | EKeyState Up, which exactly like a [Click](https://github.com/wrekklol/Portal-Releases/blob/main/docs/InputManager.Click(InputOptions).md).  
Key modifiers can also be specified using the [EKeyModifiers](https://github.com/wrekklol/Portal-Releases/blob/main/docs/EKeyModifiers.md) enum.

Example:
```C#
SendInput(new InputOptions(EKeys.LButton));
```
Will send left mouse button down.
```C#
SendInput(new InputOptions(EKeys.LButton, EKeyState.Down, EKeyModifiers.Shift | EKeyModifiers.Control));
```
Will send left mouse button down while holding Shift and Control modifier keys.  
Scrolling can be done like this:
```C#
SendInput(new InputOptions(EKeys.WButton, EKeyState.Down, InData: 1));
```
Which will scroll up. Scrolling down is currently not supported, due to bad implementation of PInvoke.User32 package from Microsoft.
