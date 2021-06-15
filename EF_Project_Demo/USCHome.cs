using EF_Project_Demo.Controller;
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
    public partial class USCHome : UserControl
    {
        public USCHome()
        {
            InitializeComponent();
        }

        private void USCHome_Load(object sender, EventArgs e)
        {
            dgvSaleDetail.AutoGenerateColumns = false;
            EmployeeID.DataSource = EmployeeController.Instance.getList();
            EmployeeID.DisplayMember = "EmployeeName";
            EmployeeID.ValueMember = "EmployeeID";
            ProductID.DataSource = ProductController.Instance.getList();
            ProductID.DisplayMember = "ProductName";
            ProductID.ValueMember = "ProductID";
            dgvSaleDetail.DataSource = SaleController.Instance.getList()
                                  .Join(SaleDetailController.Instance.getList(),
                                  sDetail => sDetail.SaleId,
                                  s => s.SaleId,
                                      (s, sDetail) => new { s.SaleId, s.EmployeeId, sDetail.ProductID, sDetail.Amount, s.InvoiceDate }).Distinct().ToList();

             double sum=0;
            SaleController.Instance.getList().ForEach(s => sum += s.Total);
            lbRevenue.Text = sum.ToString() + "đ";
            lbEmployee.Text = EmployeeController.Instance.getList().Count.ToString() + " Employee";
            lbProduct.Text = ProductController.Instance.getList().Count.ToString() +" Product";

        }
    }
}
