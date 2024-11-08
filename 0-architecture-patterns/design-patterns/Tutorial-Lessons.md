# RMC Tutorial - Lesson

<!-- TOC -->
* [RMC Tutorial - Lesson](#rmc-tutorial---lesson)
  * [1 Beginner Lesson_01_MyMathSystem](#1-beginner-lesson_01_mymathsystem)
  * [1 Beginner Lesson_02_Observable](#1-beginner-lesson_02_observable)
  * [1 Beginner Lesson_03_DependencyInjection](#1-beginner-lesson_03_dependencyinjection)
  * [2 Advanced Scalability_01_Simple](#2-advanced-scalability_01_simple)
  * [🥇 2 Advanced Scalability_02_Standard](#-2-advanced-scalability_02_standard)
  * [🥇 2 Advanced Scalability_03_StandardWithFeature](#-2-advanced-scalability_03_standardwithfeature)
<!-- TOC -->

[Path](https://github.com/androchentw/rmc-mini-mvcs/tree/andro)

- `RMC Mini MVCS/Samples~/RMC Mini MVCS - 1. Beginner Examples/Lessons`
  - Lesson_01_MyMathSystem
  - Lesson_02_Observable
  - Lesson_03_DependencyInjection
- `RMC Mini MVCS/Samples~/RMC Mini MVCS - 2. Advanced Examples/Lessons/Lesson_01_Scalability`
  - Scalability_01_Simple
    - Basic setup. single-Scene usage
  - Scalability_02_Standard
    - Uses "Singleton". multi-Scene usage
  - Scalability_03_StandardWithFeature
    - Uses "Singleton" and "Feature". multi-Scene usage
    - The "Feature" Helps you turn on/off subsystems of your game easily
  - `<see cref="abc"/>`

## 1 Beginner Lesson_01_MyMathSystem

- MyMathSystem: add, subtract
- MyMathSystemExample: MonoBehaviour
  - MyMathSystem myMathSystem = new MyMathSystem();
  - int result = myMathSystem.Add(a, b);
  - `Debug.Log($"Result = {result}");`
- Editor: MyMathSystemTest. `Add_ResultIs15_When5And10`
  - Arrange > Act > Assert
  - `Assert.That(myMathSystem.Add(5, 10), Is.EqualTo(15));`
- Runtime: MyMathSystemPlayModeTest
  - Arrange > Act > Await > Assert
  - `yield return new WaitForSeconds(1);`
  - Assert.That(sum, Is.EqualTo(15));

## 1 Beginner Lesson_02_Observable

- `(Observable<string>) Status.OnValueChanged.AddListener(Status_OnValueChanged);`

## 1 Beginner Lesson_03_DependencyInjection

- `[Inject]` C# Attribute
  - [Dependency Injection概念介紹](https://ithelp.ithome.com.tw/articles/10204404)
  - [C# ASP.NET Core [Inject] Attribute Usage for Dependency Injection](https://stackoverflow.com/questions/65629065/c-sharp-asp-net-core-inject-attribute-usage-for-dependency-injection)
  - [ASP.NET Core Blazor 相依性插入](https://learn.microsoft.com/zh-tw/aspnet/core/blazor/fundamentals/dependency-injection?view=aspnetcore-8.0#request-a-service-in-a-component)
- `DependencyInjectorSystem.Instance.Bind<SampleService1>(new SampleService1());`
- `DependencyInjectorSystem.Instance.InjectAll();`
- `Debug.Log("_sampleService1 exists as : " + _sampleService1);`

## 2 Advanced Scalability_01_Simple

- Scalability_01_Simple : MonoBehaviour
  - `_mini = new SimpleInventorySimpleMini(_inventoryView);`
  - `_mini.Initialize();`
- InventoryService: BaseService
  - Handles external data: `Load() { (InventoryServiceUnityEvent) OnLoadCompleted.Invoke(inventoryCount); }`
- InventoryModel: BaseModel
  - Observable pattern: `public Observable<int> InventoryCount { get { return _inventoryCount;} }`
- InventoryController: BaseController
  - Bind View with Model: `_view.OnAction.AddListener(View_OnAction);`
    => `_model.InventoryCount.Value++`
  - Load data using Service: `_service.OnLoadCompleted.AddListener(Service_OnLoadCompleted);`
    => `_model.InventoryCount.Value = inventoryCount;`
  - `_service.Load();`
- InventoryView: MonoBehaviour, IView
  - Handles user interface and user input
  - `InventoryModel inventoryModel = Context.ModelLocator.GetItem<InventoryModel>();`
  - `inventoryModel.InventoryCount.OnValueChanged.AddListener(InventoryCount_OnValueChanged);`
  - `RefreshUI()`
  - Implement Unity methods: `Update() { if (Input.GetMouseButtonDown(0)) { OnAction.Invoke(); } }`
- Service Locator of `MiniMvcs`
  - 集中管理依賴，避免多處實例化 (同時亦運用 Singleton 以保證單一實例)。
    - init 時向 ServiceLocator register Service. 後續 GetService 取得 instance
  - [C#/Unity - 這不叫 Singleton，叫 Service Locator - Practice of Service Locator](https://douduck08.wordpress.com/2017/11/05/practice-of-service-locator/)
  - [Simple service locator for your Unity project](https://medium.com/medialesson/simple-service-locator-for-your-unity-project-40e317aad307)
  - [Design Patterns for Unity Developers: Service Locator](https://medium.com/@taha.m.gokdemir/design-patterns-for-unity-developers-service-locator-124cd4628c43)
  - [Unity Service Locator](https://github.com/adammyhre/Unity-Service-Locator)

## 🥇 2 Advanced Scalability_02_Standard

- Scalability_02_Standard : MonoBehaviour
  - Unity `start()`: Add to _mini then init. available for multiple MVCS in multi-Scene
    - InventoryMini _mini = InventoryMiniSingleton.Instance.InventoryMini;
    - [SerializeField] InventoryView
    - InventoryController(model, _inventoryView, service)
  - InventoryMini: MiniMvcs
    - context, model, service; feature
    - InventoryMiniSingleton: SingletonMonobehaviour<InventoryMiniSingleton>
    - FeatureBuilder FeatureBuilder
  - Rest of the MVCS designs are the same as `Scalability_01_Simple`

## 🥇 2 Advanced Scalability_03_StandardWithFeature

- Scalability_03_StandardWithFeature : MonoBehaviour
  - Extract the `start()` part of `Scalability_02_Standard` into `InventoryFeature` and init by `AddFeature`
  - start() { AddFeature(); }
    - _mini.AddFeature<InventoryFeature>(inventoryFeature);
  - OnDestroy() { RemoveFeature(); }
- InventoryFeature: BaseFeature
  - Build()
  - Dispose()
