# Haunted House

**SWE 402 — Assignment 2**  
**Chosen option: Option 2 — 3D Stealth Game: Haunted House**

A 3D stealth game created in Unity following the Unity Learn Haunted House course. Explore the haunted house, avoid enemies, collect matching keys to unlock doors, and reach the exit.

## Play the Game

**Published game:** [Play Haunted House on Unity Play](https://play.unity.com/en/games/fa16eb0b-489f-47ca-b25e-08f66b41be71/haunted-house)

Open the published link in a desktop browser, click **Start**, and click inside the game window to give it keyboard focus.

## Controls

| Key | Action |
| --- | --- |
| W | Move forward |
| S | Move backward |
| A | Move left |
| D | Move right |

Collect keys by touching them. After collecting the matching key, touch a locked door to remove it and pass through.

## Objective

Reach the exit without being spotted. Static Gargoyles watch specific areas, while Ghosts patrol the house. Being detected displays the lose screen and restarts the gameplay scene. Reaching the exit displays the win screen and ends the attempt.

## Features

- Player movement, turning, collisions, and idle/walking animations.
- Cinemachine camera that follows the player.
- Static enemies with detection areas and line-of-sight checks.
- Ghost patrols using waypoints.
- Win and lose screens made with UI Toolkit.
- Background ambience, Ghost audio, and win/lose sound effects.

### Additional Features

- Looping footsteps that play while the player moves.
- An on-screen timer showing elapsed play time.
- Matching keys and locked doors.
- A customized post-processing profile (`MyHauntedProfile`).
- A main menu with Start and Quit buttons.

## Open and Run in Unity

**Unity Editor version:** Unity 6.3 LTS — `6000.3.24f1`.

1. Clone or download this repository.
2. In Unity Hub, select **Add project from disk** and choose the project folder containing `Assets`, `Packages`, and `ProjectSettings`.
3. Open the project using the Unity version listed above and allow its packages and assets to finish importing.
4. Open the `MainMenu` scene under `Assets/_3DStealthGame/Tutorial_Demo/Demo_Scenes`.
5. Press **Play**, then click **Start** to open the gameplay scene.

To test gameplay directly, open `Assets/_3DStealthGame/Scenes/Main.unity` and press **Play**.

## Build and Run

1. Install **Web Build Support** for the project’s Unity version through Unity Hub if needed.
2. Open **File > Build Profiles** and select **Web** as the active platform.
3. Ensure the enabled scenes are ordered as follows:
   - **0: MainMenu**
   - **1: Main** — the gameplay scene from `Assets/_3DStealthGame/Scenes`.
4. Select **Build And Run** and choose an output folder outside `Assets`.
5. Test the game in the browser opened by Unity.

Use **Build And Run** or a web server to test the Web build locally rather than opening `index.html` directly. After making project changes, rebuild and upload the updated build to Unity Play.

The Quit button does not close the Unity Editor or browser tab. Application quitting is supported in a desktop standalone build.

## Repository Contents

The complete Unity project includes:

- `Assets/` — scenes, scripts, prefabs, audio, materials, and game assets, including `.meta` files.
- `Packages/` — package manifest and dependency information.
- `ProjectSettings/` — Unity project configuration.

Generated folders such as `Library`, `Temp`, `Logs`, and `Obj` are excluded using a Unity `.gitignore`.

## Credits

Created for SWE 402 Assignment 2 using the tutorials and assets provided by Unity Technologies.

- [Unity Learn: 3D Stealth Game — Haunted House](https://learn.unity.com/course/3d-stealth-game-haunted-house)
- [Haunted House Tutorial Assets](https://assetstore.unity.com/packages/essentials/tutorial-projects/3d-stealth-game-haunted-house-143848)

Third-party assets remain subject to their respective licenses.
