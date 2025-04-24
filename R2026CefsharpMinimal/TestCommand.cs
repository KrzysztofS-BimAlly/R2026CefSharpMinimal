using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using CefSharp;

namespace R2026CefsharpMinimal
{
    [Transaction(TransactionMode.Manual)]
    public class TestCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            var cefSettings = new CefSharp.Wpf.CefSettings();
            DependencyChecker.AssertAllDependenciesPresent(cefSettings.Locale, cefSettings.LocalesDirPath, cefSettings.ResourcesDirPath, false, cefSettings.BrowserSubprocessPath);

            var browserWindow = new BrowserWindow();
            browserWindow.Show();
            return Result.Succeeded;
        }
    }
}
