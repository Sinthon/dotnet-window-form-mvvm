using Application1.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application1.Views.Interfaces;

namespace Application1.Views
{
    public partial class HomeView : Form, IView
    {
        public IViewManager Manager
        {
            get => ViewManager.Default;
        }

        public HomeView()
        {
            InitializeComponent();
            this.Load += (sender, e) => BindViewModel();
        }

        public object DataContext { get; set; }

        private void BindViewModel()
        {
            this.textBox1.DataBindings.Add("Text", DataContext, "Message", true, DataSourceUpdateMode.OnPropertyChanged);
            this.textBox2.DataBindings.Add("Text", DataContext, "Message", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager.NavigateView(nameof(SettingView));
        }
    }
}
