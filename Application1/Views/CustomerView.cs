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
    public partial class CustomerView : Form , IView
    {
        public CustomerView()
        {
            InitializeComponent();

            this.Load += (sender, e) => BindViewModel();
        }

        public object DataContext { get; set; }

        private void BindViewModel()
        {
            this.dataGridView2.DataBindings.Add("DataSource", DataContext, "Customers", true, DataSourceUpdateMode.OnPropertyChanged);
            this.dataGridView1.DataBindings.Add("DataSource", DataContext, "Customers", true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
