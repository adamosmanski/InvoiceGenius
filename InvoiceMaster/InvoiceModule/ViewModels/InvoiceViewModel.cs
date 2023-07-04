using InvoiceGeniusDB.Models;
using InvoiceMaster.Core;
using InvoiceMaster.InvoiceModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Media3D;

namespace InvoiceMaster.InvoiceModule.ViewModels
{
    public class InvoiceViewModel : ObserveObject
    {
        #region Properties

        private List<Invoices> _listInvoices;
        private ObserveObject _viewModel;

        public List<Invoices> ListInvoices { get => _listInvoices;set=>this.SetProperty(ref _listInvoices, value); }
        public ObserveObject ViewModel { get => _viewModel; set => this.SetProperty(ref _viewModel, value); }
        #endregion

        #region Command
        public ICommand SelectButtonCommand { get; }
        #endregion

        #region Method
        private void SelectButtonMethod(object obj)
        {
            switch (obj)
            {
                case EInvoiceMenu.Add:
                    ViewModel = new NewInvoiceViewModel();
                    break;
                case EInvoiceMenu.Edit:
                    break;
                case EInvoiceMenu.Preview:
                    break;
                case EInvoiceMenu.Print:
                    break;
                case EInvoiceMenu.Refresh:
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Ctor

        public InvoiceViewModel()
        {
            SelectButtonCommand = new RelayCommand(SelectButtonMethod);
        }
        #endregion
    }
}
