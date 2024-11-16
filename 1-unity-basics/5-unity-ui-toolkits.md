# Unity UI Toolkits

<!-- TOC -->
* [Unity UI Toolkits](#unity-ui-toolkits)
  * [🥇 UI Toolkit Sample](#-ui-toolkit-sample)
  * [Others](#others)
  * [阿嚴 YouTube 教學](#阿嚴-youtube-教學)
    * [新功能](#新功能)
    * [UI Toolkit基礎教程](#ui-toolkit基礎教程)
    * [數據驅動基礎教程](#數據驅動基礎教程)
  * [其他](#其他)
<!-- TOC -->

## 🥇 UI Toolkit Sample

- [5-unity-ui-toolkits-QuizU.md](5-unity-ui-toolkits-QuizU.md)
- [Dragon Crashers](/2-unity-assets-collection/tutorial-projects/dragon-crashers.md)

## Others

- [【Unity Devlog開發日誌】強大的UI管理工具 - UI框架](https://www.youtube.com/watch?v=JvKUhK0ZLD4)
- [Using Unity UI Toolkit](https://www.youtube.com/watch?v=pqSwaqJmYwk&list=PL5domiITryHhlCKPSpiGuUt_kQg0nk3Of&index=5)
- [【筆記】視覺物件與工具開發](https://angus945.github.io/learn/unity/visual-element/)

## 阿嚴 YouTube 教學

### 新功能

- [Unity UI 工具包 新功能教程](https://ryanxudev.github.io/#tutorials)
  - [第一部分](https://www.youtube.com/watch?v=cbQJq_O3ZEo) - 在 UI 构建器里绑定数据 (推薦 綁定 SO)
    - Inspector > Data Source > ScriptableObject > Add Binding > Data Source Path
  - [第二部分](https://www.youtube.com/watch?v=eBda493MQHo) - 另外两种数据绑定方式
    - `[CreateProperty] string CharacterLevelString => $"Level: {characterLevel}";`; `[DontCreateProperty]` 減少錯誤標示
    - [BindingMode](https://docs.unity3d.com/6000.0/Documentation/Manual/UIE-runtime-binding-mode-update.html)
      - TwoWay: 洗點. UI data 互相影響
      - ToSource: UI 改 data. 如 音量滑動條
      - ToTarget: 最常用. 當 data 有變動時, 單向改變 UI 顯示
      - ToTargetOnce: UI 只更新一次. 如成就 UI
    - 第二種方法: 直接改 UXML (效果同 Unity 操作)
    - 第三種方法: 用 C# 寫 data binding. 比較複雜/靈活需要彈性時. runtime 才會顯示
  - [第三部分](https://www.youtube.com/watch?v=Z9AVTt4zZck) - 更简便地创建自定义控件
    - 自訂血條

### UI Toolkit基礎教程

- [Script template](https://www.youtube.com/watch?v=uh9bDTX9T5E)
  - UnityInstallPath/Editor/Data/Resources/ScriptTemplates/*.txt
  - Assets > ScriptTemplates
- [UI Toolkit基礎教程 Part 1 | 如何使用UI Toolkit | UI工具包 | JRPG 教程項目前置](https://www.youtube.com/watch?v=CfQL0cI-zPc)
  - UI Toolkit > UGUI: [各有擅場](https://docs.unity3d.com/2022.2/Documentation/Manual/UIElements.html)
  - UGUI: GameObject based, prefab workflow
  - Window > UIToolkit > UI Builder or Assets > Data > UIDocuments > UXML(Content), USS (Style), Behavior(C#)
  - Screen Overlay UI: 像是手機/網頁 box model (FlexBox)
- [Part 2 | UI的布局和樣式](https://www.youtube.com/watch?v=wZP47DZcAzM)
  - Layout, Container (Panel); Flex basis (25%) / grow (1), background, border, Margin/Padding, Text
- 配色: [FlatColors](https://flatuicolors.com/), [Colors](https://coolors.co/palettes/trending)
- [Part 3 | 為什麽我們應該學習並使用UI Toolkit](https://www.youtube.com/watch?v=PimLImYQFz0)
  - Panel: sort order, scale mode, reference resolution; source asset => UXML
  - Data binding: `getComponent<UIDocument>().rootVisualElement`
  - 高性能, 高適用性

### 數據驅動基礎教程

- [UI Toolkit - UQuery | 如何查找UI元素 | 數據驅動基礎教程 Part 1](https://www.youtube.com/watch?v=DOn8P5Fg0gg)
  - 找所有: `rootVisualElement.Query<Label>("").ForEach(object => object.text = "name")`
  - 找第一個: `rootVisualElement.Q<Label>("").ForEach(object => object.text = "name")`
  - Texture2D
- [UI Toolkit - Custom Controls | 自定義UI元素 | 角色數據類 | 數據驅動基礎教程 Part 2](https://www.youtube.com/watch?v=a0EbiuDE3nI)
- [UI Toolkit - Data Binding | 数据驱动基础教程 Part 3](https://www.youtube.com/watch?v=SRqwuwc_o0E)
- [使用Excel等製表工具簡化數據輸入 | 數據驅動基礎教程 Part 4](https://www.youtube.com/watch?v=b90awFcUJ60)
- [數據輸出 | UI Toolkit Manipulator & Events System | 數據驅動基礎教程 Part 5](https://www.youtube.com/watch?v=11zqHk6kbhE)

## 其他

- [使用Rule Tiles（规则瓦片）快速创建游戏场景](https://www.youtube.com/watch?v=LWTjXPBJ1Us)
