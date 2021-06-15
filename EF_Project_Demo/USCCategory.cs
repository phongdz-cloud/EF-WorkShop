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
    public partial class USCCategory : UserControl
    {
        private int flag;
        public USCCategory()
        {
            InitializeComponent();
        }
        private Form window;
        private static USCCategory instance;

        public static USCCategory Instance { get { if (instance == null) instance = new USCCategory(); return instance; } private set => instance = value; }

        private Category getCategory()
        {
            Category category = new Category()
            {
                CategoryName = txtName.Text,
                Description  = txtDecription.Text
            };
            return category;
        }
        private void dis_en(bool e)
        {
            txtName.Enabled = e;
            txtDecription.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
        }
        private void uscCategory_Load(object sender, EventArgs e)
        {
                try
                {
                    dgvCategory.DataSource = CategoryController.Instance.getList();
                    dgvCategory.Columns["Products"].Visible = false;
                    dis_en(false);
                }
                catch ( Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        public DialogResult ShowDialog()
        {
            window = new Form
            {
                TopLevel = true,
               // FormBorderStyle = FormBorderStyle.None, //Disables user resizing
                MaximizeBox = false,
                MinimizeBox = false,
                ClientSize = instance.Size //size the form to fit the content
            };
            window.Controls.Add(Instance);
            window.StartPosition = FormStartPosition.CenterParent;
            Instance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            return window.ShowDialog();
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
            try
            {
                if (flag == 1)
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc muốn thêm danh mục này không?", "Xác nhận hủy",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        CategoryController.Instance.insertCategory(getCategory());
                            uscCategory_Load(sender,e);
                            dis_en(false);
                    }
                }
                if(flag == 0)
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc sửa thông tin danh mục này không?", "Xác nhận hủy",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                            int index = dgvCategory.CurrentCell.RowIndex;
                            var result = CategoryController.Instance.GetCategory(
                                Convert.ToInt32(dgvCategory.Rows[index].Cells[0].Value.ToString()));
                            if (result == null) throw new Exception();
                            result.CategoryName = txtName.Text;
                            result.Description = txtDecription.Text;
                            DbContextController.Instance.Dbcontext.SaveChanges();
                            uscCategory_Load(sender, e);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Bạn có chắc xóa danh mục này không?", "Xác nhận hủy",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                try
                {
                        CategoryController.Instance.removeCategory(
                            Convert.ToInt32(dgvCategory.Rows[dgvCategory.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                        uscCategory_Load(sender, e);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtName.Text = dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDecription.Text = dgvCategory.Rows[e.RowIndex].Cells[2].Value.ToString();
            }catch(Exception ex) { }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn hủy không này không?", "Xác nhận hủy",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) dis_en(false);
        }
    }
}
