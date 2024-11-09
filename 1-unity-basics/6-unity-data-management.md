# Unity Data Management

<!-- TOC -->
* [Unity Data Management](#unity-data-management)
  * [ScriptableObject](#scriptableobject)
  * [JSON](#json)
  * [Comparison](#comparison)
  * [enum const json](#enum-const-json-)
<!-- TOC -->

## ScriptableObject

- [6-unity-scriptable-object.md](6-unity-scriptable-object.md)

## JSON

* [JSON Serialization](https://docs.unity3d.com/Manual/json-serialization.html)
* [odin-serializer](https://github.com/TeamSirenix/odin-serializer)

## Comparison

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

## enum const json 
