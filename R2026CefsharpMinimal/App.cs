using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace R2026CefsharpMinimal
{
    public class App : IExternalApplication
    {
        string RIBBON_TAB = "R2026CefsharpMinimal";
        string RIBBON_TOOLS_PANEL = "R2026CefsharpMinimal";

        public static readonly int REVIT_VERSION = 2024;

        UIControlledApplication _uiapp = null;

        public Result OnStartup(UIControlledApplication uiapp)
        {
            _uiapp = uiapp;

            // create the tab and panel
            try
            {
                uiapp.CreateRibbonTab(RIBBON_TAB);
            }
            catch (Exception) { } // tab already exist

            AddPanelsAndButtons();

            return Result.Succeeded;
        }

        private void AddPanelsAndButtons()
        {
            RibbonPanel toolsPanel = GetRibbonPanel(RIBBON_TAB, RIBBON_TOOLS_PANEL);

            PushButtonData homeBtnData = new PushButtonData(
                "R2026CefsharpMinimalTest",
                "Test",
                Assembly.GetExecutingAssembly().Location,
                "R2026CefsharpMinimal.TestCommand");
            PushButton homeButton = toolsPanel.AddItem(homeBtnData) as PushButton;

            toolsPanel.AddSeparator();
        }

        private RibbonPanel GetRibbonPanel(string tabName, string panelName)
        {
            RibbonPanel panel = null;
            List<RibbonPanel> panels = _uiapp.GetRibbonPanels(tabName);
            foreach (RibbonPanel pnl in panels)
            {
                if (pnl.Name == panelName)
                {
                    panel = pnl;
                    break;
                }
            }

            if (panel == null)
            {
                panel = _uiapp.CreateRibbonPanel(tabName, panelName);
            }
            return panel;
        }

        public Result OnShutdown(UIControlledApplication uiapp)
        {
            return Result.Succeeded;
        }
    }
}
