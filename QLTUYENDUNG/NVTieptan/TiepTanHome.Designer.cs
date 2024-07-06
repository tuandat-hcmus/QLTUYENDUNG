namespace QLTUYENDUNG.NVTieptan
{
    partial class TiepTanHome
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
            this.closeBtn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtSearchIDDN = new System.Windows.Forms.TextBox();
            this.btnSeachDN = new System.Windows.Forms.Button();
            this.btnListDn = new System.Windows.Forms.Button();
            this.dataGridViewDN = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDangkyDN = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRepresentative = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaxNumber = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.NVTT = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDN)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.NVTT.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Image = global::QLTUYENDUNG.Properties.Resources.icons_close;
            this.closeBtn.Location = new System.Drawing.Point(1041, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(50, 50);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox8);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1071, 563);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Danh sách doanh nghiệp";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtSearchIDDN);
            this.groupBox8.Controls.Add(this.btnSeachDN);
            this.groupBox8.Controls.Add(this.btnListDn);
            this.groupBox8.Controls.Add(this.dataGridViewDN);
            this.groupBox8.Location = new System.Drawing.Point(3, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1060, 568);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Danh sach thành viên doanh nghiep";
            this.groupBox8.Enter += new System.EventHandler(this.groupBox8_Enter_1);
            // 
            // txtSearchIDDN
            // 
            this.txtSearchIDDN.Location = new System.Drawing.Point(770, 131);
            this.txtSearchIDDN.Name = "txtSearchIDDN";
            this.txtSearchIDDN.Size = new System.Drawing.Size(185, 22);
            this.txtSearchIDDN.TabIndex = 3;
            // 
            // btnSeachDN
            // 
            this.btnSeachDN.Location = new System.Drawing.Point(961, 128);
            this.btnSeachDN.Name = "btnSeachDN";
            this.btnSeachDN.Size = new System.Drawing.Size(75, 28);
            this.btnSeachDN.TabIndex = 2;
            this.btnSeachDN.Text = "Tim kiem";
            this.btnSeachDN.UseVisualStyleBackColor = true;
            this.btnSeachDN.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnListDn
            // 
            this.btnListDn.Location = new System.Drawing.Point(770, 42);
            this.btnListDn.Name = "btnListDn";
            this.btnListDn.Size = new System.Drawing.Size(266, 43);
            this.btnListDn.TabIndex = 1;
            this.btnListDn.Text = "Xem danh sach doanh nghiep";
            this.btnListDn.UseVisualStyleBackColor = true;
            this.btnListDn.Click += new System.EventHandler(this.btnListDn_Click);
            // 
            // dataGridViewDN
            // 
            this.dataGridViewDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDN.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewDN.Name = "dataGridViewDN";
            this.dataGridViewDN.RowHeadersWidth = 51;
            this.dataGridViewDN.RowTemplate.Height = 24;
            this.dataGridViewDN.Size = new System.Drawing.Size(731, 530);
            this.dataGridViewDN.TabIndex = 0;
            this.dataGridViewDN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1071, 563);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Đăng ký doanh nghiệp";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDangkyDN);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1060, 568);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng ký doanh nghiệp";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnDangkyDN
            // 
            this.btnDangkyDN.Location = new System.Drawing.Point(212, 481);
            this.btnDangkyDN.Name = "btnDangkyDN";
            this.btnDangkyDN.Size = new System.Drawing.Size(513, 46);
            this.btnDangkyDN.TabIndex = 11;
            this.btnDangkyDN.Text = "Đăng ký";
            this.btnDangkyDN.UseVisualStyleBackColor = true;
            this.btnDangkyDN.Click += new System.EventHandler(this.btnDangkyDN_Click_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txtRepresentative);
            this.groupBox5.Location = new System.Drawing.Point(8, 194);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1046, 84);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Người đại diện";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtRepresentative
            // 
            this.txtRepresentative.Location = new System.Drawing.Point(5, 44);
            this.txtRepresentative.Multiline = true;
            this.txtRepresentative.Name = "txtRepresentative";
            this.txtRepresentative.Size = new System.Drawing.Size(981, 33);
            this.txtRepresentative.TabIndex = 1;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.txtEmail);
            this.groupBox7.Location = new System.Drawing.Point(8, 378);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1046, 85);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email liên hệ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 44);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(981, 37);
            this.txtEmail.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.txtAddress);
            this.groupBox6.Location = new System.Drawing.Point(13, 284);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1046, 88);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(9, 44);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(971, 38);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtTaxNumber);
            this.groupBox4.Location = new System.Drawing.Point(8, 111);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1046, 83);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã số thuế";
            // 
            // txtTaxNumber
            // 
            this.txtTaxNumber.Location = new System.Drawing.Point(6, 44);
            this.txtTaxNumber.Multiline = true;
            this.txtTaxNumber.Name = "txtTaxNumber";
            this.txtTaxNumber.Size = new System.Drawing.Size(981, 33);
            this.txtTaxNumber.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtCompany);
            this.groupBox3.Location = new System.Drawing.Point(8, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1046, 84);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên công ty";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(6, 47);
            this.txtCompany.Multiline = true;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(981, 31);
            this.txtCompany.TabIndex = 1;
            // 
            // NVTT
            // 
            this.NVTT.Controls.Add(this.tabPage1);
            this.NVTT.Controls.Add(this.tabPage3);
            this.NVTT.Location = new System.Drawing.Point(12, 47);
            this.NVTT.Name = "NVTT";
            this.NVTT.SelectedIndex = 0;
            this.NVTT.Size = new System.Drawing.Size(1079, 592);
            this.NVTT.TabIndex = 7;
            // 
            // TiepTanHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 730);
            this.Controls.Add(this.NVTT);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TiepTanHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.tabPage3.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDN)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.NVTT.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRepresentative;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaxNumber;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TabControl NVTT;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView dataGridViewDN;
        private System.Windows.Forms.Button btnDangkyDN;
        private System.Windows.Forms.Button btnSeachDN;
        private System.Windows.Forms.Button btnListDn;
        private System.Windows.Forms.TextBox txtSearchIDDN;
    }
}