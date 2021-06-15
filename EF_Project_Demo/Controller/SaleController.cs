using EF_Project_Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project_Demo.Controller
{
    public class SaleController
    {
        private static SaleController instance;
       // private WorkShopContext dbcontext;
        public SaleController()
        {
          //  dbcontext = new WorkShopContext();
        }


        public static SaleController Instance { get { if (instance == null) instance = new SaleController(); return instance; } private set => instance = value; }

       // public WorkShopContext Dbcontext { get => dbcontext; set => dbcontext = value; }
        public List<Sale> getList()
        {
            return DbContextController.Instance.Dbcontext.Sales.ToList();
        }
        public Sale GetSale(int SaleID)
        {
            return DbContextController.Instance.Dbcontext.Sales.Where(p => p.SaleId == SaleID).FirstOrDefault();
        }
        public void removeSale(int SaleID)
        {
            DbContextController.Instance.Dbcontext.Sales.Remove(GetSale(SaleID));
            DbContextController.Instance.Dbcontext.SaveChanges();
        }
        public void insertSale(Sale p)
        {
            DbContextController.Instance.Dbcontext.Sales.Add(p);
            DbContextController.Instance.Dbcontext.SaveChanges();
        }
    }
}
