namespace InvoiceGeniusDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 300),
                        Adress = c.String(nullable: false, maxLength: 500),
                        NIP = c.String(nullable: false, maxLength: 15),
                        Regon = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NumberInvoice = c.String(nullable: false, maxLength: 20),
                        MyCompanyName = c.String(nullable: false, maxLength: 300),
                        NameOfService = c.String(nullable: false),
                        NumberOfService = c.Double(nullable: false),
                        BankAccount = c.String(nullable: false),
                        BankName = c.String(nullable: false),
                        Buyer = c.String(nullable: false, maxLength: 300),
                        DateOfIssue = c.String(nullable: false, maxLength: 12),
                        TaxProcent = c.Int(nullable: false),
                        NetValue = c.String(nullable: false),
                        Total = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Invoices");
            DropTable("dbo.Companies");
        }
    }
}
