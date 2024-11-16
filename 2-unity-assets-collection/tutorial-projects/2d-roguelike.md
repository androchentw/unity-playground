# 2D Roguelike

<!-- TOC -->
* [2D Roguelike](#2d-roguelike)
  * [Architecturing 拆解遊戲實作架構](#architecturing-拆解遊戲實作架構)
    * [Features](#features)
    * [Actionable Tasks](#actionable-tasks)
  * [Game Board](#game-board)
  * [Tilemap, Tile Palette, Sprites](#tilemap-tile-palette-sprites)
    * [生成: Scripting a tilemap](#生成-scripting-a-tilemap)
    * [Add a border to the board](#add-a-border-to-the-board)
    * [Camera](#camera)
    * [Board Data](#board-data)
  * [Player Character](#player-character)
    * [Sprite](#sprite)
    * [Scripts `PlayerController.cs`](#scripts-playercontrollercs)
  * [Turn System](#turn-system)
  * [Food Resource](#food-resource)
    * [UIToolkit](#uitoolkit)
    * [Update the Label using code](#update-the-label-using-code)
    * [Objects in cell and food refill](#objects-in-cell-and-food-refill)
      * [`BoardManager.cs`](#boardmanagercs)
    * [Collect food](#collect-food)
    * [Increasing the food count](#increasing-the-food-count)
    * [Challenge](#challenge)
  * [Obstacles](#obstacles)
  * [Win and Lose Conditions](#win-and-lose-conditions)
  * [Improve Graphics](#improve-graphics)
  * [Animation](#animation)
  * [Enemy](#enemy)
  * [Improvement Ideas](#improvement-ideas)
<!-- TOC -->

- [2D Roguelike | Complete Project](https://assetstore.unity.com/packages/templates/tutorials/2d-roguelike-complete-project-299017)
- Codebase: [unity-tutorial-projects/2d-roguelike](https://github.com/androchentw/unity-tutorial-projects/tree/main/2d-roguelike/Assets/Roguelike2D/TutorialVersion)

## Architecturing 拆解遊戲實作架構

- Goal: break down your ideas into chunks of **actionable tasks**

### Features

- 棋盤 Board
- 生成 Procedural generation
  - 回合 Tick
- 移動 Move
  - 牆壁 Wall
- 目標 Goal
  - 結束 End
  - 食物 Food resources
- 敵人 Enemy
  - 受傷 Hurt
  - 攻擊 Attack
  - 移除 Remove
- 採集 Collectible

### Actionable Tasks

- 棋盤 Game board
- 角色 Character
- 回合 Turn-based
- 資源 Food resources
- 採集 Collectibles
- 出口 Exit
- 迴圈 Gameplay loop. Gamemanager
- 敵人 Enemy

## Game Board

- 設定相機 Hierarchy > **Main Camera** > Inspector
  - Projection: Orthographic, Size: 5
  - Environment > Background: black (000000)
- 創建 **Tilemap**: Hierarchy > create 2D Object > Tilemap > Rectangular. (inside `Grid`)
  - [Create a basic 2D gameplay environment tutorial](https://learn.unity.com/tutorial/create-a-basic-2d-gameplay-environment?uv=2022.3&courseId=64774201edbc2a1638d25d18&projectId=64774230edbc2a143ab0e3a7#64d2142eedbc2a5edea814f7)
  - [Tilemaps in Unity](https://docs.unity3d.com/6000.0/Documentation/Manual/tilemaps/tilemaps-landing.html)
- 創建 **Tile Palette**: Assets > Create folder 'Tiles' > Create > 2D > Tile Palette > Rectangular
  - Window > 2D > Tile Palette
  - Assets > Roguelike2D > TutorialAssets > Sprites > select then drag-drop into the Tile Palette window
- Ref
  - [Unity學習筆記#10 : TileMap基本功](https://kendevlog.wordpress.com/2018/01/02/unity學習筆記10-tilemap基本功)

## Tilemap, Tile Palette, Sprites

- Tilemap 由 tiles (瓦, 地形單元) 組成, 是場景裡的特殊 asset (2D Object)
- Tile Palette 是編輯器工具, 方便管理 tiles

| **特性**     | **Tilemap**                   | **Tile Palette**                 | **Sprites**                     |
|------------|-------------------------------|----------------------------------|---------------------------------|
| **定義**     | 用於 2D 網格地圖系統的組件，用於管理和**繪製地圖** | 一個**編輯器工具**，用於快速管理和繪製 Tile       | 2D 圖像，用於創建遊戲角色、物件或地圖元素          |
| **用途**     | 建立大型地圖，如關卡地形、平台               | 方便選取和繪製多個 Tile 至 Tilemap         | 用於顯示遊戲中的單一圖像或動畫                 |
| **編輯器支援**  | 支援編輯器中的可視化繪製                  | 提供拖放式的圖塊選擇工具                     | 支援 Sprites 編輯器，用於切割圖像           |
| **數據管理**   | 儲存在 `Tilemap` 組件中             | 儲存在 `Tile Palette` 中，作為 Tile 資料庫 | Sprites 儲存在 `Assets/` 資料夾下的圖像文件 |
| **效能**     | 優化的繪製系統，適合大範圍重複使用的地圖元素        | 主要用於提高 Tilemap 的編輯效率             | 取決於 Sprite 的大小和使用的數量            |
| **靈活性**    | 適合用於靜態地圖                      | 用於快速繪製重複模式的 Tile                 | 用於動態顯示，如角色動畫、UI 元素              |
| **常見應用場景** | 關卡設計、地形繪製                     | 創建關卡設計時方便快速填充                    | 適用於角色、物品、敵人、UI 元素等              |

```csharp
using UnityEngine;
using UnityEngine.Tilemaps;

public class LevelLoader : MonoBehaviour
{
    public Tilemap groundTilemap;
    public Tilemap obstacleTilemap;
    public GameObject playerPrefab;
    public Vector3 playerStartPosition;

    void Start()
    {
        // 初始化角色位置
        GameObject player = Instantiate(playerPrefab, playerStartPosition, Quaternion.identity);

        // 根據地圖上的障礙物 Tile 檢測碰撞
        if (obstacleTilemap.GetTile(obstacleTilemap.WorldToCell(player.transform.position)) != null)
        {
            Debug.Log("Player spawned on an obstacle!");
        }
    }
}
```

### 生成: Scripting a tilemap

- 因為這邊是採用動態生成地形, 所以會使用到 csharp 來操作 Tilemap
  - rename `Grid` to BoardManager (GameObject)
- Assets > Create folder 'Scripts' > Create > Scripting > MonoBehaviour Script: **BoardManager.cs**. Add it as a component of the **BoardManager** GameObject.
  - 寬: The width (in number of tiles) of our level.
  - 高: The height (in number of tiles) of our level.
  - 數量: An array of tiles that are going to be used for the board.
    - `public Tile[] GroundTiles`
    - `private m_Tilemap = GetComponentInChildren<Tilemap>();`
- BoardManager GameObject > Inspector: width: 8, height: 8
  - Ground Tiles: Select sprites (選取不同風格的 tiles)

### Add a border to the board

- `public Tile[] WallTiles;`

### Camera

- tilemap = (0,0,0) + (width, height, 8)
  - center is at (4,4,0)
  - Set Main Camera Position at (4,4,-10)

### Board Data

- `private CellData[,] m_BoardData;`

## Player Character

### Sprite

- Assets > Roguelike2D > TutorialAssets > Sprites
- Drag into the scene: Auto creates a new GameObject with a Sprite Renderer component

### Scripts `PlayerController.cs`

- Goal: attach it to the PlayerCharacter GameObject
- 拆解 Breakdowns
  - 隨機起始位置: `Spawn()` 生成 + `Vector2Int` 位置 + `Move()` 移動
  - 移動 + 障礙判斷: `BoardManager`

## Turn System

## Food Resource

- `GameManager.cs` + `TurnManager.cs` callback system (when turn events happen)
- Ref: [Observer pattern](/0-architecture-patterns/design-patterns/README.md#observer-pattern)

```csharp
// TurnManager.cs
// `event`, C# keyword, allows only current class to trigger'
public event System.Action OnTick;

public void Tick()
{
    OnTick?.Invoke();   // `?`, C# null checker
}
```

```csharp
// GameManager.cs
private int m_FoodAmount = 100;     // initial value

// Introduces the dependecy of TurnManager, BoardManager, PlayerController
void Start()
{
    // Register the OnTurnHappen method to your TurnManager.OnTick callback.
    // Unregister OnDestroy with -=
    TurnManager = new TurnManager();
    TurnManager.OnTick += OnTurnHappen;
  
    BoardManager.Init();
    PlayerController.Spawn(BoardManager, new Vector2Int(1,1));
}

void OnTurnHappen()
{
    m_FoodAmount -= 1;
    Debug.Log("Current amount of food : " + m_FoodAmount);
}
```

### UIToolkit

- Ref: [Unity UI Toolkit](/1-unity-basics/5-unity-ui-toolkits.md)
- Actions
  1. `UIDocument` GameObject: Hierarchy > UI Toolkit > UI Document
  2. `UI/GameUI` UXML (Visual Tree Asset): Assets > UI folder > Create UI Toolkit > UI Document
  3. Assign `GameUI` to `UIDocument`'s "Source Asset"
  4. Double click `GameUI` > UI Builder Window > Label > Name: `FoodLabel`. Font, size, color, position

### Update the Label using code

- Goal: `GameManager` Display the amount of food the player has on each turn.

```csharp
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public UIDocument UIDoc;    // select GameObject "UIDocument" in inspector
    private Label m_FoodLabel;

    void Start()
    {
        // Q looks from root for element of type <Label> with name "FoodLabel"
        m_FoodLabel = UIDoc.rootVisualElement.Q<Label>("FoodLabel");
        m_FoodLabel.text = "Food : " + m_FoodAmount;
    }
    
    // update counter in TurnManager.OnTick event callback 
    void OnTurnHappen()
    {
       m_FoodAmount -= 1;
       m_FoodLabel.text = "Food : " + m_FoodAmount; // update UI
    }
}
```

### Objects in cell and food refill

- Goal: add a collectible object that refills 10 units of food
- `PlayerController.cs` moves and checks `CellData` if `isCollectible` then `remove()` and `addFood()`
- Drag `SmallFoodGameObject` from Hierarchy window to `Prefabs` folder, delete `SmallFoodGameObject` from the scene

#### `BoardManager.cs`

- `public FoodObject FoodPrefab`. FoodObject : CellObject : GameObject
- `GenerateFood()` in `Init()`
- Assign `SmallFood prefab` to `FoodPrefab` slot on `BoardManager` in the Inspector window
- Keep track of empty cells for pick by `m_EmptyCellsList = new List<Vector2Int>();`

```csharp
// BoardManager.cs

public class CellData
{
    public bool Passable;
    public CellObject ContainedObject;
}
```

### Collect food

### Increasing the food count

### Challenge

## Obstacles

## Win and Lose Conditions

## Improve Graphics

## Animation

## Enemy

## Improvement Ideas

