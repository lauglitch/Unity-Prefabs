# VisualLogger Prefab

VisualLogger is a prefab designed for Unity to display logs directly on the screen during runtime, mimicking the Unity console but visible in the game UI.

## Features
- Displays logs in a draggable panel.
- Toggle visibility with a button.
- Supports adding and clearing logs programmatically.

## Structure
- **Prefab:** Contains the main VisualLogger GameObject.
- **Scripts:** Includes the necessary scripts for the prefab to function:
  - `VisualLogger.cs`: Manages overall behavior and initialization.
  - `LoggerPanelManager.cs`: Handles log messages and clearing the log panel.
  - `Draggable.cs`: Enables the panel to be moved within the canvas.
  - `ToggleVisibility.cs`: Handles the toggle button to show/hide the log panel.

## How to Use
1. Drag the prefab into your Unity scene.
2. Attach the required scripts to the corresponding GameObjects if they are not automatically assigned.
3. Use the `VisualLogger` class to log messages in your game:
   VisualLogger.Log("This is a test log message.");
4. Click the toggle button in the UI to show or hide the logger panel.
5. Drag the panel anywhere in the canvas during runtime.

## Requirements
Unity 2021.3.20f1 or later.
A parent canvas in the scene (the prefab will not create one automatically).

## Installation
Clone or download this repository.
Import the VisualLogger folder into your Unity project's Assets directory.

## Contribution
Feel free to fork this repository and submit pull requests for improvements or new features.

## License
This project is licensed under the MIT License. See the LICENSE file for details.
