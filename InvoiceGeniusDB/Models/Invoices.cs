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
    [Table("Invoices")]
    public class Invoices
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [ForeignKey("Company")]
        public int CompanyID { get; set; }
        public Company Company { get; set; }

        [MaxLength(20)]
        [Required]
        public string NumberInvoice { get; set; }

        [MaxLength(300)]
        [Required]
        public string MyCompanyName { get; set; }


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
        public double Total { get; set; }
    }
}
