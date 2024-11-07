# Unity Custom Package

<!-- TOC -->
* [Unity Custom Package](#unity-custom-package)
  * [Tutorials](#tutorials)
  * [Package layout](#package-layout)
<!-- TOC -->

## Tutorials

- [Unity 自製 Package](https://veryenjoy.tw/enjoy/article/235)
- [打包屬於自己的 Unity Package](https://vocus.cc/article/64f73591fd8978000165ecef)
- [Creating custom packages](https://docs.unity3d.com/6000.0/Documentation/Manual/CustomPackages.html)
- [Get Started with Custom Unity Packages (Step by Step)](https://www.youtube.com/watch?v=f2xW24xyDEg)

## Package layout

- [Package layout](https://docs.unity3d.com/Manual/cus-layout.html)

```txt
<package-root>
  ├── package.json
  ├── README.md
  ├── CHANGELOG.md
  ├── LICENSE.md
  ├── Third Party Notices.md
  ├── Editor
  │   ├── <company-name>.<package-name>.Editor.asmdef
  │   └── EditorExample.cs
  ├── Runtime
  │   ├── <company-name>.<package-name>.asmdef
  │   └── RuntimeExample.cs
  ├── Tests
  │   ├── Editor
  │   │   ├── <company-name>.<package-name>.Editor.Tests.asmdef
  │   │   └── EditorExampleTest.cs
  │   └── Runtime
  │        ├── <company-name>.<package-name>.Tests.asmdef
  │        └── RuntimeExampleTest.cs
  ├── Samples~
  │        ├── SampleFolder1
  │        ├── SampleFolder2
  │        └── ...
  └── Documentation~
       └── <package-name>.md
```
