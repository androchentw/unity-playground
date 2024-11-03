# Unity JetBrains Rider

<!-- TOC -->
* [Unity JetBrains Rider](#unity-jetbrains-rider)
  * [Settings](#settings)
  * [Plugins](#plugins)
  * [Keymap](#keymap)
  * [Tutorial](#tutorial)
<!-- TOC -->

## Settings

- [.gitignore for JetBrains + Rider + Unity](https://www.toptal.com/developers/gitignore/api/jetbrains+all,rider,unity)
- [Jetbrains Rider Editor](https://docs.unity3d.com/Packages/com.unity.ide.rider@3.0/manual/using-the-jetbrains-rider-editor-package.html)
  - Edit > Preferences > External Tools > External Script Editor > Rider
  - For Trace code: Unity > Regenerate project File > *.csproj
- Settings | Editor | Editor tabs --> Mark modified tabs with asterisk
- 字體: Editor > Color Scheme > Color Scheme Font
  - Font: Hack Nerd Font
  - Fallback font: Microsoft JhengHei UI
  - 不要勾選 "show only monospaced fonts", 不然會選不到字體
  - 注意: 跟 Editor > Font > Font 設定不同
  - [Ref: IDE font is not consistent with custom font settings under Chinese](https://youtrack.jetbrains.com/issue/RIDER-89585/IDE-font-is-not-consistent-with-custom-font-settings-under-Chinese):
- [Shortcut for changing tabs->spaces->tabs in IntelliJ IDEA](https://stackoverflow.com/questions/41532061/shortcut-for-changing-tabs-spaces-tabs-in-intellij-idea)

## Plugins

- Install plugins: ctrl+alt+s > plugin
- Editor
  - Atom Material Icons, Material Theme UI / One Dark Theme
  - .ignore, Markdown, .env files support, CSV Editor, Toml, Json Parser
    - ToC 自動生成會跟自動 reformat 規則衝突. 要改 Editor > Code Style > Markdown > Minimum blank lines > Around block elements: 1 改為 0
  - Rainbow Brackets, Indent Rainbow, Zero Width Characters locator
  - Key Promoter X, AceJump, String Manipulation
  - Statistic, WakaTime, Mario Progress Bar
  - Treegen
- AI 輔助
  - [Codeium](https://blog.user.today/github-copilot-ai-alternatives/#title_i-8)
    - [免費用 Codeium 和 Codium AI來加速開發](https://medium.com/@sarala0725/%E5%85%8D%E8%B2%BB%E7%94%A8codeium%E5%92%8Ccodium-ai%E4%BE%86%E5%8A%A0%E9%80%9F%E9%96%8B%E7%99%BC-d43c060a557d)
    - [用 Codeium 自動完成程式碼](https://b6land.github.io/Codeium_Intro/)
  - 其他: 會衝突, 要擇一使用
    - SuperMaven, [JetBrains Inline Completion](https://www.jetbrains.com/help/idea/full-line-code-completion.html)
    - Tabnine, AWS Toolkit, Amazon Q, Codeium, JetBrains AI Assistant. GitHub Copilot
- considering: - Docker, kubernetes; GitToolBox

## Keymap

- [Mac symbol](https://gist.github.com/jlyonsmith/6992156f18c423fd1c5af068aa311fb5)
  - ⌘ Command(cmd), ⌥ Option, ⌃ Control, ⇧ Shift
  - ← Left, → Right, ↑ Up, ↓ Down
- [Default: JetBrains Rider IntelliJ Keymap](https://resources.jetbrains.com/storage/products/rider/docs/Rider_default_win_shortcuts.pdf)
- Settings: `⌘+,`, `ctrl+alt+s`
- Navigate
  - Search Everywhere: ctrl+T=> `Ctrl+Shift+A`, `⌘+⇧+A`
    - [Cmd+Shift+A hotkey opens Terminal with "apropos" search instead of the Find Action dialog](https://intellij-support.jetbrains.com/hc/en-us/articles/360005137400-Cmd-Shift-A-hotkey-opens-Terminal-with-apropos-search-instead-of-the-Find-Action-dialog)
  - Recently Viewed/Changed Files: `⌘+E`, `Ctrl+E`
  - Main Menu | Navigate (視線的轉移)
    - Back: `⌘+⌃+←`, `ctrl+shift+left`, Forward: `⌘+⌃+→`, `ctrl+shift+right`
    - Navigate in File | Previous Method `⌃+⇧+↑`; Next Method `⌃+⇧+↓`
    - Goto by Reference Actions | Jump to Navigation Bar: `⌘+↑`
  - Main Menu | Window | Editor Tabs
    - New Tab => ctrl+T, Close Tab Ctrl+F4=> ctrl+W, Reopen closed Tab => Crtl+shift+T
    - Select previous tab: `⌘+⌥+←`, `alt+left`; Select next tab: `⌘+⌥+→`, `alt+right`
  - Main Menu | View
    - View Recent Actions Group | Recent Files: `⌘+E`, Recent Location: `⌘+⇧+E`
    - Quick Definition: `⌘+⇧+D`
    - Jump to Source: `⌘+↓`
  - Main Menu | Git
    - VCS Group | Git | Push...: `⌘+⇧+K`
  - Tool Windows
    - Left Top. Explorer: `⌘+1`, Structure: `⌘+2`
    - Left Down. Commit: `⌘+3`, TODO: `⌘+4`, Bookmarks: `⌘+5`
    - Right. Codeium Chat: `⌘+6`, Problem: `⌘+7`, Notification: `⌘+6`
  - shrink selection: ctrl+alt+left
- Code
  - Other | Show Context Actions: `⌥+enter` => `⌘+enter`. alt+enter; +Ctrl+Shift+D
  - [Editor Actions | Paste as Plain Text](https://stackoverflow.com/questions/76500225/rider-copying-and-pasting-text-from-word-pastes-as-image-link/79150716#79150716):
    switch `⌘+⌃+⇧+V` with `⌘+V`
  - Main Menu | Refactor
    - Refactor This: ctrl+alt+shift+R; `⌥+R`, `⌘+⌃+⇧+R`
      - Rename: `⌃+⇧+R`
  - Main Menu | Edit
    - Find: `⌘+F`, Find in file: `⌘+⇧+F`
    - Replace: `⌘+R`, ctrl+R, Replace in file: `⌘+⇧+R`, ctrl+shift+R
  - Main Menu | Code | Code Formatting Actions
    - Reformat Code: `⌥+⇧+F`, Ctrl+Alt+F
    - Optimize Imports: `⌥+⇧+O`, Ctrl+Alt+O
  - Main Menu | Code | Folding |
    - Expand: `⌘ +`, Collapse `⌘ -`; All + "⇧"
      - 小技巧: 先 collapse all 再 expand all, 全部的 markdown link 就會變成 `...`
    - Fold Selection / Remove region: `⌘+.`
  - Plugins | Markdown
    - Create Link: `⌘+K`
      - 小技巧: 在剪貼簿中有 url link 時, 再選取要標是的字段, 按下 Create Link: `⌘+K`, 會自動帶上 url link
    - Generate Table Of Contents: `⌘+N`, Update Table Of Contents
- AceAction (Ctrl+; by default)

## Tutorial

- [Rider Tips](https://www.youtube.com/watch?v=2nWJSgmd-gE)
- [Learning Rider](https://www.jetbrains.com/rider/documentation/)
- [Rider Tips and Tricks for Unity Development](https://www.jetbrains.com/guide/gamedev/links/rider-tips-and-tricks-for-unity-development/)
- [Debugging Unity Games With Rider](https://www.jetbrains.com/guide/gamedev/links/debugging-unity-games-with-rider/)
- [Game development for Unity](https://www.jetbrains.com/help/rider/Unity.html)
