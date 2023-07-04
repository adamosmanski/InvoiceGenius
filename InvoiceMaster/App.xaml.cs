using InvoiceMaster.CompanyModule.Views;
using InvoiceMaster.MainModule;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;
using System.IO;
using InvoiceMaster.CompanyModule.Model;
using System.Globalization;
using System.Threading;
using InvoiceGeniusDB;
using Microsoft.EntityFrameworkCore;

namespace InvoiceMaster
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected void Start(object sender, StartupEventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pl-PL");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pl-PL");
            var jsonPathFile = Path.Combine(Directory.GetCurrentDirectory(), "CompanyData.json");
            using (var dbContext = new InvoiceGeniusContext())
            {
                dbContext.Database.Migrate();
            }
            if (File.Exists(jsonPathFile))
            {
                string jsonData = File.ReadAllText(jsonPathFile);
                var data = JsonConvert.DeserializeObject<CompanyData>(jsonData);

                CompanyStaticData.CompanyName = data.CompanyName;
                CompanyStaticData.CompanyNip = data.CompanyNip;
                CompanyStaticData.CompanyRegon = data.CompanyRegon;
                CompanyStaticData.CompanyAccountBank = data.CompanyAccountBank;
                CompanyStaticData.CompanyAccountNumber = data.CompanyAccountNumber;
                CompanyStaticData.CompanyCity = data.CompanyAdress.CompanyCity;
                CompanyStaticData.CompanyStreet = data.CompanyAdress.CompanyStreet;
                CompanyStaticData.CompanyFlatNumber = data.CompanyAdress.CompanyFlatNumber;
                CompanyStaticData.CompanyBuildNumber = data.CompanyAdress.CompanyBuildNumber;

                var MainView = new MainWindow();
                MainView.Show();
            }
            else
            {
                OwnCreatorCompanyView ownCreatorCompanyView = new OwnCreatorCompanyView();
                ownCreatorCompanyView.Show();
            }

        }
    }
}
