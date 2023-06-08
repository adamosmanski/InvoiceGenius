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
        private Invoices _invoices;
        public Invoices Invoices { get => _invoices; set=>_invoices = value; }
        #region Ctor
        public NewInvoiceViewModel() 
        {

        }
        #endregion
    }
}
