using EF_Project_Demo.Controller;
using EF_Project_Demo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Project_Demo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            pnChild.Controls.Clear();
            pnChild.Controls.Add(new USCEmployee());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            //Category category = new Category()
            //{
            //    CategoryName = "Thuc An",
            //    Description = "Thuc an banh gao"
            //};
            //var dbcontext = new WorkShopContext();
            //dbcontext.Categories.Add(category);
            //dbcontext.SaveChanges();
            pnChild.Controls.Clear();
            pnChild.Controls.Add(new USCProduct());
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            pnChild.Controls.Clear();
            pnChild.Controls.Add(new USCSell());
        }

        private void pnChild_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnChild.Controls.Clear();
            pnChild.Controls.Add(new USCHome());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
