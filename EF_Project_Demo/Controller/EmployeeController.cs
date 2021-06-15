using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Project_Demo.Model;
namespace EF_Project_Demo.Controller
{
    public class EmployeeController
    {
     //   private WorkShopContext dbcontext;
        public  EmployeeController()
        {
         //   Dbcontext = new WorkShopContext();
        }
        public void Init()
        {
            var init = EmployeeController.Instance;
        }
        private static EmployeeController instance;

        public static EmployeeController Instance
        {
            get
            {
                if (instance == null) instance = new EmployeeController();
                return instance;
            }
            private set => instance = value;
        }
     //   public WorkShopContext Dbcontext { get => dbcontext; set => dbcontext = value; }
        public List<Employee> getList()
        {
            return DbContextController.Instance.Dbcontext.Employees.ToList();
        }
        public Employee GetEmloyee(int emloyeeID)
        {
            return DbContextController.Instance.Dbcontext.Employees.Where(p => p.EmployeeId == emloyeeID).FirstOrDefault();
        }
        public void removeEmloyee(int employeeID)
        {
            DbContextController.Instance.Dbcontext.Employees.Remove(GetEmloyee(employeeID));
            DbContextController.Instance.Dbcontext.SaveChanges();
        }
        public void insertEmloyee(Employee p)
        {
            DbContextController.Instance.Dbcontext.Employees.Add(p);
            DbContextController.Instance.Dbcontext.SaveChanges();
        }
    }
}
