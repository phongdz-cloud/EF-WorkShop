using EF_Project_Demo.Controller;
using EF_Project_Demo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Project_Demo
{
    public partial class USCSell : UserControl
    {
        public USCSell()
        {
            InitializeComponent();
        }
        private USCImageProduct getUSCImageProduct(Product p)
        {
            USCImageProduct imageProduct = new USCImageProduct();
            imageProduct.Tag = p.ProductID;
            imageProduct.Controls["lbName"].Text = p.ProductName;
            imageProduct.Controls["lbPrice"].Text = p.Price.ToString();
            PictureBox pbProduct = (PictureBox)imageProduct.Controls["pbProduct"];
            pbProduct.Tag = p.ProductID;
            if(p.Image !=null)
            pbProduct.Image = Image.FromStream(new MemoryStream(p.Image));
            pbProduct.Controls.Add(imageProduct.Controls["pbStatus"]);
            pbProduct.Click += pbstatus_Click;
            pbProduct.Paint += pictureBox1_Paint_1;
            return imageProduct;
        }
        private USCOrder GetUSCOrder (Product p)
        {
            USCOrder order = new USCOrder();
            order.Tag = p.ProductID;
            order.Controls["lbName"].Text = p.ProductName;
            order.Controls["lbPrice"].Text = p.Price.ToString();
            NumericUpDown numeric = (NumericUpDown)order.Controls["nmrAmount"];
            numeric.Maximum = p.Amount;
            order.Controls["pbRemove"].Tag = p.ProductID;
            order.Controls["pbRemove"].Click += order_Click;
            return order;
        }
        private void order_Click(object sender , EventArgs e)
        {
            PictureBox pbStatus = (PictureBox)sender;
            foreach (USCOrder item in flwOrder.Controls)
            {
                if (Convert.ToInt32(pbStatus.Tag.ToString()) == Convert.ToInt32(item.Controls["pbRemove"].Tag.ToString()))
                {
                    flwOrder.Controls.Remove(item);
                    break;
                }
            }
            foreach (USCImageProduct item in flwProduct.Controls)
            {
                if(Convert.ToInt32(pbStatus.Tag.ToString()) == Convert.ToInt32(item.Tag.ToString()))
                {
                    PictureBox pb = (PictureBox)item.Controls["pbProduct"];
                    pb.Controls["pbStatus"].Visible = false;
                    break;
                }
            }
        }
        private USCImageCategory GetUSCImageCategory(Category c)
        {
            USCImageCategory imageCategory = new USCImageCategory();
            Panel pn = (Panel)imageCategory.Controls["pnCategory"];
            pn.Tag = c.CategoryId;
            pn.Paint += panel_Paint_1;
            pn.Controls["lbCategoryName"].Text = c.CategoryName;
            pn.Click += pbstatus_category_Click;
            return imageCategory;
        }
        private void pbstatus_category_Click(object sender, EventArgs e)
        {
            Panel pb = (Panel)sender;
            foreach (USCImageCategory item in flwCategory.Controls)
            {
                Panel temp = (Panel)item.Controls["pnCategory"];
                if (temp.Tag == pb.Tag)
                {
                    flwProduct.Controls.Clear();
                    pb.Controls["pbStatus"].Visible = true;
                    ProductController.Instance.getList().Where(
                            p => p.CategoryID == Convert.ToInt32(pb.Tag))
                        .ToList().ForEach(p => flwProduct.Controls.Add(getUSCImageProduct(p)));
                }
                else temp.Controls["pbStatus"].Visible = false;
            }
        }
        private void panel_Paint_1(object sender, PaintEventArgs e)
        {
            Panel pb = (Panel)sender;
            ControlPaint.DrawBorder(e.Graphics, pb.ClientRectangle, Color.DodgerBlue, ButtonBorderStyle.Solid);
        }
        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            ControlPaint.DrawBorder(e.Graphics, pb.ClientRectangle, Color.DodgerBlue, ButtonBorderStyle.Solid);
        }
        private void pbstatus_Click(object sender , EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            if (pb.Controls["pbStatus"].Visible == false) 
                pb.Controls["pbStatus"].Visible = true;
            else pb.Controls["pbStatus"].Visible = false;
            foreach (USCOrder item in flwOrder.Controls)
            {
                if(Convert.ToInt32(item.Tag.ToString()) == Convert.ToInt32(pb.Tag.ToString()))
                {
                    return;
                }
            }
            flwOrder.Controls.Add(GetUSCOrder(ProductController.Instance.getList().
                Where(p => p.ProductID == Convert.ToInt32(pb.Tag.ToString()))
                .FirstOrDefault()));
        }
        private void USCSell_Load(object sender, EventArgs e)
        {
            CategoryController.Instance.getList().ForEach(p =>
            flwCategory.Controls.Add(GetUSCImageCategory(p)));
            cbbEmloyee.DataSource = EmployeeController.Instance.getList();
            cbbEmloyee.DisplayMember = "EmployeeName";
            cbbEmloyee.ValueMember = "EmployeeId";
        }

        private void cbbEmloyee_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void cbbEmloyee_SelectedIndexChanged(object sender, EventArgs e)
        {
            int number;
            bool succes = Int32.TryParse(cbbEmloyee.SelectedValue.ToString(),out number);
            if (succes == true)
            {
                var result = EmployeeController.Instance.GetEmloyee(number);
                txtAdress.Text = result.Address;
                txtPhone.Text = result.Phone;
                pbAvatarEmloyee.Image = Image.FromStream(new MemoryStream(result.Image));
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            flwOrder.Controls.Clear();
            foreach (USCImageProduct item in flwProduct.Controls)
            {
                PictureBox pb = (PictureBox)item.Controls["pbProduct"];
                pb.Controls["pbStatus"].Visible = false;
            }
        }
        private Sale getSale()
        {
            Sale sale = new Sale();
            sale.EmployeeId = Convert.ToInt32(cbbEmloyee.SelectedValue.ToString());
            sale.InvoiceDate = DateTime.Now;
            return sale;
        }
        private SalesDetail getSaleDetail(int productID, int saleID,int amount)
        {
            SalesDetail salesDetail = new SalesDetail();
            salesDetail.ProductID = productID;
            salesDetail.SaleId = saleID;
            salesDetail.Amount = amount;
            return salesDetail;
        }
        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (flwOrder.Controls.Count != 0)
            {
                try
                {
                    DbContextController.Instance.Dbcontext.Database.BeginTransaction();
                    Sale sale = getSale();
                    SaleController.Instance.insertSale(sale);
                    var index = SaleController.Instance.getList().Last().SaleId;
                    double sum = 0;
                    NumericUpDown numeric;
                    Product updateStock;
                    foreach (USCOrder item in flwOrder.Controls)
                    {
                        numeric = (NumericUpDown)item.Controls["nmrAmount"];
                        if (numeric.Value != 0)
                        {
                            sum += Convert.ToDouble(item.Controls["lbPrice"].Text) * Convert.ToInt32(numeric.Value);
                            SaleDetailController.Instance.insertSalesDetail(getSaleDetail(Convert.ToInt32(item.Tag.ToString()),
                               index, Convert.ToInt32(numeric.Value)));
                            updateStock = ProductController.Instance.GetProduct(Convert.ToInt32(item.Tag.ToString()));
                            updateStock.Amount -= Convert.ToInt32(numeric.Value);
                            DbContextController.Instance.Dbcontext.SaveChanges();
                        }
                    }
                    var result = SaleController.Instance.GetSale(index);
                    result.Total = sum;
                    DbContextController.Instance.Dbcontext.SaveChanges();
                    
                    MessageBox.Show("Giao dich thanh cong");
                    DbContextController.Instance.Dbcontext.Database.CommitTransaction();
                    btnClear_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Roll back!");
                    DbContextController.Instance.Dbcontext.Database.RollbackTransaction();
                }
            }
        }
    }
}
