using Application1.ViewModels;
using Application1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application1
{
    internal static class Program
    {
        private static Bootstrapper Bootstrapper;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Bootstrapper = new Bootstrapper();
            Bootstrapper.Run();

            var mainView = ViewFactory.CreateView<MainView, MainViewModel>();
            Application.Run((Form)mainView);
        }
    }
}
