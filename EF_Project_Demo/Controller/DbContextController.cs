using EF_Project_Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project_Demo.Controller
{
    public class DbContextController
    {
        private static DbContextController instance;
        private WorkShopContext dbcontext;
        public DbContextController()
        {
            Dbcontext = new WorkShopContext();
        }
        public static DbContextController Instance { get { if (instance == null) instance = new DbContextController(); return instance; }private  set => instance = value; }

        public WorkShopContext Dbcontext { get => dbcontext; set => dbcontext = value; }
    }
}
