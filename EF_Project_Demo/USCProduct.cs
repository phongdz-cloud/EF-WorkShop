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
    public partial class USCProduct : UserControl
    {
        private int flag;
        private Byte[] ImageByteArray;
        public USCProduct()
        {
            InitializeComponent();
        }
        private void dis_en(bool e)
        {
            txtName.Enabled = e;
            txtPrice.Enabled = e;
            txtSL.Enabled = e;
            cbbCategoryID.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
        }
        private Product getProduct()
        {
            Product product = new Product();
                product.ProductName = txtName.Text;
            product.Price = Convert.ToDecimal(txtPrice.Text);
            product.Amount = Convert.ToInt32(txtSL.Text);
            product.CategoryID = Convert.ToInt32(cbbCategoryID.SelectedValue.ToString());
            product.Image = ImageByteArray;
            return product;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_en(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_en(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn thêm sản phẩm này không?", "Xác nhận hủy",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {

                            ProductController.Instance.insertProduct(getProduct());
                            uscProduct_Load(sender, e);
                            dis_en(false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (flag == 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc cập nhật thông tin sản phẩm này không?", "Xác nhận hủy",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                            int index = dgvProduct.CurrentCell.RowIndex;
                            var linq = ProductController.Instance.GetProduct(
                                Convert.ToInt32(dgvProduct.Rows[index].Cells[0].Value.ToString()));
                            if (linq != null)
                            {
                                
                                linq.ProductName = txtName.Text;
                                linq.Price = Convert.ToDecimal(txtPrice.Text);
                                linq.Amount = Convert.ToInt32(txtSL.Text);
                                linq.CategoryID = Convert.ToInt32(cbbCategoryID.SelectedValue.ToString());
                                if(ImageByteArray !=null)
                                linq.Image = ImageByteArray;
                            DbContextController.Instance.Dbcontext.SaveChanges();
                                uscProduct_Load(sender, e);
                                dis_en(false);
                            }
                            else throw new Exception();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void uscProduct_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn sản phẩm này không?", "Xác nhận hủy",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                    try
                    {
                        ProductController.Instance.removeProduct(
                            Convert.ToInt32(dgvProduct.Rows[dgvProduct.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                    uscProduct_Load(sender, e);
                    }catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn hủy không này không?", "Xác nhận hủy",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) dis_en(false);
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    var result = ProductController.Instance.GetProduct
                                (Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    txtName.Text = result.ProductName;
                    txtPrice.Text = result.Price.ToString();
                    txtSL.Text = result.Amount.ToString();
                    cbbCategoryID.SelectedValue = result.CategoryID;
                    pbAvatar.Image = Image.FromStream(new MemoryStream(result.Image));
            }catch (Exception ex) { };

        }
        private void load()
        {
                try
                {

                    dgvProduct.AutoGenerateColumns = false;
                    CategoryID.DataSource = CategoryController.Instance.getList();
                    CategoryID.DisplayMember = "CategoryName";
                    CategoryID.ValueMember = "CategoryId";
                    dgvProduct.DataSource = ProductController.Instance.getList();
                    cbbCategoryID.DataSource = CategoryController.Instance.getList();
                    cbbCategoryID.DisplayMember = "CategoryName";
                    cbbCategoryID.ValueMember = "CategoryId";
                    dis_en(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void btnCategoryInfor_Click(object sender, EventArgs e)
        {
            USCCategory.Instance.ShowDialog();
            uscProduct_Load(sender, e);
        }

        private void btnBrown_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Image temp = new Bitmap(open.FileName);
                MemoryStream strm = new MemoryStream();
                temp.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
                ImageByteArray = strm.ToArray();
                pbAvatar.Image = Image.FromStream(new MemoryStream(ImageByteArray));
            }
        }
    }
}
