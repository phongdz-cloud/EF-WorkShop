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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void pbSignUp_Click(object sender, EventArgs e)
        {
            var result = DbContextController.Instance.Dbcontext.Accounts.ToList()
                        .Where(a => a.UserName == txtUsername.Text.Trim()).FirstOrDefault();
            if (result == null)
            {
                if (txtPassword.Text.Trim() == txtReType.Text.Trim())
                {
                    Account account = new Account()
                    {
                        UserName = txtUsername.Text.Trim(),
                        Password = txtPassword.Text.Trim()
                    };
                    DbContextController.Instance.Dbcontext.Accounts.Add(account);
                    DbContextController.Instance.Dbcontext.SaveChanges();
                    MessageBox.Show("Đăng ký tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu nhập lại không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
                MessageBox.Show("Đã tồn tại trong CSDL", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
