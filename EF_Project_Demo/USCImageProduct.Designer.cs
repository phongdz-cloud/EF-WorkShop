
namespace EF_Project_Demo
{
    partial class USCImageProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USCImageProduct));
            this.pbStatus = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.pbProduct = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pbStatus
            // 
            this.pbStatus.Image = ((System.Drawing.Image)(resources.GetObject("pbStatus.Image")));
            this.pbStatus.Location = new System.Drawing.Point(170, 120);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(48, 50);
            this.pbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStatus.TabIndex = 1;
            this.pbStatus.TabStop = false;
            this.pbStatus.Visible = false;
            this.pbStatus.Click += new System.EventHandler(this.pbStatus_Click);
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(218, 25);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Ten San Pham";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(133)))), ((int)(((byte)(145)))));
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(0, 176);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(218, 25);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "Gia tien";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPrice.Click += new System.EventHandler(this.lbPrice_Click);
            // 
            // pbProduct
            // 
            this.pbProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbProduct.Location = new System.Drawing.Point(0, 0);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(218, 201);
            this.pbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProduct.TabIndex = 0;
            this.pbProduct.TabStop = false;
            this.pbProduct.Click += new System.EventHandler(this.pbProduct_Click);
            // 
            // USCImageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pbStatus);
            this.Controls.Add(this.pbProduct);
            this.Name = "USCImageProduct";
            this.Size = new System.Drawing.Size(218, 201);
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbStatus;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.PictureBox pbProduct;
    }
}
