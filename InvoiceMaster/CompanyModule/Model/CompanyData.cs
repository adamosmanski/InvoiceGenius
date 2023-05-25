using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceMaster.CompanyModule.Model
{
    public class CompanyData
    {
        public string CompanyName { get; set; }
        public string CompanyNip { get; set; }
        public string CompanyRegon { get; set; }
        public CompanyAdress CompanyAdress { get; set; }
        public string CompanyAccountNumber { get; set; }
        public string CompanyAccountBank { get; set; }

        public CompanyData()
        {
            CompanyAdress = new CompanyAdress();
        }

    }

    public class CompanyAdress
    {
        public string CompanyCity { get; set; }
        public string CompanyStreet { get; set; }
        public string CompanyFlatNumber { get; set; }
        public string CompanyBuildNumber { get; set; }
    }
}
