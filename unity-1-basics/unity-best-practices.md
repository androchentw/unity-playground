# Unity Best Practices

<!-- TOC -->
* [Unity Best Practices](#unity-best-practices)
  * [C# General](#c-general)
  * [Code Style Guide](#code-style-guide)
  * [Design Patterns](#design-patterns)
  * [DI (Dependency Injection), IoC C# unity](#di-dependency-injection-ioc-c-unity)
  * [Unity DOTS 提升效能](#unity-dots-提升效能)
  * [Mobile Game Design](#mobile-game-design)
  * [LiveOps](#liveops)
<!-- TOC -->

- Ref: [unity-folder-structure.md](unity-folder-structure.md)

## C# General

- [Day15 物件導向封裝性-Get & Set 存取器](https://ithelp.ithome.com.tw/articles/10223760)
- [Unity C# | Tag和Layer差異與特性 & 抓取Tag物件](https://vocus.cc/article/6203a9b8fd897800014ad1dd)
  - `GameObject respawn = GameObject.FindWithTag("...");`
  - `GameObject [] respawns = GameObject.FindGameObjectsWithTag("...");`

## Code Style Guide

- [C# Coding Standards and Naming Conventions](https://github.com/ktaranov/naming-convention/blob/master/C%23%20Coding%20Standards%20and%20Naming%20Conventions.md)
  - 幾乎都是 PascalCase
  - 除了 localVar 或 _privateVar
- [Create a C# style guide: Write cleaner code that scales](https://unity.com/resources/create-code-c-sharp-style-guide-e-book?ungated=true)
- [Unity C# | 命名法則 & 低耦合、高內聚](https://vocus.cc/designer/61fe9831fd897800014eedda)
- [Unity-Code-Style-Guide](https://github.com/androchentw/Unity-Code-Style-Guide)
- [Formatting best practices for C# scripting in Unity](https://unity.com/how-to/formatting-best-practices-c-scripting-unity)
- [Unity Coding guidelines & Basic Best Practices](https://avangarde-software.com/unity-coding-guidelines-basic-best-practices/)

## Design Patterns

- [C# Design Patterns](https://www.dofactory.com/net/design-patterns)
- [Design Pattern in C# explained by ChatGPT | 2024-10-26](https://chatgpt.com/share/671c90d8-7664-800f-b67e-8bec77698012)
- [game-programming-patterns-demo](https://github.com/androchentw/game-programming-patterns-demo)
- [Game Programming Patterns](https://gameprogrammingpatterns.com/contents.html)

## DI (Dependency Injection), IoC C# unity

- [Unity 維護靈藥：Dependency Injection](https://medium.com/akatsuki-taiwan-technology/unity%E7%B6%AD%E8%AD%B7%E9%9D%88%E8%97%A5-dependency-injection-6ba93fc6d629)
- [Dependency Injection in Unity C#](https://medium.com/@ssmore101/dependency-injection-in-unity-c-f32568a2109a)
- [Dependency Injection in Unity - Inversion of Control Container](https://discussions.unity.com/t/dependency-injection-in-unity-inversion-of-control-container/914827/2)
- [Zenject](https://github.com/modesttree/Zenject): [Extenject Dependency Injection IOC](https://assetstore.unity.com/packages/tools/utilities/extenject-dependency-injection-ioc-157735)

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
- [淺談多執行緒程式設計與Unity的C# Job System](https://medium.com/akatsuki-taiwan-technology/淺談多執行緒程式設計與unity的c-job-system-19e4d5ca59dd)
- [Unity 利用C# Job System與Burst Compiler來解放CPU的效能](https://medium.com/akatsuki-taiwan-technology/unity-利用c-job-system與burst-compiler來解放cpu的效能-c9447357a076)
- [開始使用Unity的C# Job System(一)](https://medium.com/@eric.hu/開始使用unity的c-job-system-一-78b72b1e96bd)

## Mobile Game Design

- [Mobile game design with Unity](https://unity.com/topics/mobile-game-design)
- [Optimize your game performance for mobile, XR, and the web in Unity](https://unity.com/resources/mobile-xr-web-game-performance-optimization-unity-6)
  - [GenAI NoteBook LLM Summary](https://notebooklm.google.com/notebook/10e53e23-00fa-49ee-bff4-b27ee0ccf4e7)
- [Introduction to game level design](https://unity.com/resources/introduction-to-level-design-in-game-development-and-in-unity)
- [The Unity Game Designer Playbook](https://unity.com/resources/game-designer-playbook)
- [Unity best practices](https://unity.com/how-to)
- [2D game art, animation, and lighting for artists](https://unity.com/resources/2d-game-art-animation-lighting-for-artists-ebook?isGated=false)
- [Best practices for managing elements](https://docs.unity3d.com/Manual/UIE-best-practices-for-managing-elements.html)

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
