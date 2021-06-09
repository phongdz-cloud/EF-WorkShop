using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project_Demo.Model
{
    [Table("HOADON")]
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }
        [Required]
        public DateTime InvoiceDate { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
