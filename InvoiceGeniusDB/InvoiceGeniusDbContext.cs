using InvoiceGeniusDB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGeniusDB
{
    public class InvoiceGeniusDb : DbContext
    {
        public static string connectionString = "Server =(LocalDB)\\MSSQLLocalDB; Database=InvoiceGeniusDb;Trusted_Connection=True;";
        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<Company> Company { get; set; }

        public InvoiceGeniusDb() : base()
        {
            
        }
       
    }
}
