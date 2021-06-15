
namespace EF_Project_Demo
{
    partial class USCSell
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flwProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.flwCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.flwOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbAvatarEmloyee = new System.Windows.Forms.PictureBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbEmloyee = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarEmloyee)).BeginInit();
            this.SuspendLayout();
            // 
            // flwProduct
            // 
            this.flwProduct.AutoScroll = true;
            this.flwProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flwProduct.Location = new System.Drawing.Point(417, 205);
            this.flwProduct.Name = "flwProduct";
            this.flwProduct.Size = new System.Drawing.Size(619, 503);
            this.flwProduct.TabIndex = 0;
            // 
            // flwCategory
            // 
            this.flwCategory.AutoScroll = true;
            this.flwCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flwCategory.Location = new System.Drawing.Point(417, 3);
            this.flwCategory.Name = "flwCategory";
            this.flwCategory.Size = new System.Drawing.Size(619, 196);
            this.flwCategory.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnBuy);
            this.panel2.Location = new System.Drawing.Point(4, 596);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 112);
            this.panel2.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Lime;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(206, 54);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 55);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.Lime;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.Location = new System.Drawing.Point(302, 54);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(102, 55);
            this.btnBuy.TabIndex = 0;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // flwOrder
            // 
            this.flwOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flwOrder.Location = new System.Drawing.Point(4, 205);
            this.flwOrder.Name = "flwOrder";
            this.flwOrder.Size = new System.Drawing.Size(407, 385);
            this.flwOrder.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbAvatarEmloyee);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtAdress);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbbEmloyee);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 196);
            this.panel1.TabIndex = 5;
            // 
            // pbAvatarEmloyee
            // 
            this.pbAvatarEmloyee.Location = new System.Drawing.Point(247, 3);
            this.pbAvatarEmloyee.Name = "pbAvatarEmloyee";
            this.pbAvatarEmloyee.Size = new System.Drawing.Size(157, 190);
            this.pbAvatarEmloyee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatarEmloyee.TabIndex = 6;
            this.pbAvatarEmloyee.TabStop = false;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(83, 125);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(158, 27);
            this.txtPhone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone";
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdress.Location = new System.Drawing.Point(83, 81);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.ReadOnly = true;
            this.txtAdress.Size = new System.Drawing.Size(158, 27);
            this.txtAdress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adress";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // cbbEmloyee
            // 
            this.cbbEmloyee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEmloyee.FormattingEnabled = true;
            this.cbbEmloyee.Location = new System.Drawing.Point(83, 42);
            this.cbbEmloyee.Name = "cbbEmloyee";
            this.cbbEmloyee.Size = new System.Drawing.Size(158, 28);
            this.cbbEmloyee.TabIndex = 0;
            this.cbbEmloyee.SelectedIndexChanged += new System.EventHandler(this.cbbEmloyee_SelectedIndexChanged);
            this.cbbEmloyee.SelectedValueChanged += new System.EventHandler(this.cbbEmloyee_SelectedValueChanged);
            // 
            // USCSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flwOrder);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flwCategory);
            this.Controls.Add(this.flwProduct);
            this.Name = "USCSell";
            this.Size = new System.Drawing.Size(1039, 711);
            this.Load += new System.EventHandler(this.USCSell_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarEmloyee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwProduct;
        private System.Windows.Forms.FlowLayoutPanel flwCategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flwOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbEmloyee;
        private System.Windows.Forms.PictureBox pbAvatarEmloyee;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
    }
}
