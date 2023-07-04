using InvoiceMaster.CompanyModule.Model;
using InvoiceMaster.Core;
using InvoiceMaster.MainModule.Models;
using InvoiceMaster.InvoiceModule.ViewModels;
using InvoiceMaster.SettingsModule.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using InvoiceGeniusDB;
using InvoiceGeniusDB.Models;
using System.Windows;
using InvoiceMaster.CustomersModule.ViewModels;

namespace InvoiceMaster.MainModule.ViewModels
{
    public class MainViewModel : ObserveObject
    {
        #region Methods
        private async void ChangeView(object obj)
        {
            switch (obj)
            {
                case EMenu.Invoice:
                    ViewModel = new InvoiceViewModel();
                    break;
                case EMenu.Settings:
                    ViewModel = new SettingsViewModel();
                    break;
                case EMenu.Customers:
                    ViewModel = new CustomerViewModels();
                    break;
                default:
                    ViewModel = null;
                    break;
            }
        }

        #endregion

        #region Commands
        public ICommand ChangeViewCommand { get; }
        #endregion


        #region Properties
        private string _dateTime;
        public string DateTime 
        {
            get => _dateTime;
            set=> SetProperty(ref _dateTime, value);
            
        }

        private bool _isEnabled = true;
        public bool IsEnabled { get => _isEnabled; set => this.SetProperty(ref _isEnabled, value); }
        public ObserveObject ViewModel
        {
            get => _viewModel;
            set => SetProperty(ref _viewModel, value);
        }
        private ObserveObject _viewModel;
        #endregion


        #region Ctor
        public MainViewModel()
        {
            _viewModel = null;
            if(CompanyStaticData.CompanyName == "TechWave Solutions - Adam Osmański")
            {
                _dateTime = $"Invoice Master {System.DateTime.Now.ToShortDateString()} - TechWave Solutions";
            }
            else
            {
                _dateTime = $"Invoice Master {System.DateTime.Now.ToShortDateString()} - {CompanyStaticData.CompanyName}";
            }
            ChangeViewCommand = new RelayCommand(ChangeView);
        }
        #endregion
    }
}
