using DynamicData;
using DynamicData.Binding;
using InvoiceGeniusDB;
using InvoiceGeniusDB.Models;
using InvoiceMaster.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceMaster.CustomersModule.ViewModels
{
    public class CustomerViewModels : ObserveObject
    {
        private List<Customers> _customersList = new List<Customers>();
        public List<Customers> CustomersList { get => _customersList; set { _customersList = value; SetProperty(ref _customersList, CustomersList); } }
        //private Customers _customer;
        //public Customers Customer { get => _customer; set => _customer = value; }
        #region
        private void LoadFromDatabase()
        {
            _customersList.Clear();
            using (InvoiceGeniusContext ct = new InvoiceGeniusContext())
            {
                _customersList.AddRange(ct.Customers.ToList());
            }
        }
        #endregion
        #region ctor
        public CustomerViewModels() 
        {
           LoadFromDatabase();
        }
        #endregion
    }
}
