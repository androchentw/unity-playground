# Unity UI Toolkits - QuizU

<!-- TOC -->
* [Unity UI Toolkits - QuizU](#unity-ui-toolkits---quizu)
  * [Catalog](#catalog)
  * [Demos](#demos)
<!-- TOC -->

- [Unity Asset Store: QuizU - A UI toolkit sample](https://assetstore.unity.com/packages/essentials/tutorial-projects/quizu-a-ui-toolkit-sample-268492#description)
  - Event dispatch and propagation
  - The state pattern for game flow
  - Managing menu screens in UI Toolkit
  - The model-view-presenter pattern in QuizU
  - Event handling in UI Toolkit 
- Tutorial: QuizU-documentation-Nov1-2023.pdf

## Catalog

<img src="res/unity-QuizU-ui-toolkit-sample-catalog.png" width="600px" alt="unity-QuizU-ui-toolkit-sample-catalog">

- Basics
  - QuizU: Exploring the demo scenes
  - GroupBox versus VisualElement
  - Flexbox rules and layout
  - USS Styles
  - UQuery
  - Manipulators
  - Others
    - C# Style Guide
    - Utilities
    - ScriptTemplates
    - ScriptableObjects
- QuizU: State pattern for game flow
  - IState, ILink
  - StateMachine, ConcreteStates
  - SequenceManager
- Managing menu screens in UI Toolkit
  - UIManager versus SequenceManager
- QuizU: Model View Presenter pattern
  - The Model: AudioSettings
  - The View: Settings Screen
  - The Presenter: SettingsPresenter
  - SettingsEvents
- QuizU: Event handling in UI Toolkit
  - Registering events
  - Event dispatch and propagation
  - The Event Registry pattern
- UI Toolkit performance tips
  - Hierarchy and elements
  - Asset loading
  - UQuery
  - Garbage collection
  - Rendering
  - Balancing Performance and Usability

## Demos

- [**UXML** and Visual Trees](https://docs.unity3d.com/Manual/UIE-VisualTree.html)
  - UXML files form a hierarchical structure of UI elements
  - These visual trees serve as a blueprint for your user interface
  - <img src="https://docs.unity3d.com/uploads/Main/VisualTreeExample.png" width="600px" alt="VisualTreeExample">
- [**Flexbox**](https://docs.unity3d.com/Manual/UIE-LayoutEngine.html)
  - The Flexible Box Layout Model (flexbox) provides an efficient layout model for arranging UI elements dynamically within a container.
  - <img src="https://docs.unity3d.com/uploads/Main/UIBuilder/AbsolutePositionOverlayWithPopup.png" width="600px" alt="Flexbox">
- [Unity Style Sheets (**USS**)](https://docs.unity3d.com/Manual/UIE-about-uss.html)
  - USS allows developers to customize UI elements with predefined styles. 
  - Re-skinning your UI is just a matter of swapping style sheets.
- [**UQuery**](https://docs.unity3d.com/Manual/UIE-UQuery.html)
  - UQuery simplifies the process of searching through a complex hierarchy of UI elements, enabling seamless navigation to specific UI components within the visual tree.
- [**Pseudo-classes**](https://docs.unity3d.com/Manual/UIE-USS-Selectors-Pseudo-Classes.html)
  - Pseudo-classes can be used to create interactive and animated UI elements with minimal extra code, adding extra 'juice' to your visual interface (e.g. enlarging a button when hovering over it or changing a text field color after selection).
  - <img src="https://docs.unity3d.com/uploads/Main/uss-selectors-pseudo-chained-match.png" width="300px" alt="uss-selectors-pseudo-chained-match">
- [UI Toolkit **Event System**](https://docs.unity3d.com/Manual/UIE-Events-Dispatching.html)
  - UI Toolkit has its own complementing event system, designed to handle your UI's clicks, changes, and pointer input, even across complex hierarchies.
  - <img src="https://docs.unity3d.com/uploads/Main/UIElementsEvents.png" width="400px" alt="UIElementsEvents - Propagation path">
- [**Manipulators**](https://docs.unity3d.com/Manual/UIE-Events-Handling.html#manipulator)
  - Encapsulating related event callbacks into a single class, a manipulator promotes reusability and makes it easier to define user interactions (e.g. a click-and-drag manipulator for an inventory system, a gesture manipulator for a pinch-to-zoom effect, etc.).
- [**Custom Controls**](https://docs.unity3d.com/Manual/UIB-structuring-ui-custom-elements.html)
  - The demo shows how to define and instantiate custom VisualElement through UxmlFactory and UxmlTraits classes. These custom controls can then be reused through scripts or the UI Builder.
  - <img src="https://docs.unity3d.com/uploads/Main/UIBuilder/CustomElementAttributes.png" width="300px" alt="CustomElementAttributes">
