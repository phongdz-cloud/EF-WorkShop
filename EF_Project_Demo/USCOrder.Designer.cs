
namespace EF_Project_Demo
{
    partial class USCOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USCOrder));
            this.pbRemove = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.nmrAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRemove
            // 
            this.pbRemove.Image = ((System.Drawing.Image)(resources.GetObject("pbRemove.Image")));
            this.pbRemove.Location = new System.Drawing.Point(12, 17);
            this.pbRemove.Name = "pbRemove";
            this.pbRemove.Size = new System.Drawing.Size(60, 49);
            this.pbRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRemove.TabIndex = 0;
            this.pbRemove.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(93, 17);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(173, 26);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "lbName";
            // 
            // lbPrice
            // 
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(93, 43);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(173, 23);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "Price";
            // 
            // nmrAmount
            // 
            this.nmrAmount.Location = new System.Drawing.Point(272, 30);
            this.nmrAmount.Name = "nmrAmount";
            this.nmrAmount.Size = new System.Drawing.Size(124, 22);
            this.nmrAmount.TabIndex = 3;
            this.nmrAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // USCOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nmrAmount);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pbRemove);
            this.Name = "USCOrder";
            this.Size = new System.Drawing.Size(408, 78);
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRemove;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.NumericUpDown nmrAmount;
    }
}
