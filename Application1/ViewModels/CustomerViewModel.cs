using Application1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1.ViewModels
{
    public class CustomerViewModel : ViewModelBase
    {
        public static CustomerViewModel Create() => new CustomerViewModel();

        private ObservableCollection<Customer> _customerList;
        public ObservableCollection<Customer> Customers 
        {
            get => _customerList;
            set
            {
                _customerList = value;
                OnPropertyChanged(nameof(Customers));
            }
        }

        public CustomerViewModel()
        {
            this.Customers = new ObservableCollection<Customer>()
            {
                new Customer() 
                {
                    Name = "Test",
                }
            };
        }
    }
}
