using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGeniusDB.Models
{
    [Table("Services")]
    public class Services
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [ForeignKey("Invoices")]
        public int InvoiceID { get; set; }
        public Invoices Invoices { get; set; }
        [Required]
        public string NameOfService { get; set; }
        [Required]
        public double NumberOfService { get; set; }
        [Required]
        public int TaxProcent { get; set; }
        [Required]
        public double NetValue { get; set; }
        [Required]
        public double TaxValue { get; set; }
        [Required]
        public double GrossValue { get; set; }

    }
}
