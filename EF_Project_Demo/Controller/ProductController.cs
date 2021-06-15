using EF_Project_Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project_Demo.Controller
{
    public class ProductController
    {
       // private WorkShopContext dbcontext;
        public ProductController()
        {
            // Dbcontext = new WorkShopContext();
        }
        private static ProductController instance;

        public static ProductController Instance {
            get
            {
                if (instance == null) instance = new ProductController();
                return instance;
            }private set => instance = value; }

      //  public WorkShopContext Dbcontext { get => dbcontext; set => dbcontext = value; }

        public void Init()
        {
            var init = ProductController.Instance;
        }

        public List<Product> getList()
        {
            return DbContextController.Instance.Dbcontext.Products.ToList();
        }
        public Product GetProduct(int productID)
        {
            return DbContextController.Instance.Dbcontext.Products.Where(p => p.ProductID == productID).FirstOrDefault();
        }
        public void removeProduct(int ProductID)
        {
            DbContextController.Instance.Dbcontext.Products.Remove(GetProduct(ProductID));
            DbContextController.Instance.Dbcontext.SaveChanges();
        }
        public void insertProduct(Product p)
        {
            DbContextController.Instance.Dbcontext.Products.Add(p);
            DbContextController.Instance.Dbcontext.SaveChanges();
        }

    }
}
