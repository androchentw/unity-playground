# Unity Data Management

<!-- TOC -->
* [Unity Data Management](#unity-data-management)
  * [ScriptableObject: 資料容器](#scriptableobject-資料容器)
  * [JSON](#json)
  * [Comparison](#comparison)
  * [enum const json](#enum-const-json-)
<!-- TOC -->

## ScriptableObject: 資料容器

- [【阿空】Unity的可編程物件：ScriptableObject！ ( ScriptableObject in Unity!)](https://www.youtube.com/watch?v=0nW5PhQTWbQ)
- [Unity手札 初探ScriptableObject](https://chrislin1015.medium.com/unity%E6%89%8B%E6%9C%AD-%E5%88%9D%E6%8E%A2scriptableobject-3827b6f30740)
- [Unity學習筆記#8 : Scriptable Object使用須知](https://kendevlog.wordpress.com/2017/11/10/unity%E5%AD%B8%E7%BF%92%E7%AD%86%E8%A8%988-scriptable-object%E4%BD%BF%E7%94%A8%E9%A0%88%E7%9F%A5/)
  - `ScriptableObject` 是數據容器，而 `MonoBehaviour` 是加強 GameObject 的控制
  - `MonoBehaviour` 必須依附在 `GameObject` 才能使用，但 `ScriptableObject` 不用；
  - `MonoBehaviour` 在依附在 `GameObject` 後，拉到 Assets Folder 成為 `Prefab`, 而 `ScriptableObject` 透過 CreateAssetMenu 成為 Assets 中的資源;
  - 道具界面 `ItemView` 是用 `MonoBehaviour` 寫成的 Script, 有一個屬性 `"Data"` 來讓設計者定義 item 數據；
  - 道具界面 `ItemView` 在 `Start` 的時候，會根據綁定了的 `ItemData` 來更改界面;
- [ScriptableObject（可编程对象）为团队和代码带来的六个好处](https://unity.com/cn/blog/engine-platform/6-ways-scriptableobjects-can-benefit-your-team-and-your-code)
  - https://github.com/UnityTechnologies/PaddleGameSO
  - 數據容器
  - https://unity.com/blog/games/systems-that-create-ecosystems-emergent-game-design
  - https://unity.com/blog/games/unpredictably-fun-the-value-of-randomization-in-game-design
  - https://unity.com/resources/game-designer-playbook
  - https://www.gameprogrammingpatterns.com/flyweight.html
  - `ScriptableObject` 长于储存静态数据，是配置物品或NPC面板数据、角色对话等等静态数值的便利手段。它们会被储存为资产，脱离于游戏本身持续存在，其中的静态配置在加载后可于运行时动态地变化。
  - 尽管 `ScriptableObject` 数据的更改的确可在编辑器内长期存在，但它们并不适合用于保存游戏数据。倘若游戏性能非常关键，类似JSON、XML或二进制文件等序列化系统会是更好的选择。
  - `ScriptableObject` 可以减少内存痕迹，抛弃 GameObject 和 Transform，将数据储存为项目文件，方便从多个场景访问相同的数据。将数据储存为项目文件，方便从多个场景访问相同的数据。
  - Enum 类
  - 委托对象
  - https://www.youtube.com/watch?v=cHUXh5biQMg
  - 事件频道
  - https://unity.com/how-to/create-modular-and-maintainable-code-observer-pattern
  - Runtime Set（运行时设置）
- Best Practice
  - https://unity.com/how-to
  - https://unity.com/resources/create-modular-game-architecture-with-scriptable-objects-ebook
  - https://unity.com/blog/engine-platform/clean-up-your-code-how-to-create-your-own-c-code-style
  - https://unity.com/blog/games/level-up-your-code-with-game-programming-patterns
  - https://unity.com/resources/level-up-your-code-with-game-programming-patterns###
- [Unity — uEvent & Custom ScriptableObjects](https://link.medium.com/fehH2xLCe8)

## JSON

* [JSON Serialization](https://docs.unity3d.com/Manual/json-serialization.html)
* [odin-serializer](https://github.com/TeamSirenix/odin-serializer)

## Comparison

我的理解:

- Prefab 是製作 GameObject 的工廠, 可以快速產出 GameObject in Scene
- ScriptableObject 是儲存 Data 用的一種型態. 比如說 sword 的數值[ { name: a, atk: 10 }, { name: b, atk: 20} ]. 可以用來快速編輯(SerializedField) (但跨 scene 就會被重置 default?)
- [Scriptable Objects vs Prefabs](https://www.reddit.com/r/Unity3D/comments/134qpok/scriptable_objects_vs_prefabs/)
  - Now why you want them: The value of SOs comes in when you have many-to-many relationships. My spell example before you can easily do by just putting all these settings into fields on the character. But what do you do if the player can choose from 10 different characters in your game? Then if you want to change the VFX, you will have to change it 10 times. If you used a SO for each spell, then all the spell settings are stored in one location and you avoid that extra editing effort.
- [ScriptableObject Unity, When and how to use.](https://www.youtube.com/watch?v=IB14q9EQrVQ)
- [Prefabs VS Scriptable Objects - Spikarian #unity3d](https://www.youtube.com/watch?v=im2RQ9x47nE)
- [Indie Game Devlog 2 - Item System, ScriptableObjects & Saving JSON](https://www.youtube.com/watch?v=xgJ_Q0leKlE)
- [What are the pros and cons of ScriptableObjects vs. JSON for data files?](https://discussions.unity.com/t/what-are-the-pros-and-cons-of-scriptableobjects-vs-json-for-data-files/200754/2)

## enum const json 