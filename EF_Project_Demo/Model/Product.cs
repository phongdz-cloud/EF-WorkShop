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
    [Table("SANPHAM")]
    public class Product
    {
        [Key] //PK
        public int ProductID { get; set; }
        [Required] // not null
        [Column(TypeName = "ntext")]
        [StringLength(50)]
        public string ProductName { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        [Required]
        public byte[] Image { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}
