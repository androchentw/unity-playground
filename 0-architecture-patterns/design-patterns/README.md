# Design Patterns

<!-- TOC -->
* [Design Patterns](#design-patterns)
  * [C# Code Examples](#c-code-examples)
  * [Tutorials](#tutorials)
    * [Creational: Creation](#creational-creation)
    * [Structural: Relationships](#structural-relationships)
    * [Behavioral: Communication](#behavioral-communication)
  * [🥇 Unity - Level up your code with design patterns and SOLID](#-unity---level-up-your-code-with-design-patterns-and-solid)
  * [SOLID](#solid)
  * [Observer pattern](#observer-pattern)
    * [事件（Events）和委派（Delegates）的差異](#事件events和委派delegates的差異)
  * [Command Pattern](#command-pattern)
    * [The command object and command invoker](#the-command-object-and-command-invoker)
    * [Example: Undoable movement](#example-undoable-movement)
  * [Factory Pattern](#factory-pattern)
    * [Creating a simple factory](#creating-a-simple-factory)
    * [Adapting the factory pattern](#adapting-the-factory-pattern)
  * [Object Pooling](#object-pooling)
  * [State Pattern](#state-pattern)
  * [Performance Benchmarking](#performance-benchmarking)
    * [Comparison](#comparison)
<!-- TOC -->

<img src="/0-architecture-patterns/res/design-patterns.gif" width="600" alt="design-patterns">

```text
│   ├── design-patterns-cs/
│   │   ├── behavioral-chain-of-responsibility.cs
│   │   ├── behavioral-command.cs
│   │   ├── behavioral-iterator.cs
│   │   ├── behavioral-mediator.cs
│   │   ├── behavioral-memento.cs
│   │   ├── behavioral-observer.cs
│   │   ├── behavioral-state.cs
│   │   ├── behavioral-strategy.cs
│   │   ├── behavioral-template-method.cs
│   │   ├── behavioral-visitor.cs
│   │   ├── creational-abstract-factory.cs
│   │   ├── creational-builder.cs
│   │   ├── creational-factory.cs
│   │   ├── creational-prototype.cs
│   │   ├── creational-service-locator.cs
│   │   ├── creational-singleton.cs
│   │   ├── structural-adapter.cs
│   │   ├── structural-bridge.cs
│   │   ├── structural-composite.cs
│   │   ├── structural-decorator.cs
│   │   ├── structural-facade.cs
│   │   ├── structural-flyweight.cs
│   │   └── structural-proxy.cs
│   ├── README-unity-6-practices.md
│   ├── Tutorial-Lessons.md
│   ├── Tutorial-Samples-Basic.md
│   ├── Tutorial-Samples-More.md
```

## C# Code Examples

- [design-patterns](design-patterns-cs/README.md)

## Tutorials

- [C# Design Patterns](https://www.dofactory.com/net/design-patterns)
- [Design Pattern in C# explained by ChatGPT | 2024-10-26](https://chatgpt.com/share/671c90d8-7664-800f-b67e-8bec77698012)
- [game-programming-patterns-demo](https://github.com/androchentw/game-programming-patterns-demo)
- [Game Programming Patterns](https://gameprogrammingpatterns.com/contents.html)

### Creational: Creation

| **分類**       | **設計模式**                           | **目的/結果對比**                                                                                                                   |
|--------------|------------------------------------|-------------------------------------------------------------------------------------------------------------------------------|
| **對象創建與組合**  | Abstract Factory, Factory, Builder | - **Abstract Factory**：提供一組相關對象的創建接口，無需指定具體類別 <br> - **Factory**：用於創建對象的工廠方法，根據需求返回不同子類對象 <br> - **Builder**：按步驟創建複雜對象，允許靈活組合 |
| **對象複製**     | Prototype                          | - **Prototype**：通過複製現有實例來創建新對象，避免直接初始化                                                                                        |
| **唯一性與全局訪問** | Singleton                          | - **Singleton**：確保一個類別只有一個實例，並提供全局訪問點                                                                                         |
| **對象查找與管理**  | Service Locator                    | - **Service Locator**：提供全局的對象訪問和管理機制，用於動態查找和注入                                                                                |

### Structural: Relationships

| **分類**      | **設計模式**        | **目的/結果對比**                                                       |
|-------------|-----------------|-------------------------------------------------------------------|
| **接口適配與兼容** | Adapter, Bridge | - **Adapter**：將現有接口轉換為另一接口以適應需求 <br>  - **Bridge**：將抽象與實現分離以便獨立變化 |
| **結構與組合**   | Composite       | - **Composite**：建立樹狀結構以表示部分-整體的層次結構                               |
| **行為擴展與裝飾** | Decorator       | - **Decorator**：動態地為對象添加職責或行為，不改變其結構                              |
| **簡化與封裝**   | Facade          | - **Facade**：為複雜系統提供簡化的接口，隱藏內部實現細節                                |
| **資源共享與優化** | Flyweight       | - **Flyweight**：共享內部狀態以減少相似對象的內存消耗                                |
| **訪問控制與代理** | Proxy           | - **Proxy**：為另一對象提供控制訪問的替身，並可延遲加載或權限控制                            |

### Behavioral: Communication

| **分類**       | **設計模式**                         | **目的/結果對比**                                                                         |
|--------------|----------------------------------|-------------------------------------------------------------------------------------|
| **流程控制與決策**  | Chain of Responsibility, Command | - **Chain of Responsibility**：傳遞請求至責任鏈中的合適處理者 <br> - **Command**：封裝請求作為對象以支持撤銷和操作隊列 |
| **行為交換與管理**  | State, Strategy                  | - **State**：根據狀態轉換來改變行為 <br> - **Strategy**：根據不同策略執行不同行為                            |
| **對象訪問與操作**  | Iterator, Visitor                | - **Iterator**：順序訪問集合中的元素 <br> - **Visitor**：為對象結構添加新操作，不改變結構                       |
| **協調與通知**    | Mediator, Observer               | - **Mediator**：集中管理對象間的通信 <br> - **Observer**：當狀態改變時通知依賴對象                          |
| **模板與規範化操作** | Template Method                  | - **Template Method**：定義算法骨架，讓子類覆蓋特定步驟                                              |
| **保存與回溯**    | Memento                          | - **Memento**：保存對象狀態，以便在需要時回溯                                                       |

## 🥇 Unity - Level up your code with design patterns and SOLID

- [Asset Store: Level up your code with design patterns and SOLID](https://assetstore.unity.com/packages/essentials/tutorial-projects/level-up-your-code-with-design-patterns-and-solid-289616)
- [GitHub: game-programming-patterns-demo](https://github.com/androchentw/game-programming-patterns-demo)
- [Ebook- Level up your code with design patterns and SOLID](https://unity.com/resources/design-patterns-solid-ebook)
  - [YouTube: Level up your code with game programming patterns: Model-view-presenter | Tutorial](https://www.youtube.com/watch?v=agoe5BdLzdk&list=PLX2vGYjWbI0TmDVbWNA56NbKKUgyUAQ9i&index=4)
  - [Build a modular codebase with MVC and MVP programming patterns](https://unity.com/how-to/build-modular-codebase-mvc-and-mvp-programming-patterns)

## SOLID

## Observer pattern

- Subject / Publisher
  - `public event Action ThingHappened;`
  - `public void DoThing() { ThingHappened?.Invoke(); }`
- Observer
  - attach to GameObject as a component, reference the `subjectToObserver` in the Inspector to listen for the `ThingHappened` event.
  - `OnThingHappened`: `Awake or Start` subscribe to the event with the `+=` operator; `OnDestroy` unsubscribe with `-=`
- UnityEvents vs. UnityActions
  - slower than System.Action
  - Ref
    - [【Unity】Delegate, Event, UnityEvent, Action, UnityAction, Func 傻傻分不清](https://blog.csdn.net/weixin_45775438/article/details/128449023)
      - Event = 一種特殊的 delegate
      - 亦可用 anonymous delegate or lambda 實現- [Understanding Events and Delegates in C# Unity](https://medium.com/@sonusprocks/understanding-events-and-delegates-in-c-unity-ba4d3bbe9234)
    - [Events & Delegates in Unity](https://gamedevbeginner.com/events-and-delegates-in-unity/)
- Improvements to the pattern
  - C# `ObservableCollection`
  - pass the unique ID into the event (use type Action)
  - Create a static EventManager
    - [Game architecture with ScriptableObjects | Open Projects Devlog](https://www.youtube.com/watch?v=WLDgtRNK2VE)
  - Create an event queue: Combine with the command pattern and use a command buffer to play back the events one at a time or selectively ignore them as necessary

### 事件（Events）和委派（Delegates）的差異

| 特性   | 事件（Events）                    | 委派（Delegates）                        |
|------|-------------------------------|--------------------------------------|
| 定義   | 事件是委派的封裝，提供更高層次的抽象。           | 委派是一種類型，類似於函數指標。                     |
| 訪問控制 | 只能在聲明它們的類中觸發。                 | 可以在任何地方調用。                           |
| 安全性  | 提供更高的安全性，防止外部對事件的直接操作。        | 直接操作，沒有額外的安全層。                       |
| 使用場景 | 適合用於需要通知多個訂閱者的情況。             | 適合用於需要靈活調用方法的情況。                     |
| 語法   | `event EventHandler MyEvent;` | `public delegate void MyDelegate();` |

## Command Pattern

- [Use the command pattern for flexible and extensible game systems](https://unity.com/how-to/use-command-pattern-flexible-and-extensible-game-systems)

- track a specific series of actions: move, undo, redo, ...
  - Imagine a strategy game where the user can plan several turns before actually executing them. That’s the command pattern.
  - Encapsulating actions as objects enables you to create a flexible and extensible system for controlling the behavior of GameObjects in response to user input.

### The command object and command invoker

- `public interface ICommand { void Execute(); void Undo(); }`

### Example: Undoable movement

- `CommandInvoker` + `ExecuteCommand`, `UndoCommand`

## Factory Pattern

- [How to use the factory pattern for object creation at runtime](https://unity.com/how-to/how-use-factory-pattern-object-creation-runtime)
- spawn different objects
- `Factory`: `+GetProduct(): IProduct`

### Creating a simple factory

- Adding redo functionality is a matter of adding another stack
- Limit the size of the stacks

### Adapting the factory pattern

- Use a dictionary to search for products: key-value pairs. unique ID
- Make the factory (or a factory manager) static
- Apply it to non-GameObjects and non-MonoBehaviours
- Combine with the object pool pattern

## Object Pooling

- [Use object pooling to boost the performance of C# scripts in Unity](https://unity.com/how-to/use-object-pooling-boost-performance-c-scripts-unity)

## State Pattern

- [Develop a modular, flexible codebase with the state programming pattern](https://unity.com/how-to/develop-modular-flexible-codebase-state-programming-pattern)

## Performance Benchmarking

by ChatGPT

- 簡單遊戲或無需頻繁建立/銷毀的物件
  - 優先使用 **private 成員** 或 **傳遞參數**，確保程式碼簡潔且易於測試。
  - 對於全域常數或工具方法，使用 **static 成員**。
- 大型專案或需要動態物件生成
  - 使用 **Singleton Pattern** 管理全域唯一物件，如遊戲設定或單一遊戲管理器。
  - 使用 **Factory Pattern** 封裝複雜的物件建立邏輯，尤其是在多種類型物件共存時。
- 高效能要求
  - 使用 **Object Pooling** 優化頻繁生成與銷毀的物件，減少 GC 負擔。
  - 針對大量相似物件，使用 **Flyweight Pattern** 減少記憶體佔用。

### Comparison

| **方法**                | **平均每幀耗時 (ms)** | **GC Allocations (KB)** | **適用場景**           | **優點**          | **缺點**             |
|-----------------------|-----------------|-------------------------|--------------------|-----------------|--------------------|
| Private 成員            | 0.12            | 0 KB                    | 簡單場景、無需重複建立物件      | 易於維護、直接存取       | 可能造成封裝不良           |
| 傳遞參數 (Local Variable) | 0.10            | 0 KB                    | 需避免副作用、確保函數純粹      | 沒有副作用、易於測試      | 增加參數傳遞成本           |
| Static 成員             | 0.08            | 0 KB                    | 全域性不變數，如設定值        | 快速存取、不佔用額外記憶體   | 會造成全域狀態污染，降低可測試性   |
| Singleton Pattern     | 0.11            | 0 KB                    | 全域性唯一物件，如遊戲管理器     | 控制物件唯一性、節省記憶體   | 易造成耦合度過高，難以進行單元測試  |
| Factory Pattern       | 0.18            | 8 KB                    | 複雜初始化邏輯、多類型物件建立    | 封裝物件建立邏輯、提高可維護性 | 額外的抽象層，效能略有損耗      |
| Flyweight Pattern     | 0.09            | 0 KB                    | 大量重複物件（如地圖瓦片）      | 減少記憶體使用、共用資料    | 較難管理物件狀態           |
| Object Pooling        | 0.06            | 0 KB                    | 頻繁生成與銷毀的物件（如子彈、敵人） | 極大提升效能、減少 GC 開銷 | 增加額外的管理邏輯、增加程式碼複雜度 |