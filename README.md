#The Maze Runner: Not a Ripoff
Author : Rahul Iyer

##Overview
This is a third-person 3D maze game where the player must navigate through a dungeon, collect keys, and unlock doors to reach the exit as fast as possible. Once escaped, the player’s completion time and name are recorded on a local leaderboard.

## Features
- **Animated Player Character** – 3D humanoid mesh with run/walk animations.  
- **Third-Person Camera** – Smooth follow camera that tracks the player.  
- **Maze Environment** – Built using modular dungeon assets with walls, floors, and doors.  
- **Keys & Doors System** – Each door requires its corresponding key to unlock.  
- **Timer System** – Tracks how long it takes to complete the maze.  
- **Maze Complete Screen** – Displays your time and allows you to enter your name.  
- **Leaderboard** – Saves the top 3 scores (name and time).  
- **Pause Menu** – Press **ESC** to pause, resume, restart, or exit to the main menu.  
- **Main Menu** – Includes Start, Leaderboard, and Exit buttons.

## Controls
- **WASD / Arrow Keys** – Move the player character.
- **ESC** – Pause/Resume the game.
- **E** – Interact with doors to unlock them (if you have the key), or pick up keys.

## Gameplay 
1. Start from the **Main Menu**.  
2. Explore the maze using WASD movement.  
3. Collect keys to unlock matching doors.  
4. Reach the **flag** at the end to escape the dungeon.  
5. On the **Maze Complete** screen, view your time and enter a 3-letter name.  
6. Save your score to the **Leaderboard** or restart to play again.

## Build Instructions
- Built using **Unity 2022.3.62f1 (Built-in Pipeline)**  
- Assets used are from Unity Asset Store. 
   -  **Lite Dungeon Pack (Gridness)**: https://assetstore.unity.com/packages/3d/environments/dungeons/lite-dungeon-pack-low-poly-3d-art-by-gridness-242692#description

    -  **Low Poly Human RPG Character (PolyToots)**: https://assetstore.unity.com/packages/3d/characters/humanoids/fantasy/free-low-poly-human-rpg-character-219979

    - **Rust Key (Aleksn09)**: https://assetstore.unity.com/packages/3d/props/rust-key-167590

- **Background Music from** : https://opengameart.org/content/sci-fi-puzzle-in-game-3

NOTE: No specific tutorial was followed, I watched parts and bits a lot of Unity tutorials on YouTube to piece together the implementation.

- To run the project, open the Unity Hub, click on "Add", and select the project folder. Then open it in Unity Editor.

