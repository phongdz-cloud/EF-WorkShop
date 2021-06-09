using EF_Project_Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project_Demo.Data
{
    public class ProductContext
    {
        public static List<Product> getAll()
        {
            using (var dbcontext = new WorkShopContext())
            {
                return dbcontext.Products.ToList();
            }
        }
        public static Product getProduct(int id)
        {
            using (var dbcontext = new WorkShopContext())
            {
                return dbcontext.Products.Where(p=>p.ProductID == id).FirstOrDefault();
            }
        }

    }
}
