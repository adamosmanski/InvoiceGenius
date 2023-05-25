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

        private bool _isEnabled = true;
        public bool isEnabled { get => _isEnabled; set=>this.SetProperty(ref _isEnabled, value); }

        public ICommand Command { get; }
        private void EnableButton(object obj)
        {
            isEnabled = false;
        }
        public InvoiceViewModel()
        {
            Command = new RelayCommand(EnableButton);
        }
    }
}
