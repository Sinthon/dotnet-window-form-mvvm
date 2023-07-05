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
            Manager.NavigateView(nameof(HomeView));
        }

        private void OnNavigateView(object view, EventArgs e)
        {
            var form = view as Form;
            form.MdiParent = this;
            form.Show();
            form.BringToFront();
        }


        public object DataContext { get; set; }

        private void button1_Click(object sender, EventArgs e) { Manager.NavigateView(nameof(HomeView)); }
    }
}
