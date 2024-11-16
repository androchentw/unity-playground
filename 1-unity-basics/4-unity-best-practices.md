# Unity Best Practices

- Ref: [3-unity-folder-structure.md](3-unity-folder-structure.md)

<!-- TOC -->
* [Unity Best Practices](#unity-best-practices)
  * [C# General](#c-general)
  * [Code Style Guide](#code-style-guide)
  * [Unity General](#unity-general)
  * [Game Design](#game-design)
  * [Unity DOTS 提升效能](#unity-dots-提升效能)
  * [LiveOps](#liveops)
<!-- TOC -->

## C# General

- [Day15 物件導向封裝性-Get & Set 存取器](https://ithelp.ithome.com.tw/articles/10223760)
- [Unity C# | Tag和Layer差異與特性 & 抓取Tag物件](https://vocus.cc/article/6203a9b8fd897800014ad1dd)
  - `GameObject respawn = GameObject.FindWithTag("...");`
  - `GameObject [] respawns = GameObject.FindGameObjectsWithTag("...");`

## Code Style Guide

- [C# Coding Standards and Naming Conventions](https://github.com/ktaranov/naming-convention/blob/master/C%23%20Coding%20Standards%20and%20Naming%20Conventions.md)
  - 幾乎都是 PascalCase (包含 Class, Function, PublicMember)
  - 除了 localVar 或 _privateVar, s_privateStatic
  - [Microsoft: C# 識別碼命名規則和慣例](https://learn.microsoft.com/zh-tw/dotnet/csharp/fundamentals/coding-style/identifier-names)
- [Create a C# style guide: Write cleaner code that scales](https://unity.com/resources/create-code-c-sharp-style-guide-e-book?ungated=true)
- [Unity C# | 命名法則 & 低耦合、高內聚](https://vocus.cc/designer/61fe9831fd897800014eedda)
- [Unity-Code-Style-Guide](https://github.com/androchentw/Unity-Code-Style-Guide)
- [Formatting best practices for C# scripting in Unity](https://unity.com/how-to/formatting-best-practices-c-scripting-unity)
- [Unity Coding guidelines & Basic Best Practices](https://avangarde-software.com/unity-coding-guidelines-basic-best-practices/)
- [unity-best-practices](https://github.com/androchentw/unity-best-practices/tree/andro): Unity Best Practices for C# Design Patterns.

## Unity General

- [Unity best practices](https://unity.com/how-to)
- [Best practices for project organization and version control (Unity 6 edition)](https://unity.com/resources/best-practices-version-control-unity-6)

## Game Design

- [The Unity Game Designer Playbook](https://unity.com/resources/game-designer-playbook)
  - [Systems that create ecosystems: Emergent game design](https://unity.com/blog/games/systems-that-create-ecosystems-emergent-game-design)
  - [Unpredictably fun: The value of randomization in game design](https://unity.com/blog/games/unpredictably-fun-the-value-of-randomization-in-game-design)
- [Introduction to game level design](https://unity.com/resources/introduction-to-level-design-in-game-development-and-in-unity)
- [2D game art, animation, and lighting for artists](https://unity.com/resources/2d-game-art-animation-lighting-for-artists-ebook?isGated=false)
- [Best practices for managing elements](https://docs.unity3d.com/Manual/UIE-best-practices-for-managing-elements.html)
- [Mobile game design with Unity](https://unity.com/topics/mobile-game-design)
- [Optimize your game performance for mobile, XR, and the web in Unity (Unity 6 edition)](https://unity.com/resources/mobile-xr-web-game-performance-optimization-unity-6)
  - [GenAI NoteBook LLM Summary](https://notebooklm.google.com/notebook/10e53e23-00fa-49ee-bff4-b27ee0ccf4e7)

## Unity DOTS 提升效能

- [【阿空】一次搞懂 Unity DOTS 與 JobSystem！ ( Unity DOTS and JobSystem! )](https://www.youtube.com/watch?v=AY3Ejgyv9Ss)
  - [Unity-DOTS-Tutorial](https://github.com/emptygamer/Unity-DOTS-Tutorial)
- [【阿空】Unity ECS 概念與基本操作！ ( 2022 Unity ECS v0.51)](https://www.youtube.com/watch?v=_kda6k_WIqY)
- Unity Official Docs
  - [Unity’s Data-Oriented Technology Stack (DOTS)](https://unity.com/dots): ECS + C# Job System + Burst Compiler
  - [Start learning data-oriented design in Unity with these resources](https://unity.com/blog/engine-platform/dots-bootcamp-resources)
  - [Entities overview](https://docs.unity3d.com/Packages/com.unity.entities@1.3/manual/index.html)
  - [EntityComponentSystemSamples](https://github.com/Unity-Technologies/EntityComponentSystemSamples)
  - [Introduction to the Data-Oriented Technology Stack for advanced Unity developers](https://unity.com/resources/introduction-to-dots-ebook)
- [Unity ECS —— 蜻蜓點水](https://medium.com/遊戲開發隨筆/unity-ecs-蜻蜓點水-e259ccf02d09)
- [Unity DOTS – A Case Study of Brick Breaker](https://tedsieblog.wordpress.com/2020/03/17/unity-dots-a-case-study-of-brick-breaker/)
- [The Future of Game Development: Data-Oriented vs Object-Oriented](https://medium.com/@canernurdag/the-future-of-game-development-data-oriented-vs-object-oriented-e92e146dad4c)
- [淺談多執行緒程式設計與Unity的C# Job System](https://medium.com/akatsuki-taiwan-technology/淺談多執行緒程式設計與unity的c-job-system-19e4d5ca59dd)
- [Unity 利用C# Job System與Burst Compiler來解放CPU的效能](https://medium.com/akatsuki-taiwan-technology/unity-利用c-job-system與burst-compiler來解放cpu的效能-c9447357a076)
- [開始使用Unity的C# Job System(一)](https://medium.com/@eric.hu/開始使用unity的c-job-system-一-78b72b1e96bd)

## LiveOps

- [From DevOps to LiveOps in one platform](https://unity.com/solutions/gaming-services)
  - Build your foundation: Accounts, Multiplayer, Content management, DevOps
  - Engage your players: Analytics, Player engagement, Community, Crash reporting
  - Grow your game: Monetization, User acquisition, Ad mediation, Publishing, Game economy
- [Use LiveOps to get the insights you need for a better player experience](https://unity.com/solutions/gaming-services/player-insights)
- [Power-up your live ops strategy for better player retention](https://unity.com/solutions/gaming-services/continuous-game-improvements)
- [IndieXP: Making the Most of Launch](https://create.unity.com/making-the-most-of-launch)
- [Indie XP: Building a live service and measuring success](https://create.unity.com/how-to-turn-your-mobile-game-into-a-successful-business)
- [5 best practices for maximizing long-term player value with Unity Analytics](https://unity.com/how-to/maximizing-long-term-player-value-unity-analytics)
- [使用 Unity 遊戲服務來開發多人與營運型遊戲 | 2022 TGDF 台北遊戲開發者論壇](https://hackmd.io/@samuel-t-chou/2022-TGDF/%2Fs%2FTeBfn7ePQISPDBHNXxnDjA)
