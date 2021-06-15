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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pbLogin_Click(object sender, EventArgs e)
        {
            var result = DbContextController.Instance.Dbcontext.Accounts.ToList()
                           .Where(a => a.UserName == txtUsername.Text.Trim() && a.Password == txtPassword.Text.Trim()).FirstOrDefault();
            if (result != null)
            {
                frmMain main = new frmMain();
                this.Hide();
                main.ShowDialog();
                this.Show();
            }else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                    
        }

        private void llblSingup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmSignUp signup = new frmSignUp();
            signup.ShowDialog();
            this.Show();
        }
    }
}
