# Unity Data Management

<!-- TOC -->
* [Unity Data Management](#unity-data-management)
  * [ScriptableObject vs. JSON](#scriptableobject-vs-json)
  * [ScriptableObject: Data Container](#scriptableobject-data-container)
  * [Unity Ebook: Create modular game architecture in Unity with ScriptableObjects](#unity-ebook-create-modular-game-architecture-in-unity-with-scriptableobjects)
  * [Unity: 6 ways ScriptableObjects can benefit your team and your code](#unity-6-ways-scriptableobjects-can-benefit-your-team-and-your-code)
    * [Data containers](#data-containers)
    * [Enums, Delegate objects](#enums-delegate-objects)
    * [Event channels](#event-channels)
    * [Runtime Sets](#runtime-sets)
  * [ScriptableObject Example](#scriptableobject-example)
    * [`CharacterStats.cs`](#characterstatscs)
    * [`Player.cs`](#playercs)
  * [JSON Example](#json-example)
    * [`Resources/characterData.json`](#resourcescharacterdatajson)
    * [`Utils/JsonLoader.cs`](#utilsjsonloadercs)
  * [Enum, Constant](#enum-constant)
  * [Thoughts](#thoughts)
  * [Addressable: DLC](#addressable-dlc)
<!-- TOC -->

## ScriptableObject vs. JSON

- 共通點: 集中管理資料, 易於編輯

| **比較項目**  | **ScriptableObject**                                       | **JSON**                      |
|-----------|------------------------------------------------------------|-------------------------------|
| **資料靜態性** | 適合**靜態**且不常變動的數據，如技能屬性、關卡設定                                | 適合**動態**且需要經常更新的數據，如伺服器配置、排行榜 |
| **使用方便性** | 可以直接在 Unity Inspector 編輯                                   | 需要透過程式碼動態載入與解析                |
| **效能**    | 載入速度快，因為是二進制資產. 且多個物件可以共享同一個 ScriptableObject 資料實例，減少重複數據。 | 較慢，因為需要從文字檔載入並反序列化            |
| **適用場景**  | 遊戲內**固定不變的設定**。技能樹、角色屬性                                    | 遊戲**外部資料**。玩家進度、遠端配置          |

## ScriptableObject: Data Container

- YouTube
  - [【阿空】Unity的可編程物件：ScriptableObject！ ( ScriptableObject in Unity!)](https://www.youtube.com/watch?v=0nW5PhQTWbQ)
  - [The Power of Scriptable Objects as Middle-Men](https://www.youtube.com/watch?v=qUYpQ8ySkLU)
  - [CLEAN Game Architecture with ScriptableObjects | Unity Tutorial](https://www.youtube.com/watch?v=wzPputN4Ts4)
    - Globally accessible and scene independent
- [Unity手札 初探ScriptableObject](https://chrislin1015.medium.com/unity手札-初探scriptableobject-3827b6f30740)
  - 可以跨場景與跨 Prefab 共用同一份
  - 可以轉換成 Asset Bundle
  - 可覆寫 Awake、OnEnable、OnDisable、OnDestroy
  - `[CreateAssetMenu]` 就可以在 Editor 的 Assets\Create 看到你所宣告的 ScriptableObject
  - ScriptableObject 檔案放在 Resources 資料夾, 使用 `Resources.Load()` 取用
- [Unity學習筆記#8 : Scriptable Object使用須知](https://kendevlog.wordpress.com/2017/11/10/unity學習筆記8-scriptable-object使用須知/)
  - `ScriptableObject` 是數據容器，而 `MonoBehaviour` 是加強 GameObject 的控制
  - `MonoBehaviour` 必須依附在 `GameObject` 才能使用，但 `ScriptableObject` 不用；
  - `MonoBehaviour` 依附在 `GameObject` 後，拉到 Assets Folder 成為 `Prefab`, 而 `ScriptableObject` 透過
    CreateAssetMenu 成為 Assets 中的資源;
  - 道具界面 `ItemView` 是用 `MonoBehaviour` 寫成的 Script, 有一個屬性 `"Data"` 來讓設計者定義 item 數據；
  - 道具界面 `ItemView` 在 `Start` 的時候，會根據綁定了的 `ItemData` 來更改界面;

## Unity Ebook: Create modular game architecture in Unity with ScriptableObjects

- [Create modular game architecture in Unity with ScriptableObjects](https://unity.com/resources/create-modular-game-architecture-with-scriptable-objects-ebook)
  - [PaddleBallSO](https://github.com/UnityTechnologies/PaddleGameSO)
- [Get started with the Unity ScriptableObjects demo](https://unity.com/how-to/get-started-with-scriptableobjects-demo)
- [Separate game data and logic with ScriptableObjects](https://unity.com/how-to/separate-game-data-logic-scriptable-objects)
- [Use ScriptableObject-based enums in your Unity project](https://unity.com/how-to/scriptableobject-based-enums)
- [Use ScriptableObjects as delegate objects](https://unity.com/how-to/scriptableobjects-delegate-objects)

## Unity: 6 ways ScriptableObjects can benefit your team and your code

- [6 ways ScriptableObjects can benefit your team and your code](https://unity.com/blog/engine-platform/6-ways-scriptableobjects-can-benefit-your-team-and-your-code)

### Data containers
- ScriptableObjects excel at storing static data, making them handy for configuring static gameplay values like items or NPC stats, character dialogue, and much more. Because ScriptableObjects are saved as an asset, they persist outside of game mode, making it possible to use them for loading in a static configuration that dynamically changes at runtime.
- While changes to ScriptableObject data do persist in the Editor, it’s important to note that they are not designed for saving game data. In that case, it’s better to use a serialization system, such as JSON, XML, or a binary solution if performance is critical.
- MonoBehaviours carry extra overhead since they require a GameObject – and by default a Transform – to act as a host. This means you need to create a lot of unused data before storing a single value. A ScriptableObject slims down this memory footprint and drops the GameObject and Transform. It also stores data at the project level, which is helpful if you need to access the same data from multiple scenes.

### Enums, Delegate objects

### Event channels

<img width="600px" src="https://unity.com/_next/image?url=https%3A%2F%2Fcdn.sanity.io%2Fimages%2Ffuvbjjlp%2Fproduction%2F741bc2c95a15caf3354801d56397f518da543ced-1020x574.png&w=2048&q=75" alt="The ScriptableObject-based event channel">

### Runtime Sets

<img width="400px" src="https://unity.com/_next/image?url=https%3A%2F%2Fcdn.sanity.io%2Fimages%2Ffuvbjjlp%2Fproduction%2Fbdbe57c6dc6a45a17f90931a94158cd5c5da5d18-1020x574.png&w=2048&q=75" alt="A Runtime Set provides global access to a collection of data">

## ScriptableObject Example

### `CharacterStats.cs`

```csharp
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterStats", menuName = "Game/CharacterStats")]
public class CharacterStats : ScriptableObject
{
    public string characterName;
    public int health;
    public int attackPower;
    public float moveSpeed;
}
```

### `Player.cs`

```csharp
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterStats stats;

    void Start()
    {
        Debug.Log($"Character: {stats.characterName}, Health: {stats.health}");
    }
}
```

## JSON Example

- [JSON Serialization](https://docs.unity3d.com/Manual/json-serialization.html)
- [odin-serializer](https://github.com/TeamSirenix/odin-serializer)

### `Resources/characterData.json`

```json
{
  "characters": [
    {
      "id": 1,
      "name": "Warrior",
      "health": 100,
      "attackPower": 15,
      "moveSpeed": 2.5
    },
    {
      "id": 2,
      "name": "Mage",
      "health": 80,
      "attackPower": 25,
      "moveSpeed": 1.8
    }
  ]
}
```

### `Utils/JsonLoader.cs`

```csharp
using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class Character
{
    public int id;
    public string name;
    public int health;
    public int attackPower;
    public float moveSpeed;
}

[System.Serializable]
public class CharacterData
{
    public List<Character> characters;
}

public class JsonLoader : MonoBehaviour
{
    public static CharacterData LoadCharacterData()
    {
        // 從 Resources 資料夾中載入 JSON 檔案
        TextAsset jsonData = Resources.Load<TextAsset>("characterData");
        if (jsonData != null)
        {
            // 反序列化 JSON 為 CharacterData 物件
            return JsonUtility.FromJson<CharacterData>(jsonData.text);
        }
        Debug.LogError("JSON file not found!");
        return null;
    }
}
```

## Enum, Constant

```csharp
public enum CharacterClass
{
    Warrior,
    Mage,
    Archer,
    Thief
}
```

```csharp
public static class GameConstants
{
    public const int MaxHealth = 100;
    public const float ExperienceMultiplier = 1.5f;
}
```

## Thoughts

我的理解:

- Prefab 是製作 GameObject 的工廠, 可以快速產出 GameObject in Scene
- ScriptableObject 是儲存 Data 用的一種型態. 比如說 sword 的數值[ { name: a, atk: 10 }, { name: b, atk: 20} ].
  可以用來快速編輯(SerializedField) (但跨 scene 就會被重置 default?)
- [Scriptable Objects vs Prefabs](https://www.reddit.com/r/Unity3D/comments/134qpok/scriptable_objects_vs_prefabs/)
  - Now why you want them: The value of SOs comes in when you have many-to-many relationships. My spell example before
    you can do by just putting all these settings into fields on the character. But what do you do if the player
    can choose from 10 different characters in your game? Then, if you want to change the VFX, you will have to change
    it
    10 times. If you used a SO for each spell, then all the spell settings are stored in one location, and you avoid
    that
    extra editing effort.
- [ScriptableObject Unity, When and how to use.](https://www.youtube.com/watch?v=IB14q9EQrVQ)
- [Prefabs VS Scriptable Objects - Spikarian #unity3d](https://www.youtube.com/watch?v=im2RQ9x47nE)
- [Indie Game Devlog 2 - Item System, ScriptableObjects & Saving JSON](https://www.youtube.com/watch?v=xgJ_Q0leKlE)
- [What are the pros and cons of ScriptableObjects vs. JSON for data files?](https://discussions.unity.com/t/what-are-the-pros-and-cons-of-scriptableobjects-vs-json-for-data-files/200754/2)

## Addressable: DLC

- [Get started with Addressables](https://learn.unity.com/course/get-started-with-addressables)
- [Getting started with Addressable Assets](https://docs.unity3d.com/Packages/com.unity.addressables@0.3/manual/AddressableAssetsGettingStarted.html)
