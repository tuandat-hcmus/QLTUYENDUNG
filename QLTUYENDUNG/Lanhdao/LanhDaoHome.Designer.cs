namespace QLTUYENDUNG.Lanhdao
{
    partial class LanhDaoHome
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
            this.btnGiaHanHD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGiaHanHD
            // 
            this.btnGiaHanHD.Location = new System.Drawing.Point(126, 105);
            this.btnGiaHanHD.Name = "btnGiaHanHD";
            this.btnGiaHanHD.Size = new System.Drawing.Size(75, 23);
            this.btnGiaHanHD.TabIndex = 0;
            this.btnGiaHanHD.Text = "Gia hạn hợp đồng";
            this.btnGiaHanHD.UseVisualStyleBackColor = true;
            this.btnGiaHanHD.Click += new System.EventHandler(this.btnGiaHanHD_Click);
            // 
            // LanhDaoHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnGiaHanHD);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LanhDaoHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGiaHanHD;
    }
}