using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1.Views
{
    public interface IView
    {
        object DataContext { get; set; }
    }
}
