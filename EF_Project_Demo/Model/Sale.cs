using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project_Demo.Model
{
    public class Sale
    {
        public int SaleId { get; set; }
        public DateTime InvoiceDate { get; set; }

        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public double Total { get; set; }

        public ICollection<SalesDetail> SalesDetails { get; set; } = new List<SalesDetail>();

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
