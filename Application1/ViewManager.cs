using Application1.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Application1
{
    public interface IViewManager
    {
        void RegisterView(string key, IModule module);

        void NavigateView(string viewName);

        event EventHandler<EventArgs> OnNavigateView;
    }

    public class ViewManager : IViewManager
    {
        private static IViewManager viewManager;

        public static IViewManager Default
        {
            get
            {
                if(viewManager == null)
                {
                    viewManager = new ViewManager();
                }
                return viewManager;
            }
        }

        public static Dictionary<string, Module> _registeredViews = new Dictionary<string, Module>();

        public event EventHandler<EventArgs> OnNavigateView;

        public void NavigateView(string viewName)
        {
            if(!_registeredViews.ContainsKey(viewName))
            {
                throw new ArgumentNullException();
            }

            OnNavigateView?.Invoke(_registeredViews[viewName].CurrentView, EventArgs.Empty);
        }

        public void RegisterView(string key, IModule module)
        {
            if(!_registeredViews.ContainsKey(key))
            {
                _registeredViews.Add(key, (Module)module);
            }

            _registeredViews[key] = (Module)module;
        }
    }

    public interface IModule
    {
        IView CurrentView { get; }

        Func<object> ViewModelFactory { get; }

        Type ViewType { get; }
    }

    public class Module : IModule
    {
        private IView currentView = null;

        public IView CurrentView
        {
            get
            {
                if(currentView == null || currentView.IsDisposed)
                {
                    currentView = new ViewBuilder().AddView(ViewType).AddDataContext(ViewModelFactory).Build();
                }
                return currentView;
            }
        }

        public Func<object> ViewModelFactory { get; }

        public Type ViewType { get; }

        public Module(Type viewType, Func<object> viewModelFactory)
        {
            ViewModelFactory = viewModelFactory;
            ViewType = viewType;
        }
    }

    public class ViewBuilder
    {
        public IView View;

        public ViewBuilder AddView(Type viewType)
        {
            this.View = (IView)Activator.CreateInstance(viewType);
            return this;
        }

        public ViewBuilder AddView(IView view)
        {
            this.View = view;
            return this;
        }

        public ViewBuilder AddDataContext(Func<object> ViewModelFactory)
        {
            this.View.DataContext = ViewModelFactory();
            return this;
        }

        public IView Build() { return View; }
    }
}
