using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application1.Views.Partials
{
    public partial class NavigationBar : UserControl
    {
        public IViewManager Manager { get => ViewManager.Default; }

        public NavigationBar()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Manager.NavigateView(nameof(HomeView));
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Manager.NavigateView(nameof(CustomerView));
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Manager.NavigateView(nameof(SettingView));
        }
    }
}
