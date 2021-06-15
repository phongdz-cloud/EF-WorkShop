using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project_Demo.Model
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public byte[] Image { get; set; }
        public int? CategoryID { get; set; }
        public Category Category { get; set; }

        public ICollection<SalesDetail> SalesDetails { get; set; } = new List<SalesDetail>();
    }
}
