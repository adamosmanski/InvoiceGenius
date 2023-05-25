using InvoiceMaster.Core;
using InvoiceMaster.MainModule.Models;
using InvoiceMaster.MainModule.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace InvoiceMaster.SettingsModule.ViewModels
{
    public class SettingsViewModel : ObserveObject
    {
        #region Commands
        public ICommand OpenMyDocumentsCommand { get; }
        #endregion


        #region Properties
        private string _PathToCompanyData = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)).ToString();
        public string PathToCompanyData { get => _PathToCompanyData; set => SetProperty(ref _PathToCompanyData, value); }
        #endregion


        #region Methods
        private void OpenMyDocuments(object obj)
        {
            string myDocumentsPath = Directory.GetCurrentDirectory();

            Process.Start(myDocumentsPath);
        }
        #endregion

        #region Ctor
        public SettingsViewModel()
        {
            OpenMyDocumentsCommand = new RelayCommand(OpenMyDocuments);
        }
        #endregion
    }
}
