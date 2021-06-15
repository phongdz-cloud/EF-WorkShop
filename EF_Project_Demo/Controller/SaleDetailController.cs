using EF_Project_Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project_Demo.Controller
{
    public class SaleDetailController
    {
        private static SaleDetailController instance;
       // private WorkShopContext dbcontext;
        public SaleDetailController()
        {
           // dbcontext = new WorkShopContext();
        }
        public static SaleDetailController Instance { get { if (instance == null) instance = new SaleDetailController(); return instance; } set => instance = value; }
      //  public WorkShopContext Dbcontext { get => dbcontext; set => dbcontext = value; }
        public List<SalesDetail> getList()
        {
            return DbContextController.Instance.Dbcontext.SalesDetails.ToList();
        }
        public SalesDetail GetSalesDetail(int SalesDetailID)
        {
            return DbContextController.Instance.Dbcontext.SalesDetails.Where(p => p.SaleId == SalesDetailID).FirstOrDefault();
        }
        public void removeSalesDetail(int SalesDetailID)
        {
            DbContextController.Instance.Dbcontext.SalesDetails.Remove(GetSalesDetail(SalesDetailID));
            DbContextController.Instance.Dbcontext.SaveChanges();
        }
        public void insertSalesDetail(SalesDetail p)
        {
            DbContextController.Instance.Dbcontext.SalesDetails.Add(p);
            DbContextController.Instance.Dbcontext.SaveChanges();
        }

    }
}
