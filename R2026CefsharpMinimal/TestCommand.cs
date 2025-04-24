using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace R2026CefsharpMinimal
{
    [Transaction(TransactionMode.Manual)]
    public class TestCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            var browserWindow = new BrowserWindow();
            browserWindow.Show();
            return Result.Succeeded;
        }
    }
}
