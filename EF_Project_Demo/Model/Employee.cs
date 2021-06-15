using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project_Demo.Model
{
   // [Table("NHANVIEN")]
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Salary { get; set; }

        public byte[] Image { get; set; }

        public ICollection<Sale> Sales { get; set; }
        public Employee()
        {
            Sales = new List<Sale>();
        }
    }
}
