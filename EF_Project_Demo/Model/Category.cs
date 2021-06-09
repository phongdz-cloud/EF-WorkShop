using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project_Demo.Model
{
    [Table("DANHMUC")]
    public class Category
    {
        [Key] // Khóa chính
        public int CategoryId { get; set; }
        [Required] // not null
        [Column(TypeName = "ntext")]
        public string CategoryName { get; set; }
        [Required] // not null
        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public IList<Product> Products { get; set; } = new List<Product>();

    }
}
