using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project_Demo.Model
{
    [Table("CHITIETHOADON")]
    public class SalesDetail
    {
        //[Key]
        public int SaleId { get; set; }
        public Sale Sale { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }

        [Column(TypeName = "money")]
        public decimal Total { get; set; }


    }
}
