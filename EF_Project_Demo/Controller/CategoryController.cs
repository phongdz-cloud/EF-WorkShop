using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Project_Demo.Model;
namespace EF_Project_Demo.Controller
{
    public class CategoryController
    {
       // private WorkShopContext dbcontext;
        public CategoryController()
        {
           // Dbcontext = new WorkShopContext();
        }
        private static CategoryController instance;

        public void Init()
        {
            var init = CategoryController.Instance;
        }
        public static CategoryController Instance
        {
            get
            {
                if (instance == null) instance = new CategoryController();
                return instance;
            }
            private set => instance = value;
        }
       // public WorkShopContext Dbcontext { get => dbcontext; set => dbcontext = value; }

        public List<Category> getList()
        {
            return DbContextController.Instance.Dbcontext.Categories.ToList();
        }
        public Category GetCategory(int CategoryID)
        {
            return DbContextController.Instance.Dbcontext.Categories.Where(p => p.CategoryId == CategoryID).FirstOrDefault();
        }
        public void removeCategory(int CategoryID)
        {
            DbContextController.Instance.Dbcontext.Categories.Remove(GetCategory(CategoryID));
            DbContextController.Instance.Dbcontext.SaveChanges();
        }
        public void insertCategory(Category p)
        {
            DbContextController.Instance.Dbcontext.Categories.Add(p);
            DbContextController.Instance.Dbcontext.SaveChanges();
        }
    }
}
