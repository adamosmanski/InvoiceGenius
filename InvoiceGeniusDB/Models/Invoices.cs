
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGeniusDB.Models
{
    public class Invoices
    {
        [Key]
        public int ID { get; set; }
        
        [MaxLength(20)]
        [Required]
        public string NumberInvoice { get; set; }

        [MaxLength(300)]
        [Required]
        public string MyCompanyName { get; set; }

        [Required]
        public string NameOfService { get; set; }

        [Required]
        public double NumberOfService { get; set; }

        [Required]
        public string BankAccount { get; set; }

        [Required]
        public string BankName { get; set; }

        [Required]
        [MaxLength(300)]
        public string Buyer { get; set; }

        [Required]
        [MaxLength(12)]
        public string DateOfIssue { get; set; }
        [Required]
        public int TaxProcent { get; set; }

        [Required]
        public string NetValue { get; set; }

        [Required]
        public string Total { get; set; }

        //Insert into [InvoiceMaster].[dbo].[Invoices] values('1', ' 1/04/2023', 'Usługi programistyczne', '38116022020000000563771589','UNDER ANT SPÓŁKA Z OGRANICZONĄ ODPOWIEDZIALNOŚCIĄ SPÓŁKA KOMANDYTOWA',
//'TechWave Solutions - Adam Osmański', '2023-04-30', '11685',23, '9500')
    }
}
