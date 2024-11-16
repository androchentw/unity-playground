# Unity Folder Structure

<!-- TOC -->
* [Unity Folder Structure](#unity-folder-structure)
  * [Sample Project Structure Template](#sample-project-structure-template)
    * [Others](#others)
    * [Ref - unity-project-template](#ref---unity-project-template)
  * [Asset Type](#asset-type)
<!-- TOC -->

## Sample Project Structure Template

- [UnityBaseTemplate2DURP](https://github.com/androchentw/UnityBaseTemplate2DURP)
- [Sample Game Projects on Unity Asset Store](/2-unity-assets-collection/2-unity-assets-templates.md)
- Ref
  - [4-unity-best-practices.md](4-unity-best-practices.md)
  - [5-unity-ui-toolkits.md](5-unity-ui-toolkits.md)
  - [5-unity-ui-toolkits-QuizU.md](5-unity-ui-toolkits-QuizU.md)
  - [7-unity-custom-package.md](7-unity-custom-package.md)
  - [MVC-MVP-MVVM.md](/0-architecture-patterns/MVC-MVP-MVVM.md)
  - [DDD-Domain-Driven-Design.md](/0-architecture-patterns/DDD-Domain-Driven-Design.md)

<img width="500px" src="https://github.com/androchentw/UnityBaseTemplate2DURP/blob/main/Assets/Docs/res/unity-sample-project-structure-markmap.png?raw=true" alt="UnityBaseTemplate2DURP-project-structure-markmap">

### Others

- Unity
  - [Package layout](https://docs.unity3d.com/Manual/cus-layout.html)
  - [Adding tests to a package](https://docs.unity3d.com/Manual/cus-tests.html)
  - [How to run automated tests for your games with the Unity Test Framework](https://unity.com/how-to/automated-tests-unity-test-framework)
- Others
  - [unity-project-template](https://github.com/androchentw/unity-project-template/tree/andro): clean project structure and C# coding standards template
  - [rmc-mini-mvcs](https://github.com/androchentw/rmc-mini-mvcs/tree/andro/docs): MVCS architecture example and design patterns explained
  - [unity-project-style-guide](https://github.com/timdhoffmann/unity-project-style-guide)
  - [gameplay-framework-unity](https://github.com/GiovanniZambiasi/gameplay-framework-unity)

### Ref - unity-project-template

Note: ignored `*.meta`, `*.asset`

```text
UnityProject/
├── Assets/
    ├── 3rdParty/
        ├── [CompanyName]/
            ├── [PackageName]/
                ├── Version.txt
    ├── Art/
        ├── Animation/
            ├── AnimationClips/
            ├── Animators/
        ├── Audio/
            ├── AudioClips/
            ├── AudioMixers/
        ├── Fonts/
            ├── Arial.ttf
        ├── Materials/
            ├── FloorMaterial.mat
            ├── PlayerMaterial.mat
        ├── Models/
        ├── Shaders/
        ├── Sprites/
        ├── Textures/
            ├── FloorTexture.png
    ├── Documentation/
        ├── Images/
            ├── BestPractices.png
        ├── ReadMe/
            ├── Art/
                ├── Sprites/
                    ├── ProjectIcon.png
            ├── Scripts/
                ├── Editor/
                    ├── ReadMeMenuItems.cs
    ├── Prefabs/
        ├── [MyCompany]/
            ├── [MyProject]/
                ├── AudioManager.prefab
    ├── Resources/
        ├── [MyCompany]/
            ├── [MyProject]/
    ├── Scenes/
        ├── Scene01_Intro.unity
    ├── Scripts/
        ├── Editor/
            ├── [MyCompany]/
                ├── Templates/
                    ├── TemplateEditorMenuItems.cs
                ├── [MyProject]/
        ├── Runtime/
            ├── [MyCompany]/
                ├── Templates/
                    ├── ITemplateInterface.cs
                    ├── TemplateClass.cs
                    ├── TemplateComponent.cs
                    ├── TemplateScriptableObject.cs
                ├── [MyProject]/
                    ├── Scenes/
                        ├── Scene01_Intro.cs
                    ├── UI/
                        ├── HudUI.cs
        ├── Tests/
            ├── Editor/
                ├── [MyCompany]/
                    ├── Templates/
                        ├── TemplateClassEditModeTest.cs
                    ├── [MyProject]/
            ├── Runtime/
                ├── [MyCompany]/
                    ├── Templates/
                        ├── TemplateComponentPlayModeTest.cs
                    ├── [MyProject]/
    ├── Settings/
        ├── Audio/
        ├── InputSystem/
        ├── PhysicMaterials/
        ├── Presets/
        ├── ProBuilder/
        ├── Rendering/
        ├── UIToolkit/
            ├── Layouts/
                ├── TemplateLayout.uxml
            ├── Resources/
            ├── Settings/
            ├── Styles/
                ├── TemplateStyles.uss
            ├── Themes/
                ├── TemplateThemeStyleSheet.tss
├── Packages/
    ├── manifest.json
    └── packages-lock.json
├── ProjectSettings/
```

## Asset Type

- [Unity项目中Assets目录下常见的文件类型](https://blog.csdn.net/c373756607/article/details/86601926)
- [浅谈Assets——Unity资源映射](https://blog.csdn.net/UWA4D/article/details/104060885)
- [Version control and project organization best practices for game developers](https://unity.com/resources/version-control-project-organization-best-practices-ebook)

| Asset Type | Explanation                                                                                                                                                                                                                                                  |
|------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Animations | Animations contain animated motion clips and their controller files. These can also contain Timeline assets for in-game cinematics or rigging information for procedural animation.                                                                          |
| Audio      | Sound assets include audio clips as well as the mixers used for blending the effects and music.                                                                                                                                                              |
| Editor     | This contains scripted tools made for use with the Unity Editor but not appearing in a target build.                                                                                                                                                         |
| Fonts      | This folder contains the fonts used in the game.                                                                                                                                                                                                             |
| Materials  | These assets describe surface shading properties.                                                                                                                                                                                                            |
| Meshes     | Store models created in an external digital content creation (DCC) application here.                                                                                                                                                                         |
| Particles  | The particle simulations in Unity, created either with the Particle System or Visual Effect Graph.                                                                                                                                                           |
| Prefabs    | These are reusable GameObjects with prebuilt Components. Add them to a scene to build.                                                                                                                                                                       |
| Scripts    | All user-developed code for gameplay appears here.                                                                                                                                                                                                           |
| Settings   | These assets store render pipeline settings, such as for the High Definition Render Pipeline (HDRP) and Universal Render Pipeline (URP).                                                                                                                     |
| Shaders    | These programs run on the GPU as part of the graphics pipeline.                                                                                                                                                                                              |
| Scenes     | Unity stores small, functional portions of your project into Scene assets. They often correspond to game levels or part of a level.                                                                                                                          |
| Textures   | Image files can consist of texture files for materials and surfacing, UI overlay elements for user interface, and lightmaps to store lighting information.                                                                                                   |
| ThirdParty | If you have assets from an external source like the Asset Store, keep them separated from the rest of your project here. This makes updating your third-party assets and scripts easier. Third-party assets may have a set structure that cannot be altered. |
