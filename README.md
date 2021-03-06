# Project-D
AR Unity app voor Project D

## Project dependencies
* Unity 2019.3.13
  * Android Build Support module
  * iOS Build Support module
* Vuforia 9.1.7

Please use either the 'Android Build Support', 'iOS Build Support' or both if supported. \
The 'iOS Build Support' probably only works on macOS devices.

## Installation
* Download & install [Unity Editor 2019.3.13](https://unity3d.com/get-unity/download) (Or newer if you feel confident about it not breaking)
  * Make sure to add the 'Android Build Support' module and 'iOS Build Support' module (if on a macOS device)
* Clone this repository
* Open the cloned repo in the Unity Editor
* You should be good to go

## File structure
```
.
+-- Assets
:   +-- Editor <-- contains files made for use in the unity editor
:   +-- Images <-- contains custom images
:   +-- Plugins <-- contains installed plugins for use in the unity editor
:   +-- Resources <-- contains prefabs & other files used within scenes
:   +-- Scenes <-- contains all scenes
:   +-- Scripts <-- contains all scripts
:   +-- StreamingAssets <-- contains files downloaded from a database (used by Vuforia)
:   +-- Tests <-- contains all unit tests
:   :   +-- PlayTests <-- contains all PlayMode unit tests
+-- Packages
:   |-- manifest.json <-- info about required packages
+-- ProjectSettings <-- contains all project settings files
```
Notes
* Any other folders not mentioned above are made by, and configurable, within Unity
* *.meta files are generated by Unity and shouldn't be edited
* all files in `ProjectSettings` can be modified within Unity
