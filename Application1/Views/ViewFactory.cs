using Application1.ViewModels;
using Application1.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1.Views
{
    public class ViewFactory
    {
        public static IView CreateView<TView, TViewModel>() where TView : IView, new()
            where TViewModel : ViewModelBase, new()
        { 
            return new TView() { DataContext = new TViewModel() }; 
        }
    }
}
