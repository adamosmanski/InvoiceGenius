using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGeniusDB.Models
{
    public class Company
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(300)]
        public string Name { get; set; }

        [Required]
        [MaxLength(500)]
        public string Adress { get; set; }

        [Required]
        [MaxLength(15)]
        public string NIP { get; set; }
        [Required]
        [MaxLength(15)]
        public string Regon { get; set; }
    }
}
