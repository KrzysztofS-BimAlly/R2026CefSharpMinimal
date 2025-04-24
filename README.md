This repository contains a minimal Revit 2026 plugin demonstrating a crash that occurs in my case, when InitializeComponent is called on a WPF window containing a ChromiumWebBrowser from the CefSharp library.

The addin and build output have to be copied manually to `C:\ProgramData\Autodesk\Revit\Addins\2026\R2026CefsharpMinimal.addin` and `C:\ProgramData\Autodesk\ApplicationPlugins\R2026CefsharpMinimal\` respectively.

Running the Test command in the added ribbon results in Revit crashing and the window below.

![image](https://github.com/user-attachments/assets/b7a72cae-5855-4a1f-a334-43c499088c7f)

I had done my best to adhere to the CefSharp quick start instructions: https://github.com/cefsharp/CefSharp/wiki/Quick-Start-For-MS-.Net-5.0-or-greater

I had attempted to look into Revit Journals, last available information is that the CefSharp dlls have been loaded in:

```
  'E 24-Apr-2025 10:55:08.698;   0:< 
  Jrn.RibbonEvent "Execute external command:CustomCtrl_%CustomCtrl_%R2026CefsharpMinimal%R2026CefsharpMinimal%R2026CefsharpMinimalTest:R2026CefsharpMinimal.TestCommand" 
' 1:< The requested assembly 'CefSharp.Wpf, Version=135.0.170.0, Culture=neutral, PublicKeyToken=40c4b6fc221f4138' was loaded to the context 'R2026CEFSHARPMINIMALBROWSERCONTEXT' from 'C:\ProgramData\Autodesk\ApplicationPlugins\R2026CefsharpMinimal\CefSharp.Wpf.dll'. 
' 1:< The requested assembly 'CefSharp, Version=135.0.170.0, Culture=neutral, PublicKeyToken=40c4b6fc221f4138' was loaded to the context 'R2026CEFSHARPMINIMALBROWSERCONTEXT' from 'C:\ProgramData\Autodesk\ApplicationPlugins\R2026CefsharpMinimal\CefSharp.dll'. 
' 1:< The requested assembly 'CefSharp.Core, Version=135.0.170.0, Culture=neutral, PublicKeyToken=40c4b6fc221f4138' was loaded to the context 'R2026CEFSHARPMINIMALBROWSERCONTEXT' from 'C:\ProgramData\Autodesk\ApplicationPlugins\R2026CefsharpMinimal\CefSharp.Core.dll'. 
' 1:< ::97:: Delta VM: Avail -65749 -> 133848345 MB, Used +4 -> 714 MB; RAM: Avail +2 -> 6805 MB, Used +4 -> 1009 MB, Peak +1 -> 1009 MB 
' 1:< GUI Resource Usage GDI: Avail 8745, Used 1255, User: Used 489 
' 1:< The requested assembly 'CefSharp.Core.Runtime, Version=135.0.170.0, Culture=neutral, PublicKeyToken=40c4b6fc221f4138' was loaded to the context 'R2026CEFSHARPMINIMALBROWSERCONTEXT' from 'C:\ProgramData\Autodesk\ApplicationPlugins\R2026CefsharpMinimal\CefSharp.Core.Runtime.dll'. 
```
