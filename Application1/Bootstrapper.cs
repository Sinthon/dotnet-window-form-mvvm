using Application1.ViewModels;
using Application1.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1
{
    public class Bootstrapper
    {
        protected IViewManager Manager
        {
            get => ViewManager.Default;
        }

        public virtual void Run()
        {
            RegisterView();
            ConfigureNavigation();
        }

        protected virtual void RegisterView()
        {
            Manager.RegisterView(nameof(HomeView), new Module(typeof(HomeView), () => HomeViewModel.Create()));
            Manager.RegisterView(nameof(SettingView), new Module(typeof(SettingView), () => SettingViewModel.Create()));
        }


        protected virtual void ConfigureNavigation()
        {
            Manager.OnNavigateView += ManagerOnNavigateView;
        }

        private void ManagerOnNavigateView(object sender, EventArgs e)
        {
            
        }
    }
}
