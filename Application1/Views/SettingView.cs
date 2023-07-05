using Application1.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application1.Views
{
    public partial class SettingView : Form, IView
    {
        public SettingView()
        {
            InitializeComponent();
        }

        public object DataContext 
        { 
            get; 
            set; 
        }
    }
}
