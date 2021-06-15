using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project_Demo.Model
{
    public class SalesDetail
    {
        public int SaleId { get; set; } 
        public Sale Sale { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }

        public int Amount { get; set; }


    }
}
