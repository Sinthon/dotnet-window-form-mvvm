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
    public partial class MainView : Form, IView
    {
        public IViewManager Manager { get => ViewManager.Default; }

        public MainView()
        {
            InitializeComponent();
            Manager.OnNavigateView += OnNavigateView;
        }

        private void OnNavigateView(object sender, EventArgs e)
        {
            var form = sender as Form;
            form.MdiParent = this;
            form.Show();
            form.BringToFront();
        }

        public object DataContext { get; set; }
    }
}
