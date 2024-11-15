# 2D Roguelike

<!-- TOC -->
* [2D Roguelike](#2d-roguelike)
  * [Architecturing 拆解遊戲實作架構](#architecturing-拆解遊戲實作架構)
    * [Features](#features)
    * [Tasks](#tasks)
  * [Game Board](#game-board)
    * [Scripting a tilemap](#scripting-a-tilemap)
    * [Add a border to the board](#add-a-border-to-the-board)
    * [Camera](#camera)
    * [Board Data](#board-data)
  * [Player Character](#player-character)
  * [Turn System](#turn-system)
  * [Food Resource](#food-resource)
  * [Obstacles](#obstacles)
  * [Win and Lose Conditions](#win-and-lose-conditions)
  * [Improve Graphics](#improve-graphics)
  * [Animation](#animation)
  * [Enemy](#enemy)
  * [Improvement Ideas](#improvement-ideas)
<!-- TOC -->

- [2D Roguelike | Complete Project](https://assetstore.unity.com/packages/templates/tutorials/2d-roguelike-complete-project-299017)

## Architecturing 拆解遊戲實作架構

- break down your ideas into chunks of actionable tasks
- “I need the player to drive a car around a circuit and other cars race alongside them.”

Elements

- A **circuit** that is the main part of the environment of the game.   
- The **cars** of the player and opponents.
- Computer controlled behavior for the **adversaries**.

Actions

- First, code the **car control**, on an empty space, just to focus on the car physics and movement.
- Then code a **circuit** that makes controlling the car an actual task (so coding penalties if getting out of it, etc.)
- Finally, you can code the behavior of the **other cars** that try to automatically follow the circuit.

### Features

- The scenery of the game consists of a **board** made of square cells.
- The components of this board are generated randomly when the game starts and for each level. This is called **procedural generation**, so no two scenes will be the same.
- The player can **move** to any cell directly adjacently: left, right, up, or down.
- The game is played **turn-based**, meaning nothing happens until the user makes an action, which advances (tick) the game one unit. This “tick” is the base unit of time of the game.
- The **goal** is for the player character to reach an exit cell that will take them to the next level.
- The player starts with a certain amount of **food**, and with each tick of the game, one unit of food is consumed.
- **Walls** are placed randomly in the level to stop the player from moving where they want. However, they can be destroyed by repeatedly attacking them. 
- If the player ever runs out of food, the game ends; this is game **over**!
- There are **enemies** on the board who will move on each tick (so only when the player character moves).
- If an enemy moves into the player character, they will **hurt** them by consuming a certain amount of food.
- If the player character moves into an enemy, they will hurt the enemy, removing 1 health point from them.
- Once an enemy is at 0 health points, they are **removed** from the board.
- Some **cells** contain food. When the player character enters them, they collect the food.

### Tasks

- Everything happens inside the **game board**, and the cell is the base unit of space, so this is probably the first thing you'll need. You should start by writing the code that generates a game board of square cells randomly on each level.
- You then need to create a player **character** that can be placed on the board and move through it. Once this is done, you can start adding special rules like not allowing them to move on some special cells.
- The game is **turn-based** and ticks every time the character moves. As you now have a moving character, you can now add a turn system.
- Now that we have a game that “ticks,” we can finally add the **food** resources.
- We can also add walls now, as **collectables** inside cells (food resources) were just added.
- The Next step is adding the **exit** cell to finish the level. Detecting when the player enters a given cell is necessary not only for this part but also for collecting the food collectibles you previously created.
- Now that you have the exit cell, it’s time to start working on the “**gameplay loop**.” You want to increase the level number everytime the player reaches an exit, generate a new level, and handle the case when the food reaches zero so the game is over. This is where you can create a **Gamemanager** that will take care of initializing the game (generate the board, place the player, etc.), check for and handle the “game over” conditions.
- Finally, you can add **enemies** to increase the complexity of the game.

## Game Board

- 設定相機 Hierarchy > **Main Camera** > Inspector
  - Projection: Orthographic, Size: 5
  - Environment > Background: black (000000)
- 創建 Tilemap: Hierarchy > create 2D Object > **Tilemap** > Rectangular. (inside `Grid`)
  - [Create a basic 2D gameplay environment tutorial](https://learn.unity.com/tutorial/create-a-basic-2d-gameplay-environment?uv=2022.3&courseId=64774201edbc2a1638d25d18&projectId=64774230edbc2a143ab0e3a7#64d2142eedbc2a5edea814f7)
  - [Tilemaps in Unity](https://docs.unity3d.com/6000.0/Documentation/Manual/tilemaps/tilemaps-landing.html)
- 創建 Tile Palette: Assets > Create folder 'Tiles' > Create > 2D > **Tile Palette** > Rectangular
  - Window > 2D > Tile Palette
  - Assets > Roguelike2D > TutorialAssets > Sprites > select then drag-drop into the Tile Palette window
- Ref
  - [Unity學習筆記#10 : TileMap基本功](https://kendevlog.wordpress.com/2018/01/02/unity學習筆記10-tilemap基本功)

### Scripting a tilemap

- rename `Grid` to BoardManager (GameObject)
- Assets > Create folder 'Scripts' > Create > Scripting > MonoBehaviour Script: **BoardManager.cs**. Add it as a component of the **BoardManager** GameObject.
  - The width (in number of tiles) of our level.
  - The height (in number of tiles) of our level.
  - An array of tiles that are going to be used for the board. 
    - `public Tile[] GroundTiles`
    - `private m_Tilemap = GetComponentInChildren<Tilemap>();`
- BoardManager GameObject > Inspector: width: 8, height: 8
  - Ground Tiles: Select sprites

### Add a border to the board

- `public Tile[] WallTiles;`

### Camera

- tilemap = (0,0,0) + (width, height, 8)
  - center is at (4,4,0)
  - Set Main Camera Position at (4,4,-10)

### Board Data

- `private CellData[,] m_BoardData;`

## Player Character

- Assets > Roguelike2D > TutorialAssets > Sprites: drag into the scene. Auto creates a new GameObject with a Sprite Renderer component 
- Scripts > PlayerController.cs > add it to the PlayerCharacter GameObject
- Breakdowns
  - At the start, the board sets the player on a specific cell after it finishes generating the level. 
  - When the user presses a direction button (up, down, left, or right arrow keys), the script checks if the cell in that direction is passable. 
  - If the cell is passable, the script moves the character to that new cell.
- Functions
  - When the board places the player character, the player character will need a **Spawn** method that will move it to the right spot. 
  - The script needs to know where the player character currently is to search for the next cells the player character can move to, so it will need to store its current cell index. 
  - As the script needs to know if the cell the player character is trying to move to is passable, and that information is stored in the **BoardManager**. The script will need to store a reference to the BoardManager to query it about the state of a given cell.
- Variables in PlayerController.cs
  - A private variable of type `BoardManager`.
  - A private variable of type `Vector2Int` that saves the current cell the player is on.
  - A public method called `Spawn` that saves the BoardManager that the player is placed in and the index where it is current.

## Turn System

## Food Resource

[//]: # (TODO)

## Obstacles

## Win and Lose Conditions

## Improve Graphics

## Animation

## Enemy

## Improvement Ideas

