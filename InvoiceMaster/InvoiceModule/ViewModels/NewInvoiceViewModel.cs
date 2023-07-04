using InvoiceGeniusDB.Models;
using InvoiceMaster.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceMaster.InvoiceModule.ViewModels
{
    public class NewInvoiceViewModel : ObserveObject
    {
        #region Properties
        private Invoices _invoices;
        private Services _services;
       // private List<Customers> _customerList { get; set; }
        public Invoices Invoices { get => _invoices; set=>_invoices = value; }
        public Services Services { get=>_services; set=>_services = value; }

       // public List<Customers> CustomerList { get => _customerList; set=>this.SetProperty }

        #endregion


        #region Ctor
        public NewInvoiceViewModel() 
        {

        }
        #endregion
    }
}
