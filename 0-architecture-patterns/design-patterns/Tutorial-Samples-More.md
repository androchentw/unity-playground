# RMC Tutorial - 4 More

<!-- TOC -->
* [RMC Tutorial - 4 More](#rmc-tutorial---4-more)
  * [4_Calculator](#4_calculator)
  * [5_CountUp](#5_countup)
  * [7_DataBinding](#7_databinding)
  * [8_MultipleMini](#8_multiplemini)
  * [10_UIToolkit](#10_uitoolkit)
  * [11_MultipleScene](#11_multiplescene)
  * [12_Spawner](#12_spawner)
  * [13_ScriptableObject](#13_scriptableobject)
  * [Advanced: 01_ConfiguratorMini](#advanced-01_configuratormini)
  * [Unity Game Service: 01_UnityGamingServices](#unity-game-service-01_unitygamingservices)
<!-- TOC -->

- [Path](https://github.com/androchentw/rmc-mini-mvcs/tree/andro)
  - `RMC Mini MVCS/Samples~/RMC Mini MVCS - 1. Beginner Examples/Examples`
  - `RMC Mini MVCS/Samples~/RMC Mini MVCS - 2. Advanced Examples/Example01_ConfiguratorMini`
  - `RMC Mini MVCS/Samples~/RMC Mini MVCS - 3. Unity Gaming Services Examples/Example01_UnityGamingServices`

## 4_Calculator

<img src="img/4_Calculator.jpg" width="600" alt="">

- `Start() { new CalculatorSimpleMini([SerializeField] _calculatorView).Initialize(); }`
- CalculatorSimpleMini: ISimpleMiniMvcs
  - init MVC with ModelLocator
- CalculatorModel : BaseModel
  - public Properties, private SerializeField
  - Observable
- CalculatorView : MonoBehaviour, IView
  - UnityEvent, public Properties, private SerializeField
  - field.(onValueChanged/onClick).AddListener(eventHandler) => Invoke
- CalculatorController : IController
  - Implement data binding of Model and View

## 5_CountUp

<img src="img/5_CountUp.jpg" width="600" alt="">

- CountUpService: BaseService
  - Load -> LoadAsync -> `(LoadedUnityEvent) OnLoaded.Invoke();`
  - TextAsset textAsset = Resources.Load<TextAsset>("Texts/CountUpWithMiniText"); //txt file. value: 22
- CountUpController: BaseController
  - _service.OnLoaded.AddListener(Service_OnLoaded);
    - View_OnScreenClicked
    - Model_OnCounterChanged
  - _service.Load()
- CounterChangedCommand: ValueChangedCommand<int>
  - CounterChangedCommand(int previousValue, int currentValue)
- CountUpView: MonoBehaviour, IView
  - Unity `Update() { (ScreenClickedUnityEvent) OnScreenClicked.Invoke(); }`
  - Context.CommandManager.AddCommandListener<CounterChangedCommand>(OnCounterValueChangedCommand);

## 7_DataBinding

<img src="img/7_DataBinding.jpg" width="600" alt="">

- LeftView/RightView: MonoBehaviour, IView
  - Setup
    - Context.ModelLocator.GetItem<DataBindingMiniModel>();
  - If Model Changes
    - dataBindingMiniModel.Message.OnValueChanged.AddListener(Message_OnValueChanged, true);
      - {_inputField.text = currentValue; }
  - If View Changes
    - _inputField.onValueChanged.AddListener(InputField_OnValueChanged);
      - Context.ModelLocator.GetItem<DataBindingMiniModel>();
      - dataBindingMiniModel.Message.Value = value;

## 8_MultipleMini

<img src="img/8_MultipleMini.jpg" width="600" alt="">

## 10_UIToolkit

## 11_MultipleScene

<img src="img/11_MultipleScene.jpg" width="600" alt="">

## 12_Spawner

<img src="img/12_Spawner.jpg" width="600" alt="">

## 13_ScriptableObject

<img src="img/13_ScriptableObject.jpg" width="600" alt="">

## Advanced: 01_ConfiguratorMini

## Unity Game Service: 01_UnityGamingServices
