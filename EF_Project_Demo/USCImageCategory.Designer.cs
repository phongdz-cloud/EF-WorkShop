
namespace EF_Project_Demo
{
    partial class USCImageCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USCImageCategory));
            this.pnCategory = new System.Windows.Forms.Panel();
            this.pbStatus = new System.Windows.Forms.PictureBox();
            this.lbCategoryName = new System.Windows.Forms.Label();
            this.pnCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCategory
            // 
            this.pnCategory.Controls.Add(this.pbStatus);
            this.pnCategory.Controls.Add(this.lbCategoryName);
            this.pnCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCategory.Location = new System.Drawing.Point(0, 0);
            this.pnCategory.Name = "pnCategory";
            this.pnCategory.Size = new System.Drawing.Size(199, 178);
            this.pnCategory.TabIndex = 0;
            // 
            // pbStatus
            // 
            this.pbStatus.Image = ((System.Drawing.Image)(resources.GetObject("pbStatus.Image")));
            this.pbStatus.Location = new System.Drawing.Point(132, 123);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(67, 51);
            this.pbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStatus.TabIndex = 3;
            this.pbStatus.TabStop = false;
            this.pbStatus.Visible = false;
            // 
            // lbCategoryName
            // 
            this.lbCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoryName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbCategoryName.Location = new System.Drawing.Point(3, 61);
            this.lbCategoryName.Name = "lbCategoryName";
            this.lbCategoryName.Size = new System.Drawing.Size(193, 37);
            this.lbCategoryName.TabIndex = 2;
            this.lbCategoryName.Text = "Đồ gia dụng";
            this.lbCategoryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // USCImageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnCategory);
            this.Name = "USCImageCategory";
            this.Size = new System.Drawing.Size(199, 178);
            this.pnCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCategory;
        private System.Windows.Forms.PictureBox pbStatus;
        private System.Windows.Forms.Label lbCategoryName;
    }
}
