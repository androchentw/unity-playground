# Dragon Crashers

- [Codebase](https://github.com/androchentw/unity-tutorial-projects/tree/main/dragon-crashers/Assets)
- [Asset Store:](https://assetstore.unity.com/packages/essentials/tutorial-projects/dragon-crashers-ui-toolkit-sample-project-231178)

<!-- TOC -->
* [Dragon Crashers](#dragon-crashers)
  * [Unity Ebook - User interface design and implementation in Unity](#unity-ebook---user-interface-design-and-implementation-in-unity)
    * [Screenshots](#screenshots)
    * [Mini Manual](#mini-manual)
<!-- TOC -->

## Unity Ebook - User interface design and implementation in Unity

- [User interface design and implementation in Unity](https://unity.com/resources/user-interface-design-and-implementation-in-unity)
  - Sprite, Tilemap
  - UI Toolkit
  - Dragon Crasher
    - Home, character, resources, shop, mail, settings, menu bar, inventory

### Screenshots

- [UI Reference](https://github.com/androchentw/unity-tutorial-projects/blob/main/dragon-crashers/Assets/UI/Reference/0%20home-screen.jpg)

### Mini Manual

- [Mini Manual pdf](https://github.com/androchentw/unity-tutorial-projects/blob/main/dragon-crashers/Assets/Documentation/Mini%20manual%20for%20UI%20TK-DG_%20pdf.pdf)
- [Device Simulator](https://docs.unity3d.com/Packages/com.unity.device-simulator@3.0/manual/index.html)
- Block Element Modifier (BEM)
  - https://getbem.com/
  - https://w3c.hexschool.com/blog/35afa83f
  - https://www.webdong.dev/zh-tw/post/write-cleaner-css-with-bem/
  - Utility-First CSS, tailwind. https://ithelp.ithome.com.tw/articles/10243926
- `ShopScreen.uxml`
  - **ShopItemSO**: This ScriptableObject holds the statistics for each item that appears in the shop.
  - **ShopItemComponent**: This translates game data from the ScriptableObject into UI text and graphics for a single item.
  - **ShopScreenController**: This handles the actual game logic to set up the shop. The controller reads the ScriptableObject assets from the Resources and stores them in categorized lists (List), one for each item type (coins, gems, potions).
  - **ShopView**: This UI class renders the UI, updating the display based on events from the controller.
