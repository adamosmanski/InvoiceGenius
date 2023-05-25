using InvoiceMaster.Core;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InvoiceMaster.MessageBoxModule
{
    public class CustomMessageBoxViewModel : ObserveObject
    {
        public string Information { get => _Information; set => this.SetProperty(ref _Information, value); }
        private string _Information;

        public CustomMessageBoxViewModel(string information)
        {
            Information = information;
        }
    }
}
