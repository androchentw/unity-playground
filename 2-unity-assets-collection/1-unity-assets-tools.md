# Unity Assets - Tools

<!-- TOC -->
* [Unity Assets - Tools](#unity-assets---tools)
  * [Editor UI](#editor-ui)
  * [Editor Utility (Later)](#editor-utility-later)
  * [Gameplay System](#gameplay-system)
  * [Runtime UI](#runtime-ui)
  * [Input Management](#input-management)
  * [Animation](#animation)
  * [Dialog System](#dialog-system)
<!-- TOC -->

## Editor UI

- [Colourful Hierarchy Category GameObject](https://assetstore.unity.com/packages/tools/utilities/colourful-hierarchy-category-gameobject-205934): Hierarchy 介面優化
  - 用 GameObject 將 hierarchy 開發視窗顏色分類
    - 在 M Studio > Colourful > Color Palette 編輯 Symbol 跟對應顏色
  - Rename GameObject begins with YOUR SYMBOL (比如 $ 或//), GameObject 就會自動加上顏色
- [Hierarchy Designer](https://assetstore.unity.com/packages/tools/utilities/hierarchy-designer-273928): Hierarchy 介面優化
- [Project Browser Pro](https://assetstore.unity.com/packages/tools/gui/project-browser-pro-248141): Unity 介面優化
- Later
  - [In-game Debug Console](https://assetstore.unity.com/packages/tools/gui/in-game-debug-console-68068)
    - [Readme](https://github.com/yasirkula/UnityIngameDebugConsole)
    - Debug console: see debug messages runtime in a build
  - [Graphy - Ultimate FPS Counter - Stats Monitor & Debug](https://assetstore.unity.com/packages/tools/gui/graphy-ultimate-fps-counter-stats-monitor-debugger-105778)
    - [Readme](https://github.com/Tayx94/graphy)
    - 系統 FPS 監控, Debug
    - Drag the prefab from “Graphy - Ultimate Stats Monitor/Prefab” into the scene you want!

## Editor Utility (Later)

- [Fast Script Reload](https://assetstore.unity.com/packages/tools/utilities/fast-script-reload-239351): 快速讀取
  - Not available in mac silicon yet
- [Turbo Rename](https://assetstore.unity.com/packages/tools/utilities/turbo-rename-131169): 批次更名
- [Serialize Reference Editor](https://assetstore.unity.com/packages/tools/utilities/serialize-reference-editor-297559)
  - 優化資料操作
    - Convenient property drawer for fields marked with the SerializeReference attribute for serializing custom data types into Prefabs and Scriptable Objects.
- [Mighty DevOps - Minimap, Bookmarks, Screenshot](https://assetstore.unity.com/packages/tools/utilities/mighty-devops-minimap-bookmarks-screenshots-and-more-267512)
  - Readme: MightyDevOps/Help/pdf
  - Free mini-map asset for scene navigation and project completion
  - Scene Browser: 切換 scenes 找 object
  - Mighty Map: Gain insight with a bird’s-eye view of your project’s terrain.
  - Landmarks: 設定空間書籤. Screenshots: Play through your level and press the hotkey and SNAP!!
- [Extenject Dependency Injection IOC](https://assetstore.unity.com/packages/tools/utilities/extenject-dependency-injection-ioc-157735)
  - Dependency Injection framework 
  - Extenject: [Zenject Tutorial](https://github.com/modesttree/Zenject?tab=readme-ov-file#injection)

## Gameplay System

- [Translation system / I18N Plugin / Languages](https://assetstore.unity.com/packages/tools/localization/translation-system-i18n-plugin-languages-59716): 翻譯工具
- [Smart Timers Manager](https://assetstore.unity.com/packages/tools/integration/smart-timers-manager-55023)
  - 控制 timer. [Readme](https://seenax.com/AssetStore/SmartTimersManager/ReadMe.pdf)
  - GUI_TimersList component
  - `TimersManager.SetTimer(this, 5f, () => TimerFunc);`
- [ESave - Save System for Unity](https://assetstore.unity.com/packages/tools/utilities/esave-save-system-for-unity-283140)
  - 存檔系統
- [Loot Table - Universal Loot System](https://assetstore.unity.com/packages/tools/utilities/loot-table-universal-loot-system-234682)
  - 掉落管理. Readme: Loot Table > Doc.pdf
  - 比 [Simple Loot Table](https://assetstore.unity.com/packages/tools/utilities/simple-loot-table-241778) 評價高

## Runtime UI

- [Modern UI Pack](https://assetstore.unity.com/packages/tools/gui/modern-ui-pack-201717)
  - UI 元件
  - [Readme](https://docs.michsky.com/docs/modern-ui-pack/)
- [3D Modern Menu UI](https://assetstore.unity.com/packages/tools/gui/3d-modern-menu-ui-116144)
  - UI 配置設計
  - Readme: SlimUI > Doc.pdf

## Input Management

- [Simple Input System](https://assetstore.unity.com/packages/tools/input-management/simple-input-system-113033)
  - UI 操作控件, [Readme](https://github.com/yasirkula/UnitySimpleInput)
  - SimpleInput.GetButtonUp, SimpleInput.GetButtonDown
- [Lean Touch](https://assetstore.unity.com/packages/tools/input-management/lean-touch-30111)
  - 觸控操作, [Readme](https://carloswilkes.com/Documentation/LeanTouch)
  - Consistent input across desktop & mobile devices
  - Create GameObject > Lean > Touch
  - 動態產生: LeanSpawn > Dynamic LeanFinger > Spawn 
  - inputs delayed > Script Execution Order
- Later
  - [Short Scale String](https://assetstore.unity.com/packages/tools/input-management/short-scale-string-73007): 數字縮寫
  - [Joystick Pack](https://assetstore.unity.com/packages/tools/input-management/joystick-pack-107631): UI 操作控件

## Animation

- [DOTween (HOTween v2)](https://assetstore.unity.com/packages/tools/animation/dotween-hotween-v2-27676)
  - 動畫 轉場
  - [手把手帶你走進DOTween的世界](https://medium.com/ericzhan-publication/unity筆記-手把手帶你走進dotween的世界-307b9682dbd8)
  - [UI 動畫與轉場效果](https://tedliou.com/unity/ui-animation/)

## Dialog System
