using InvoiceGeniusDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;


namespace InvoiceGeniusDB
{
    public class InvoiceGeniusContext : DbContext
    {
        public static readonly string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=InvoiceGenius;Trusted_Connection=True;";
        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public InvoiceGeniusContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
