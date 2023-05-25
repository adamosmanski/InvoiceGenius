using InvoiceMaster.Core;
using InvoiceMaster.MainModule;
using InvoiceMaster.MessageBoxModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Newtonsoft.Json;
using System.IO;
using InvoiceMaster.CompanyModule.Model;

namespace InvoiceMaster.CompanyModule.ViewModels
{
    public class OwnCreatorCompanyViewModel : ObserveObject, IDataErrorInfo
    {
        #region Properties
        private string _CompanyName;
        public string CompanyName { get => _CompanyName; set => this.SetProperty(ref _CompanyName, value); }

        private string _CompanyNip;
        public string CompanyNip { get => _CompanyNip; set=>this.SetProperty(ref _CompanyNip, value); }

        private string _CompanyRegon;
        public string CompanyRegon { get => _CompanyRegon; set=>this.SetProperty(ref _CompanyRegon, value); }

        private string _CompanyCity;
        public string CompanyCity { get => _CompanyCity; set=>this.SetProperty(ref _CompanyCity, value); }

        public string CompanyStreet { get => _CompanyStreet; set => this.SetProperty(ref _CompanyStreet, value); }
        private string _CompanyStreet;

      
        public string CompanyFlatNumber { get => _CompanyFlatNumber; set => this.SetProperty(ref _CompanyFlatNumber, value); }
        private string _CompanyFlatNumber;

        public string CompanyBuildNumber { get => _CompanyBuildNumber; set => this.SetProperty(ref _CompanyBuildNumber, value); }
        private string _CompanyBuildNumber;
        
        private string _CompanyAccountNumber;
        public string CompanyAccountNumber { get => _CompanyAccountNumber; set => this.SetProperty(ref _CompanyAccountNumber, value); }

        private string _CompanyAccountBank;


        public string CompanyAccountBank { get => _CompanyAccountBank; set => this.SetProperty(ref _CompanyAccountBank, value); }

        public string Error => throw new NotImplementedException();

        public string this[string columnName]
        {
            get
            {
                string result = null;
                if (columnName == nameof(CompanyName))
                {

                    if (string.IsNullOrEmpty(_CompanyName))
                    {
                        result = "error";
                    }
                }
                if(columnName == nameof(CompanyNip))
                {

                    if (string.IsNullOrEmpty(_CompanyNip) || _CompanyNip.Length <10 || _CompanyNip.Length>11)
                    {
                        result = "error";
                    }
                }
                if (columnName == nameof(CompanyRegon))
                {

                    if (string.IsNullOrEmpty(_CompanyRegon))
                    {
                        result = "error";
                    }
                }
                if (columnName == nameof(CompanyCity))
                {

                    if (string.IsNullOrEmpty(_CompanyCity))
                    {
                        result = "error";
                    }
                }
                if (columnName == nameof(CompanyStreet))
                {

                    if (string.IsNullOrEmpty(_CompanyStreet))
                    {
                        result = "error";
                    }
                }
                if (columnName == nameof(CompanyAccountNumber))
                {

                    if (string.IsNullOrEmpty(_CompanyAccountNumber))
                    {
                        result = "error";
                    }
                }
                if (columnName == nameof(CompanyAccountBank))
                { 

                    if (string.IsNullOrEmpty(_CompanyAccountBank))
                    {
                        result = "error";
                    }
                }
                if (columnName == nameof(CompanyFlatNumber))
                {

                    if (string.IsNullOrEmpty(_CompanyFlatNumber))
                    {
                        result = "error";
                    }
                }
                if (columnName == nameof(CompanyBuildNumber))
                {

                    if (string.IsNullOrEmpty(_CompanyBuildNumber))
                    {
                        result = "error";
                    }
                }
                return result;
            }
        }
        #endregion

        #region Methods
        private void SaveCompany(object obj)
        {
  
            var result = MessageBox.Show("Czy chcesz zapisać dane firmy?","Zapisz dane", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if(result == MessageBoxResult.Yes)
            {
                CompanyStaticData.CompanyStreet = CompanyStreet;
                CompanyStaticData.CompanyFlatNumber = CompanyFlatNumber;
                CompanyStaticData.CompanyBuildNumber = CompanyBuildNumber;
                CompanyStaticData.CompanyCity = CompanyCity;
                CompanyStaticData.CompanyAccountBank = CompanyAccountBank;
                CompanyStaticData.CompanyAccountNumber = CompanyAccountNumber;
                CompanyStaticData.CompanyNip = CompanyNip;
                CompanyStaticData.CompanyName = CompanyName;
                CompanyStaticData.CompanyRegon = CompanyRegon;

                var Adress = new
                {
                    CompanyCity = CompanyCity,
                    CompanyStreet = CompanyStreet,
                    CompanyFlatNumber = CompanyFlatNumber,
                    CompanyBuildNumber = CompanyBuildNumber
                };

                var CompanyJsonData = new
                {
                    CompanyName = CompanyName,
                    CompanyNip = CompanyNip,
                    CompanyRegon = CompanyRegon,
                    CompanyAccountBank = CompanyAccountBank,
                    CompanyAccountNumber = CompanyAccountNumber,
                    Adress = Adress
                };
                string jsonData = JsonConvert.SerializeObject(CompanyJsonData, Formatting.Indented);
                string FilePath = Path.Combine(Directory.GetCurrentDirectory(), "CompanyData.json");
                File.WriteAllText(FilePath, jsonData);

                MainWindow Window = new MainWindow();
                App.Current.MainWindow.Close();
                Window.Show();
            }

        }
        #endregion

        #region Commands
        public ICommand SaveCompanyCommand { get; }
        #endregion

        #region Ctor
        public OwnCreatorCompanyViewModel()
        {
            SaveCompanyCommand = new RelayCommand(SaveCompany);
        }
        #endregion
    }
}
