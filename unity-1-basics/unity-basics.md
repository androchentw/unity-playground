# Unity Basics

<!-- TOC -->
* [Unity Basics](#unity-basics)
  * [Basic Concepts](#basic-concepts)
  * [unity-essentials: Unity Learn 官方教程實作](#unity-essentials-unity-learn-官方教程實作)
  * [Unity 2D 基礎 UI 元件](#unity-2d-基礎-ui-元件)
  * [MonoBehaviour](#monobehaviour)
  * [Prefabs: 預製品](#prefabs-預製品)
  * [Time 時間控制](#time-時間控制)
  * [Coroutine 協程](#coroutine-協程)
  * [Switch Scene 切換場景](#switch-scene-切換場景)
<!-- TOC -->

## Basic Concepts

- 非電玩人學 Unity3D
  - [(1) 從原子開始](https://medium.com/@wuufone/%E9%9D%9E%E9%9B%BB%E7%8E%A9%E4%BA%BA%E5%AD%B8unity3d-%E5%BE%9E%E5%8E%9F%E5%AD%90%E9%96%8B%E5%A7%8B-adc92f13da0)
    - `MonoBehaviour` 具備動畫、影格、時間軸的概念. 與人互動, 與系統互動
  - [(2) 認透 GameObject 與 Component](https://medium.com/@wuufone/%E9%9D%9E%E9%9B%BB%E7%8E%A9%E4%BA%BA%E5%AD%B8unity3d-2-%E8%AA%8D%E9%80%8F-gameobject-%E8%88%87-component-ba95a5502bce)
    - `GameObject` 對應到的 C# Script 為 `MonoBehaviour`
  - [(3) 探索腳本生命周期](https://medium.com/@wuufone/%E9%9D%9E%E9%9B%BB%E7%8E%A9%E4%BA%BA%E5%AD%B8unity3d-3-%E6%8E%A2%E7%B4%A2%E8%85%B3%E6%9C%AC%E7%94%9F%E5%91%BD%E5%91%A8%E6%9C%9F-9366d449ff92)
    - `Update`
  - [(4) 輸入控制](https://medium.com/@wuufone/%E9%9D%9E%E9%9B%BB%E7%8E%A9%E4%BA%BA%E5%AD%B8unity3d-4-%E8%BC%B8%E5%85%A5%E6%8E%A7%E5%88%B6-c141363247f9)
    - `GetKey`
    - `[SerializeField] `
  - [(5) Sprite](https://medium.com/@wuufone/%E9%9D%9E%E9%9B%BB%E7%8E%A9%E4%BA%BA%E5%AD%B8unity3d-5-sprite-6e4fab762775)
    - 整合圖像
    - Sprites-Sheet
    - <img width="400px" alt="" src="https://miro.medium.com/v2/resize:fit:1280/format:webp/1*EcsRdUHAQafyj6eEsRHcFQ.png">
  - [(6) 從塗料到材質](https://medium.com/@wuufone/%E9%9D%9E%E9%9B%BB%E7%8E%A9%E4%BA%BA%E5%AD%B8unity3d-6-%E5%BE%9E%E5%A1%97%E6%96%99%E5%88%B0%E6%9D%90%E8%B3%AA-ef2207328078)

## unity-essentials: Unity Learn 官方教程實作

- [Unity Playground: 入門教程](https://learn.unity.com/project/unity-playground)
- [unity-essentials](https://github.com/androchentw/unity-essentials)
- Project > Assets > _Unity Essentials > Scenes
- 介面: Hierarchy > `GameObjects`
  - Hierarchy window displays all the GameObjects in the current scene
  - Inspector: property
- 操控
  - Play Mode: WASD
  - Flythrough mode: Right click + WASD
  - 旋轉
    - The red X-axis
    - The green Y-axis
    - The blue Z-axis
    - Global, Local (selected object)
  - 視角: Perspective / Isometric mode
- Audio Listener: Audio Resource
  - 3D spatialize. `Spatial Blend` from 0 (fully 2D) to 1 (fully 3D).
- Background Music
  - _Unity Essentials > Audio > Music
  - Play on Awake
  - Component: Play Sound at Random Intervals
- Programming
  - Add a movement script
    - Create `MonoBehaviour` Script: Player Controller > Attached to Object
    - Main Camera
    - collectible GameObject
  - Create a rotating object
    - `public float rotationSpeed = 0.5f;`
  - Collect the collectible
    - `void OnTriggerEnter(Collider other) { Destroy(gameObject); }`
  - Visual Effects (VFX)
  - Programming Essentials: More things to try
    - Jump
    - Door Opener: Box Collider
    - Expert: Use generative AI to simulate sunrise and sunset

## Unity 2D 基礎 UI 元件

- [ChatGPT](https://chatgpt.com/share/67072bee-968c-800f-86df-9598ef0d83ee)
- 文字 UI.Text
- 按鈕 UI.Button / TextMeshPro (可點擊文字). onClick
  - 動作: Application.OpenURL(), Switch Scene
  - 解析度: Canvas Scaler
  - 點擊動畫: [DoTween](https://assetstore.unity.com/packages/tools/animation/dotween-hotween-v2-27676?source=post_page-----307b9682dbd8--------------------------------), [LeanTween](https://assetstore.unity.com/packages/tools/animation/leantween-3595?srsltid=AfmBOood7jjHDyBQ6p4Oxfr5-6_eamp16nUr29xV-NhBiiwqzE9gHvss)
    - [Unity筆記 手把手帶你走進DOTween的世界](https://medium.com/ericzhan-publication/unity%E7%AD%86%E8%A8%98-%E6%89%8B%E6%8A%8A%E6%89%8B%E5%B8%B6%E4%BD%A0%E8%B5%B0%E9%80%B2dotween%E7%9A%84%E4%B8%96%E7%95%8C-307b9682dbd8)
- 彈窗: NativePopup, Messagebox
  - [unity-mobile-dialog-popup-native](https://github.com/khanhuitse05/unity-mobile-dialog-popup-native)
  - [unity-os-native-popup](https://github.com/yeosu0107/unity-os-native-popup)    
- 選單: [Menu with Tab UI](https://chatgpt.com/share/67073179-8334-800f-83cb-e86daf6ac355)
- 進度條: UI.Image -> RectTransform -> Filled (Horizontal)
  - Progressbar
- 開關 UI.Toggle. onValueChanged
- 輸入: UI.InputField. onValueChanged, onEndEdit
- 選擇: UI.Dropdown. OnDropdownValueChanged
- 倒數
  - countdownText, StartCountdown
  - UpdateCountdowns, OnCountdownFinished
  - totalTime, hh:mm:ss
  - buildingTexts[], buildingQueue, AddBuildingToQueue
- Loading: UI.Image.Sprite. transform.Rotate
  - Error, Reload

## MonoBehaviour

- [Unity MonoBehaviour 事件函式的生命週期](https://xunyi-huang.com/2020/09/04/unity-monobehaviour-%E4%BA%8B%E4%BB%B6%E5%87%BD%E5%BC%8F%E7%9A%84%E7%94%9F%E5%91%BD%E9%80%B1%E6%9C%9F/)
  - <a href="https://docs.unity3d.com/Manual/execution-order.html" target="_blank" rel="noreferrer noopener"><img width="600px" alt="Script lifecycle flowchart" src="https://docs.unity3d.com/uploads/Main/monobehaviour_flowchart.svg"></a>
- [资源工作流程](https://docs.unity3d.com/cn/2023.2/Manual/AssetWorkflow.html)
  - <img width="600px" alt="" src="https://docs.unity3d.com/cn/2023.2/uploads/Main/AssetWorkflowOverview.svg">
- [遊戲程式設計與Unity3D引擎初步認識(四)](https://home.gamer.com.tw/creationDetail.php?sn=2491667)
- Awake (exact 1) -> Start (active切換)
  - FixedUpdate(固定時間, 物理計算) -> Update (per frame) -> LateUpdate
  - yield (WWW, StartCoroutine, …)
  - OnDisable -> OnDestroy

## Prefabs: 預製品

- Unity學習筆記#6 : Prefab 使用須知 
- Unity Prefabs 之使用方式筆記
- Dynamically Create Game Objects 
  - Instantiating prefabs at runtime
  - Dynamically create Game Objects and Components in Unity

## Time 時間控制

- [GAI - Unity 時間控制系統設計](https://chatgpt.com/share/670e7420-b69c-800f-8371-8b09cf878e42): TimeController.cs 
  - 資源生成計時器: Unity計時系統，搭配 Coroutine + Time.deltaTime
  - 伺服器同步: Unity Web Request搭配Google Cloud Function
  - 建築排隊系統: ScriptableObject管理本地資料，並定期同步伺服器
  - 通知系統: Unity Notification Plugin (跨平台推播套件 or Firebase )
  - 伺服器同步：利用伺服器的真實時間校正本地計時，避免時間操控的問題。可以定期將倒數狀態同步到伺服器，並在場景切換或應用關閉時進行保存。
  - 作弊防護: 定時伺服器校驗（GCP雲函數或Firestore Rules）
- Timer
  - 有套件, 直接用就好
  - [UnityTimer](https://github.com/akbiggs/UnityTimer/tree/master) 
  - Real world timer: DateTime
  - [Unity: How to Make Real World Timer C#](https://www.youtube.com/watch?v=GW3HdL43cVM)
  - [Get Real World Current Time In Unity](https://www.youtube.com/watch?v=TwtDpSmozRs)

## Coroutine 協程

- 用途: 計時, 流程控制
- 另一個獨立 thread (但不是多執行緒)
- [【阿空】Unity 協程Coroutine！？大解析！](https://www.youtube.com/watch?v=z1myiS1z7Ek)
  - `IEnumerator Task() { yield return new WaitForSeconds(1); }`
  - `Start() { StartCoroutine(Task()); }`
- [Unity Coroutine 使用筆記](https://dev.twsiyuan.com/2017/05/unity-coroutine.html): yield return null / WaitWhile, …
- [Unity Engine Coroutine協程](https://dev.twsiyuan.com/2017/05/unity-coroutine.html)
   - Nested Coroutine
   - Parallel Coroutine
     - <img width="600px" src="https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEhrLmP1QGEKWb_estzs35SnLIY5gKu0yUmFOGn0MAv_HtHxwYogS5ylhDPCNjqBVaLwO4GX_wpBJ7yT73NYBMYdhC15K6FHSukzqRLxkyhOvLo4Zhco22WIXzMpZgqAKILmTNbLh6cLueU/s780/coroutine-parallel-working-flow.png" alt="coroutine-parallel-working-flow.png">
   - 無法預期要多少時間時，使用AsyncOperation衍生類別:
   - SceneManager.LoadSceneAsync()：載入場景
   - AssetBundle.LoadAssetAsync()：載入 AssetBundle
   - Resources.LoadAsync()：從 Resources 目錄載入各種資源
- `yield async await`

## Switch Scene 切換場景

- [Unity教學：UI設計與場景管理交換](https://youtu.be/DQSTxRylGtI?si=H3GyzYplp0NRueOz)
  - Build Settings > Add scene 順序
  - C# `SceneManager.LoadScene(0)`
