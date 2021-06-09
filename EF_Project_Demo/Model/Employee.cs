using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project_Demo.Model
{
    [Table("NHANVIEN")]
    public class Employee
    {
        [Key] // PK
        public int EmployeeId { get; set; }
        [Required]
        [StringLength(50)]
        public string EmployeeName { get; set; }
        [Required]
        [StringLength(50)]
        public string Address { get; set; }
        [Required]
        [StringLength(50)]
        public string Phone { get; set; }
        [Required]
        public int Salary { get; set; }
        public byte[] Image { get; set; }

        public IList<Sale> Sales { get; set; } = new List<Sale>();
    }
}
