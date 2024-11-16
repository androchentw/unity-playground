# Design Patterns

<!-- TOC -->
* [Design Patterns](#design-patterns)
  * [Tutorials](#tutorials)
  * [Creational: Creation](#creational-creation)
  * [Structural: Relationships](#structural-relationships)
  * [Behavioral: Communication](#behavioral-communication)
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
│   ├── unity-design-patterns-solid.md
```

## Tutorials

- [unity-design-patterns-solid.md](unity-design-patterns-solid.md)
- [design-patterns](design-patterns-cs/README.md)
- [game-programming-patterns-demo](https://github.com/androchentw/game-programming-patterns-demo)
- [C# Design Patterns](https://www.dofactory.com/net/design-patterns)
- [Game Programming Patterns](https://gameprogrammingpatterns.com/contents.html)

## Creational: Creation

| **分類**       | **設計模式**                           | **目的/結果對比**                                                                                                                   |
|--------------|------------------------------------|-------------------------------------------------------------------------------------------------------------------------------|
| **對象創建與組合**  | Abstract Factory, Factory, Builder | - **Abstract Factory**：提供一組相關對象的創建接口，無需指定具體類別 <br> - **Factory**：用於創建對象的工廠方法，根據需求返回不同子類對象 <br> - **Builder**：按步驟創建複雜對象，允許靈活組合 |
| **對象複製**     | Prototype                          | - **Prototype**：通過複製現有實例來創建新對象，避免直接初始化                                                                                        |
| **唯一性與全局訪問** | Singleton                          | - **Singleton**：確保一個類別只有一個實例，並提供全局訪問點                                                                                         |
| **對象查找與管理**  | Service Locator                    | - **Service Locator**：提供全局的對象訪問和管理機制，用於動態查找和注入                                                                                |

## Structural: Relationships

| **分類**      | **設計模式**        | **目的/結果對比**                                                       |
|-------------|-----------------|-------------------------------------------------------------------|
| **接口適配與兼容** | Adapter, Bridge | - **Adapter**：將現有接口轉換為另一接口以適應需求 <br>  - **Bridge**：將抽象與實現分離以便獨立變化 |
| **結構與組合**   | Composite       | - **Composite**：建立樹狀結構以表示部分-整體的層次結構                               |
| **行為擴展與裝飾** | Decorator       | - **Decorator**：動態地為對象添加職責或行為，不改變其結構                              |
| **簡化與封裝**   | Facade          | - **Facade**：為複雜系統提供簡化的接口，隱藏內部實現細節                                |
| **資源共享與優化** | Flyweight       | - **Flyweight**：共享內部狀態以減少相似對象的內存消耗                                |
| **訪問控制與代理** | Proxy           | - **Proxy**：為另一對象提供控制訪問的替身，並可延遲加載或權限控制                            |

## Behavioral: Communication

| **分類**       | **設計模式**                         | **目的/結果對比**                                                                         |
|--------------|----------------------------------|-------------------------------------------------------------------------------------|
| **流程控制與決策**  | Chain of Responsibility, Command | - **Chain of Responsibility**：傳遞請求至責任鏈中的合適處理者 <br> - **Command**：封裝請求作為對象以支持撤銷和操作隊列 |
| **行為交換與管理**  | State, Strategy                  | - **State**：根據狀態轉換來改變行為 <br> - **Strategy**：根據不同策略執行不同行為                            |
| **對象訪問與操作**  | Iterator, Visitor                | - **Iterator**：順序訪問集合中的元素 <br> - **Visitor**：為對象結構添加新操作，不改變結構                       |
| **協調與通知**    | Mediator, Observer               | - **Mediator**：集中管理對象間的通信 <br> - **Observer**：當狀態改變時通知依賴對象                          |
| **模板與規範化操作** | Template Method                  | - **Template Method**：定義算法骨架，讓子類覆蓋特定步驟                                              |
| **保存與回溯**    | Memento                          | - **Memento**：保存對象狀態，以便在需要時回溯                                                       |

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