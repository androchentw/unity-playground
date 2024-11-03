# Unity Best Practices

<!-- TOC -->
* [Unity Best Practices](#unity-best-practices)
  * [C# General](#c-general)
  * [Code Style Guide](#code-style-guide)
  * [Design Patterns](#design-patterns)
  * [DI (Dependency Injection), IoC C# unity](#di-dependency-injection-ioc-c-unity)
<!-- TOC -->

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

## DI (Dependency Injection), IoC C# unity

- [Unity 維護靈藥：Dependency Injection](https://medium.com/akatsuki-taiwan-technology/unity%E7%B6%AD%E8%AD%B7%E9%9D%88%E8%97%A5-dependency-injection-6ba93fc6d629)
- [Dependency Injection in Unity C#](https://medium.com/@ssmore101/dependency-injection-in-unity-c-f32568a2109a)
- [Dependency Injection in Unity - Inversion of Control Container](https://discussions.unity.com/t/dependency-injection-in-unity-inversion-of-control-container/914827/2)
- [Zenject](https://github.com/modesttree/Zenject): [Extenject Dependency Injection IOC](https://assetstore.unity.com/packages/tools/utilities/extenject-dependency-injection-ioc-157735)
