using System;
using System.Windows.Forms;
using System.Configuration;
using HumanResourcesSystem.Presenters;
using HumanResourcesSystem.Properties;
using System.Resources;

namespace HumanResourcesSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainView = new MainView();
            _ = new MainPresenter(mainView);

            Application.Run(mainView);
        }
    }
}
