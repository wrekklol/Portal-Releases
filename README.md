# Portal
 Portal is a scripting framework for automating tasks.

Download the [latest release](https://github.com/wrekklol/Portal-Releases/releases/latest), and have a look at the documentation.\
[Here](https://www.mediafire.com/file/apftieq1511ohzb/Helpers.7z/file) you can download some sample templates for RuneLite.

[**Documentation here.**](https://github.com/wrekklol/Portal-Releases/blob/main/docs/index.md)<br>
Information on how to create a module and start scripting is in the Examples section.

Features:
* Image Detection
* Human-like mouse movement
* Python Scripting

Planned Features:
* More scripting languages, probably Lua, C# and Visual Script
* More Image Detection algorithm
* OCR
* Maybe more?

# Examples
To start scripting, simply create a new folder in your Modules folder, and inside of your new folder you just create a new python file(.py).
There, now you've made a new scripting module and behavior script.

From here you can define some functions that are called from Portal whenever the script starts/stops/ticks etc.
A basic example would be:
```Python
from ...Stubs.PythonStubs import *

def Start():
    Print("Hello World")
```

Now whenever you start the script, "Hello Print" will get printed to the console, [Magic](https://tenor.com/view/mr-bean-gif-23140940)!

Note: "from ...Stubs.PythonStubs import *" must be defined for it to be considered a behavior script.

You can also easily start detecting templates and sending input etc.
But first, you should probably edit your "Game Window Title" to the window title you want to capture in the config menu.

Now, to detect a template, capture an image you want to detect (press your PrintScreen key).
Save it inside the Templates folder in your module folder (Portal/Modules/YourModule/Templates/), and call it from your behaviour with one of the FindMatch/FindMatches functions from [ScriptHelpers](https://github.com/wrekklol/Portal-Releases/blob/main/docs/ScriptCallables.md).

An example of that would be:
```Python
from ...Stubs.PythonStubs import *

def Start:
    FindMatch("YourNewTemplate")
```

Replace "YourNewTemplate" with with your actual template name(file name), and keep the quotes!

There are 5 functions that are called from Portal if defined:
```Python
def Init: # Called when the behavior is selected
    pass

def Start: # Called when the script is started, either by pressing the "Start" button on the UI or the F5 button
    pass

def Run: # Called each tick when script is running, and if this is defined the script will run until the "Stop" button or the F5 button is pressed
    pass

def Stop: # Called when the script is stopped
    pass

def Clear: # Called when switching behavior, can be used to clear some stuff that doesn't get clear automatically
    pass
```

## Detection

### [FindMatch](https://github.com/wrekklol/Portal-Releases/blob/main/docs/ScriptCallables.FindMatch(string,SearchOptions,RepeatOptions,Action,bool).md)
This function will try to find your template by its filename, and return the [Match](https://github.com/wrekklol/Portal-Releases/blob/main/docs/Match.md) found.  
You can specify some [SearchOptions](https://github.com/wrekklol/Portal-Releases/blob/main/docs/SearchOptions.md) to narrow down your search a bit, and [RepeatOptions](https://github.com/wrekklol/Portal-Releases/blob/main/docs/RepeatOptions.md) to specify how many times it should try to find the template.
You can also specify an [Action](https://learn.microsoft.com/en-us/dotnet/api/system.action?view=net-8.0) to be called if it could NOT find a match.

Example:
```Python
match = FindMatch("MyTemplate", SearchOptions(GameRegion(40, 40, 60, 60)), RepeatOptions(5, 100));
```
This will try to find the template with the filename "MyTemplate" within 20% of the screen from the center (starts at 40% and ends at 60%) and will repeat 5 times(or until found) with 100ms intervals.

Or simply:
```Python
match = FindMatch("MyTemplate");
```
If you don't want any specific options for the search.
If no options are specified, it will use the templates metadata, which is obtained from the templates associated .meta file.

<br/>

### [FindMatches](https://github.com/wrekklol/Portal-Releases/blob/main/docs/ScriptCallables.FindMatches(string,SearchOptions,RepeatOptions,Action,bool).md)
This function will try to find your template by its filename, and return the [Matches](https://github.com/wrekklol/Portal-Releases/blob/main/docs/Match.md) found.
You can specify some [SearchOptions](https://github.com/wrekklol/Portal-Releases/blob/main/docs/SearchOptions.md) to narrow down your search a bit, and [RepeatOptions](https://github.com/wrekklol/Portal-Releases/blob/main/docs/RepeatOptions.md) to specify how many times it should try to find the template.
You can also specify an [Action](https://learn.microsoft.com/en-us/dotnet/api/system.action?view=net-8.0) to be called if it could NOT find a match.

Example:
```Python
matches = FindMatches("YourNewTemplate", SearchOptions(GameRegion(40, 40, 60, 60)), RepeatOptions(5, 100));
```
This will try to find the template with the filename "MyTemplate" within 20% of the screen from the center (starts at 40% and ends at 60%) and will repeat 5 times(or until found) with 100ms intervals.

Or simply:
```Python
matches = FindMatches("YourNewTemplate");
```
If you don't want any specific options for the search.
If no options are specified, it will use the templates metadata, which is obtained from the templates associated .meta file.

<br/>

### [FindPixelColor]()
This function will try to find the color at the specified point.
If you already have a frame you want to find a color in, you can specify that.
You can also specify [RepeatOptions](https://github.com/wrekklol/Portal-Releases/blob/main/docs/RepeatOptions.md) to change how many times it should try to find the pixel color.

Example:
```Python
found_color = FindPixelColor(50, 50)
```
This will try to find the color at the center pixel of the screen (50% of screen width and 50% of screen height).
If more control over the point is needed, you can use the FindPixelColor overload that uses a [GamePoint](https://github.com/wrekklol/Portal-Releases/blob/main/docs/GamePoint.md).

<br/>

## Sending Input

### [MouseMove]() 
This will move your mouse with human-like movements towards the given [GamePoint](https://github.com/wrekklol/Portal-Releases/blob/main/docs/GamePoint.md).  
It can be configured using the [MouseMoveOptions](https://github.com/wrekklol/Portal-Releases/blob/main/docs/MouseMoveOptions.md) parameter, to specify the speed and wind etc. Can also be configured using the config menu.

Example:
```Python
MouseMove(50, 50);
```
Which will move the mouse to the center of the screen.

If you already have a match stored as a variable you could do:
```Python
match = FindMatch("YourNewTemplate")
match.Move() # Moves mouse to the center of the match
```
Which will move the mouse to the [center](https://github.com/wrekklol/Portal-Releases/blob/main/docs/GameRegion.Center.md) of the match's [GameRegion](https://github.com/wrekklol/Portal-Releases/blob/main/docs/GameRegion.md).

<br/>

### [Click]()
This will send down and up input, and you can go into more details with the options parameter, like modifiers(ctrl, shift etc), delays and data(mouse wheel direction etc).  
[InputOptions](https://github.com/wrekklol/Portal-Releases/blob/main/docs/InputOptions.md) can be implicitly converted to from an [EKeys](https://github.com/wrekklol/Portal-Releases/blob/main/docs/EKeys.md) enum, like EKeys.LButton, which is the left mouse button.

Example:
```Python
Click(EKey.LButton);
```
Which will move the mouse to the center of the screen and send a left mouse button "click"(down and up input).

If you already have a match stored as a variable you could do:
```Python
match = FindMatch("YourNewTemplate")
match.Click(EKey.LButton)
```
Which will move the mouse to the [center](https://github.com/wrekklol/Portal-Releases/blob/main/docs/GameRegion.Center.md) of the match's [GameRegion](https://github.com/wrekklol/Portal-Releases/blob/main/docs/GameRegion.md) and send a left mouse button "click"(down and up input).

<br/>

### [SendInput](https://github.com/wrekklol/Portal-Releases/blob/main/docs/InputManager.SendInput(InputOptions).md)
This will send the specified input options, where you have to specify [EKey](https://github.com/wrekklol/Portal-Releases/blob/main/docs/EKey.md) as well as [EKeyState](https://github.com/wrekklol/Portal-Releases/blob/main/docs/EKeyState.md) (Up or Down). If InKeyState is not specified it will default to EKeyState.Down | EKeyState Up, which exactly like a [Click](https://github.com/wrekklol/Portal-Releases/blob/main/docs/InputManager.Click(InputOptions).md).  
Key modifiers can also be specified using the [EKeyModifier](https://github.com/wrekklol/Portal-Releases/blob/main/docs/EKeyModifier.md) enum.

Example:
```Python
SendInput(EKey.LButton);
```
Will send left mouse button down.
