# DDD - Domain-Driven Design

<!-- TOC -->
* [DDD - Domain-Driven Design](#ddd---domain-driven-design)
  * [Layered Architecture](#layered-architecture)
  * [Model](#model)
  * [Life Cycle Management](#life-cycle-management)
  * [Supple Design Principle 柔性設計原則](#supple-design-principle-柔性設計原則)
  * [應用模式分析](#應用模式分析)
  * [保持模型完整性](#保持模型完整性)
  * [Design Pattern](#design-pattern)
  * [Distillation 精煉](#distillation-精煉)
    * [Example](#example)
  * [Large-scale Structures 大型結構](#large-scale-structures-大型結構)
    * [Example](#example-1)
  * [Ref: Principles](#ref-principles)
  * [Tutorials](#tutorials)
  * [Unity Development 想法](#unity-development-想法)
<!-- TOC -->

## Layered Architecture

- UI/Presentation: Event Controller => MVVM, UI Toolkit
- Application: Service Handler => MVP, Services
- Domain => Core
  - Model/Account.cs
- Infrastructure => Systems
  - Repository/PostgresAccountRepository.cs
  - MessagingService
- Framework, External => Plugins

## Model

- Entity: Who. Is Unique identifier
- Value object: What. Often immutable, static/singleton
- Service: How. Is Action, operation. Is Stateless.
- Module / Package
- 心得: 先區分領域, 再判斷model

## Life Cycle Management

- Aggregate: 界定內外邊界
- Factory: 生產物件
- Repository: 管理存取
- 心得:從核心與必要 model 關聯, 一步一步重構改進

## Supple Design Principle 柔性設計原則

- Intention-revealing interface
- Side-effect-free function
- Assertion
- Standalone class 獨立類別
- Closure of operation 閉合操作. 任意兩元素組合時, 結果仍在此集合中. e.g. 1+1=2 ; Decorator/Composite?
- Conceptual Contour 概念輪廓
- Declarative design 宣告式設計

## 應用模式分析

## 保持模型完整性

- Bounded Context
- Context Map: 評估關係
  - Booking Context — Routing Service == Booking-Transport Network Translator == Network Traversal Service — Transport Network Context
- High Control
  - Continuous Integration: 保持模型統一
  - Shared Kernel: 類似重疊
  - Customer/Supplier Development Team: 類似關聯
  - Open host service: 支持多客戶. Open protocol (API)
    - Published language: 形式化
- Low Control
  - Anti-corruption Layer: 單向轉換並隔離. Adapter, Translator
  - Conformist: 單向重疊(跟隨者)
  - Separate way: 團隊自由工作

## Design Pattern

- Strategy(Policy): 策略. e.g. 航運路線策略(便宜/迅速)
- Composite. 組合. e.g. 航運路線種類組合
- Facade: Encapsulates internal logic and only expose essential input/output
- Observer (PubSub, EventBus),
- Flyweight (static, Singleton)
  - https://unity.com/blog/game-programming-patterns-update-ebook

## Distillation 精煉

- Core domain
  - Domain vision statement: 指明方向
  - Highlighted core: 指明內容
- Generic Subdomains: 通用. 分隔
- Cohesive mechanism: 內聚機制. 分隔
  - Intention-revealing interfaces: 精煉
- Segregated core: 支援性. 重新封裝
  - Abstract core: 精煉

### Example

- Core: Delivery
- Generic: Money
- Segregated: Customer, Logistics

## Large-scale Structures 大型結構

Model-driven design

- Evolving order: 發現/精煉結構
- System metaphor: 思考
- Responsibility layers: 分層 (重要)
- Knowledge level: 分離易變行為
- Pluggable component framework: 解耦

### Example

*Core

- Decision layer
  - *Routing: router, loader
- Policy layer
  - *Commitment: customer agreement, pricing
  - *Routing policy: cheapest routing, favored carrier
  - Billing policy: invoicing rule, delinquency rule
- Operational layer
  - *Shipment: cargo, delivery specification, delivery history, route
  - *Banking: bill of ladling
  - Money: money, currency
- Potential layer
  - Transport: transport leg, carrier movement, transport schedule
  - Equipment: Inventory, container, trailer
  - Customer: customer
  - Geography: port, location

## Ref: Principles

- DRY, KISS, SOLID
- 低耦合高內聚
  - 內聚: 放在一起才能成立
- 內層不依賴高層 (using, import)
- Clean Architecture

## Tutorials

- [DDD 架構： 整合 Clean Architecture](https://ithelp.ithome.com.tw/articles/10222311)
- [領域驅動設計(Domain-Driven Design DDD)學習](https://hackmd.io/@ohQEG7SsQoeXVwVP2-v06A/rJjR_PyBi)
- [为什么从 MVC 到 DDD，架构的本质是什么？](https://www.cnblogs.com/xiaofuge/p/17524726.html)
- [从MVC到DDD，该如何下手重构？](https://www.cnblogs.com/xiaofuge/p/17729277.html)
- [MVC和DDD的对比 (一)](https://blog.csdn.net/qq_43141726/article/details/124973784)
- [从MVC 到DDD 架构](https://blog.csdn.net/aasd23/article/details/137084215)
- [DDD 落地的思考 --MVC-DDD 理論與實踐](https://www.readfog.com/a/1672443702438629376)
- [DDD 架構： 分層式架構與依賴反向原則](https://ithelp.ithome.com.tw/articles/10222162)

## Unity Development 想法

Goal: 達到 Clean Architecture & SOLID, 清楚知道如何持續擴充與測試遊戲功能

- MVVM, Data-oriented : 用 UI Toolkit 處理大部分UI & Data Binding 等介面互動操作
- MVP, Object-oriented : 複雜操作如功能切換, 透過 MVP 與指令模式, 進行系統上下前後串接
- DDD, Model-oriented : 整體資料與架構維護採用 DDD 設計, 進行核心業務邏輯建模
- Framework: Plugins
