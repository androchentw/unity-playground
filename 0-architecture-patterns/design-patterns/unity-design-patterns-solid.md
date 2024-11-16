# Unity - Level up your code with design patterns and SOLID

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
