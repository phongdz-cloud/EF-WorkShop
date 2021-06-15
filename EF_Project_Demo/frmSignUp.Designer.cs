
namespace EF_Project_Demo
{
    partial class frmSignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignUp));
            this.lblReType = new System.Windows.Forms.Label();
            this.txtReType = new System.Windows.Forms.TextBox();
            this.pbSignUp = new System.Windows.Forms.PictureBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSignUp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReType
            // 
            this.lblReType.AutoSize = true;
            this.lblReType.BackColor = System.Drawing.Color.Transparent;
            this.lblReType.Font = new System.Drawing.Font("Sitka Text", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblReType.Location = new System.Drawing.Point(50, 213);
            this.lblReType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReType.Name = "lblReType";
            this.lblReType.Size = new System.Drawing.Size(77, 24);
            this.lblReType.TabIndex = 46;
            this.lblReType.Text = "Re-Type";
            // 
            // txtReType
            // 
            this.txtReType.Location = new System.Drawing.Point(154, 214);
            this.txtReType.Margin = new System.Windows.Forms.Padding(4);
            this.txtReType.Name = "txtReType";
            this.txtReType.PasswordChar = '*';
            this.txtReType.Size = new System.Drawing.Size(173, 22);
            this.txtReType.TabIndex = 45;
            // 
            // pbSignUp
            // 
            this.pbSignUp.BackColor = System.Drawing.Color.Transparent;
            this.pbSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbSignUp.BackgroundImage")));
            this.pbSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSignUp.Location = new System.Drawing.Point(103, 263);
            this.pbSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.pbSignUp.Name = "pbSignUp";
            this.pbSignUp.Size = new System.Drawing.Size(201, 62);
            this.pbSignUp.TabIndex = 44;
            this.pbSignUp.TabStop = false;
            this.pbSignUp.Click += new System.EventHandler(this.pbSignUp_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbPassword.Font = new System.Drawing.Font("Sitka Text", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbPassword.Location = new System.Drawing.Point(43, 172);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(89, 24);
            this.lbPassword.TabIndex = 43;
            this.lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(154, 173);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(173, 22);
            this.txtPassword.TabIndex = 37;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbUsername.Font = new System.Drawing.Font("Sitka Text", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbUsername.Location = new System.Drawing.Point(43, 134);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(94, 24);
            this.lbUsername.TabIndex = 42;
            this.lbUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(154, 135);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(173, 22);
            this.txtUsername.TabIndex = 36;
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(128)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(407, 494);
            this.Controls.Add(this.lblReType);
            this.Controls.Add(this.txtReType);
            this.Controls.Add(this.pbSignUp);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.txtUsername);
            this.Name = "frmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSignUp";
            ((System.ComponentModel.ISupportInitialize)(this.pbSignUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReType;
        private System.Windows.Forms.TextBox txtReType;
        private System.Windows.Forms.PictureBox pbSignUp;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox txtUsername;
    }
}