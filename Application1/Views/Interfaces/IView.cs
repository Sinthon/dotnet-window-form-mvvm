using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1.Views.Interfaces
{
    public interface IView
    {
        object DataContext { get; set; }
        bool IsDisposed { get; }

        event EventHandler Load;
    }
}
