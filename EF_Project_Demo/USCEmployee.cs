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
    public partial class USCEmployee : UserControl
    {
        private int flag;
        private byte[] ImageByteArray;
        public USCEmployee()
        {
            InitializeComponent();
        }
        private void dis_en(bool e)
        {
            txtName.Enabled = e;
            txtAddress.Enabled = e;
            txtPhone.Enabled = e;
            txtPhone.Enabled = e;
            txtSalary.Enabled =e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnThem.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
        }
        private Employee getEmloyee()
        {
            Employee employee = new Employee();
            employee.EmployeeName = txtName.Text;
            employee.Address = txtAddress.Text;
            employee.Phone = txtPhone.Text;
            employee.Salary = Convert.ToInt32(txtSalary.Text);
            employee.Image = ImageByteArray;
            return employee;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            dis_en(true);
            flag = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            flag = 0;
            dis_en(true);
        }

        private void uscEmployee_Load(object sender, EventArgs e)
        {

                dgvEmployee.DataSource = EmployeeController.Instance.getList();
                dgvEmployee.Columns["Sales"].Visible = false;
                 dgvEmployee.Columns["Image"].Visible = false;
                dis_en(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không?", "Xác nhận hủy",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                        EmployeeController.Instance.removeEmloyee(
                            Convert.ToInt32(dgvEmployee.Rows[dgvEmployee.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                            uscEmployee_Load(sender, e);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(flag ==1)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn thêm nhân viên này không?", "Xác nhận hủy",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    try
                    {
                            EmployeeController.Instance.insertEmloyee(getEmloyee());
                            uscEmployee_Load(sender, e);
                            dis_en(false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if(flag==0)
            {

                DialogResult dr = MessageBox.Show("Bạn có chắc muốn cập nhật thông tin nhân viên này không?", "Xác nhận hủy",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                            var kq = EmployeeController.Instance.GetEmloyee(
                                Convert.ToInt32
                                (dgvEmployee.Rows[dgvEmployee.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                            if (kq != null)
                            {
                                kq.EmployeeName = txtName.Text;
                                kq.Phone = txtPhone.Text;
                                kq.Salary = Convert.ToInt32(txtSalary.Text);
                                kq.Address = txtAddress.Text;
                                kq.Image = ImageByteArray;
                             DbContextController.Instance.Dbcontext.SaveChanges();
                                dis_en(false);
                                uscEmployee_Load(sender, e);
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn hủy bỏ không?", "Xác nhận hủy",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                dis_en(false);
            }
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var result = EmployeeController.Instance.GetEmloyee
                                    (Convert.ToInt32(dgvEmployee.Rows[e.RowIndex].Cells[0].Value.ToString()));
                txtName.Text = result.EmployeeName;
                txtAddress.Text = result.Address;
                txtPhone.Text = result.Phone;
                txtSalary.Text = result.Salary.ToString();
                if (result.Image != null)
                    pbAvatar.Image = Image.FromStream(new MemoryStream(result.Image));
            }
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
