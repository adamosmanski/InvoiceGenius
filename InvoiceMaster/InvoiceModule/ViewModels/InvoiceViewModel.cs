using InvoiceGeniusDB.Models;
using InvoiceMaster.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace InvoiceMaster.InvoiceModule.ViewModels
{
    public class InvoiceViewModel : ObserveObject
    {
        private List<Invoices> _listInvoices;

        public List<Invoices> ListInvoices { get => _listInvoices;set=>this.SetProperty(ref _listInvoices, value); }

      
        private void EnableButton(object obj)
        {
           
        }
        public InvoiceViewModel()
        {

        }
    }
}
