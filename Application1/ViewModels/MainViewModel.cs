﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel() {
            
        }

        public IViewManager Manager
        {
            get => ViewManager.Default;
        }
    }
}
