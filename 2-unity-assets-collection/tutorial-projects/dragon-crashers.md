# Dragon Crashers

- [Codebase](https://github.com/androchentw/unity-tutorial-projects/tree/main/dragon-crashers/Assets)
- [Asset Store:](https://assetstore.unity.com/packages/essentials/tutorial-projects/dragon-crashers-ui-toolkit-sample-project-231178)

<!-- TOC -->
* [Dragon Crashers](#dragon-crashers)
  * [Unity Ebook - User interface design and implementation in Unity](#unity-ebook---user-interface-design-and-implementation-in-unity)
    * [Screenshots](#screenshots)
    * [Mini Manual](#mini-manual)
  * [Dragon Crashers Code Breakdown](#dragon-crashers-code-breakdown)
    * [Overview](#overview)
    * [Scene](#scene)
    * [View: UI Toolkit (Uxml + Uss) + Scripts/UI/UIViews/*.cs](#view-ui-toolkit-uxml--uss--scriptsuiuiviewscs)
    * [Model: GameObject.asset + ScriptableObject.cs](#model-gameobjectasset--scriptableobjectcs)
    * [Presenter in Scripts/UI](#presenter-in-scriptsui)
    * [GameObject: Scripts/Gameplay/*.asset](#gameobject-scriptsgameplayasset)
<!-- TOC -->

## Unity Ebook - User interface design and implementation in Unity

- [User interface design and implementation in Unity](https://unity.com/resources/user-interface-design-and-implementation-in-unity)
  - Sprite, Tilemap
  - UI Toolkit
  - Dragon Crasher
    - Home, character, resources, shop, mail, settings, menu bar, inventory

### Screenshots

- [UI Reference](https://github.com/androchentw/unity-tutorial-projects/blob/main/dragon-crashers/Assets/UI/Reference/0%20home-screen.jpg)

### Mini Manual

- [Mini Manual pdf](https://github.com/androchentw/unity-tutorial-projects/blob/main/dragon-crashers/Assets/Documentation/Mini%20manual%20for%20UI%20TK-DG_%20pdf.pdf)
- [Device Simulator](https://docs.unity3d.com/Packages/com.unity.device-simulator@3.0/manual/index.html)
- Block Element Modifier (BEM)
  - https://getbem.com/
  - https://w3c.hexschool.com/blog/35afa83f
  - https://www.webdong.dev/zh-tw/post/write-cleaner-css-with-bem/
  - Utility-First CSS, tailwind. https://ithelp.ithome.com.tw/articles/10243926
- `ShopScreen.uxml`
  - **ShopItemSO**: This ScriptableObject holds the statistics for each item that appears in the shop.
  - **ShopItemComponent**: This translates game data from the ScriptableObject into UI text and graphics for a single item.
  - **ShopScreenController**: This handles the actual game logic to set up the shop. The controller reads the ScriptableObject assets from the Resources and stores them in categorized lists (List), one for each item type (coins, gems, potions).
  - **ShopView**: This UI class renders the UI, updating the display based on events from the controller.

## Dragon Crashers Code Breakdown

<img src="res/dragon-crasher-breakdown.png" width="600" alt="dragon-crasher-breakdown">

### Overview

- Scene
  - MainMenu.unity, GameHome.unity
- View
  - UI Toolkit (Uxml + Uss) + Scripts/UI/UIViews/*.cs
  - Screen > Panel > Modal
  - CharacterScreen, SettingsScreen, MailScreen, ShopScreen
  - MenuBar, Inventory
- Model
  - 1-1 mapping of `Resources/GameData/*GameObject.asset` + `Scripts/GameDataSO/*.cs`
  - CharacterSO, SkillSO, ShopItemSO
  - `[CreateAssetMenu]`, `[System.Serializable]`, MonoBehaviour `OnValidate()`
  - `enum CharacterClass { Paladin, Wizard, Barbarian, Necromancer }`
- Presenter in Scripts/UI
  - Screens
    - `[RequireComponent(typeof(UIDocument))] public class GameScreen.cs : MonoBehaviour`
  - UIViews
    - `HomeView.cs : UIView : IDisposable`
  - Controllers
    - `HomeScreenController.cs : MonoBehaviour`: non-UI logic for the HomeScreen
  - Events:
    - `static class HomeEvents.cs`: delegates with `HomeScreen/HomeScreenController`
  - Components
    - `partial class HealthBarComponent.cs : VisualElement`
- Ref case
  - View
    - `MainLayout.uxml`, `RoleStyle.uss`
  - Controller
    - `RoleView.cs : VisualElement`
  - Model
    - 等級數據: `LevelData { public int maxHP; public attack; } `
    - 角色容器: `RoleData.cs : ScriptableObject`:
      - 等級數據: `[SerializedField] List levelData`
      - CSV/JSON 配置: `[SerializedField] TextAsset levelDataFile`
    - 角色選擇器: `RoleLoader.cs : MonoBehaviour`

### Scene

- MainMenu
- GameHome

### View: UI Toolkit (Uxml + Uss) + Scripts/UI/UIViews/*.cs

- Screen > Panel > Modal
  - HomeScreen, GameScreen
  - CharacterScreen, SettingsScreen, MailScreen, ShopScreen
  - MenuBar, Inventory
- [Uxml & Uss container](https://github.com/androchentw/unity-tutorial-projects/blob/main/dragon-crashers/Assets/UI/Uxml/HomeScreen.uxml)
  - UI/Uxml/ShopScreen.uxml > [UI/Uxml/Resources/ShopItem.uxml](https://github.com/androchentw/unity-tutorial-projects/blob/2e8c7ef62c470c456ad671b44f20b6d0f60acb1c/dragon-crashers/Assets/UI/Uxml/Resources/ShopItem.uxml#L2)
  - `Scripts/UI/UIViews/*.cs : UIView : IDisposable`

### Model: GameObject.asset + ScriptableObject.cs

- 1-1 mapping of `Resources/GameData/*GameObject.asset` + `Scripts/GameDataSO/*.cs`
  - CharacterSO
    - [Resources/GameData/Characters/SirJarek.asset](https://github.com/androchentw/unity-tutorial-projects/blob/main/dragon-crashers/Assets/Resources/GameData/Characters/SirJarek.asset)
    - [Scripts/ScriptableObjects/CharacterBaseSO.cs](https://github.com/androchentw/unity-tutorial-projects/blob/main/dragon-crashers/Assets/Scripts/ScriptableObjects/CharacterBaseSO.cs)
  - SkillSO
    - [Resources/GameData/Skills/BarbarianSkill1.asset](https://github.com/androchentw/unity-tutorial-projects/blob/main/dragon-crashers/Assets/Resources/GameData/Skills/BarbarianSkill1.asset)
    - [Scripts/ScriptableObjects/SkillSO.cs](https://github.com/androchentw/unity-tutorial-projects/blob/main/dragon-crashers/Assets/Scripts/ScriptableObjects/SkillSO.cs)
  - ShopItemSO
    - [Resources/GameData/ShopItems/ShopItemBagOfGoldCoins.asset](https://github.com/androchentw/unity-tutorial-projects/blob/main/dragon-crashers/Assets/Resources/GameData/ShopItems/ShopItemBagOfGoldCoins.asset)
    - [Scripts/ScriptableObjects/ShopItemSO.cs](https://github.com/androchentw/unity-tutorial-projects/blob/main/dragon-crashers/Assets/Scripts/ScriptableObjects/ShopItemSO.cs)
- Features
  - `[CreateAssetMenu(fileName ="Assets/Resources/GameData/Characters/CharacterGameData", menuName = "UIToolkitDemo/Character", order = 1)]`
    - 讓 Unity Editor UI 能創建 `Character` GameObject
  - `[System.Serializable]`
  - `enum CharacterClass { Paladin, Wizard, Barbarian, Necromancer }`
  - MonoBehaviour `OnValidate()`
- Ref
  - [【Unity3D】UI Toolkit数据动态绑定](https://blog.csdn.net/m0_37602827/article/details/132815013)
    - View
      - `MainLayout.uxml`, `RoleStyle.uss`
    - Controller
      - `RoleView.cs : VisualElement`
    - Model
      - 等級數據: `LevelData { public int maxHP; public attack; } `
      - 角色容器: `RoleData.cs : ScriptableObject`:
        - `[SerializedField] private List levelData`
        - `[SerializedField] private TextAsset levelDataFile`: 一份 csv / json 供配置
      - 角色選擇器: `RoleLoader.cs : MonoBehaviour`

### Presenter in Scripts/UI

- [Code: Scripts/UI](https://github.com/androchentw/unity-tutorial-projects/tree/main/dragon-crashers/Assets/Scripts/UI)
- Screens
  - `[RequireComponent(typeof(UIDocument))] public class GameScreen.cs : MonoBehaviour`
- UIViews
  - `HomeView.cs : UIView : IDisposable`
- Controllers
  - `HomeScreenController.cs : MonoBehaviour`: non-UI logic for the HomeScreen
- Events
  - `static class HomeEvents.cs`: Public static delegates associated with the HomeScreen/HomeScreenController
    - Note: these are "events" in the conceptual sense and not the strict C# sense
- Components
  - `partial class HealthBarComponent.cs : VisualElement`:  A custom VisualElement that displays a health bar with a title, showing current and maximum health as a progress bar.

### GameObject: Scripts/Gameplay/*.asset
