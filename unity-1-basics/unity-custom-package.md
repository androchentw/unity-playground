# Unity Custom Package

- [Unity项目中Assets目录下常见的文件类型](https://blog.csdn.net/c373756607/article/details/86601926)
- [浅谈Assets——Unity资源映射](https://blog.csdn.net/UWA4D/article/details/104060885)
- [打包屬於自己的 Unity Package](https://vocus.cc/article/64f73591fd8978000165ecef)
- [Unity 自建 package 包流程](https://blog.csdn.net/SmillCool/article/details/130604245)
- [Creating custom packages](https://docs.unity3d.com/6000.0/Documentation/Manual/CustomPackages.html)
- [Unity 自製 Package](https://veryenjoy.tw/enjoy/article/235)
- [Creating custom packages for use in Unity](https://blog.devgenius.io/creating-custom-packages-for-use-in-unity-7dfbaa49e4b4)
- [Tutorial: Working with Custom Packages in Unity](https://nagachiang.github.io/tutorial-working-with-custom-package-in-unity-2019-2/#)
- [How To Create Custom Unity Packages In Unity 2024](https://www.youtube.com/watch?v=sTu9HxTgypk)
- [Get Started with Custom Unity Packages (Step by Step)](https://www.youtube.com/watch?v=f2xW24xyDEg)
- [Unity 自製Package](https://veryenjoy.tw/enjoy/article/235)
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
