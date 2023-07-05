using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public static HomeViewModel Create() => new HomeViewModel();

        public string Message { get; set; } = "this is new data";
    }
}
