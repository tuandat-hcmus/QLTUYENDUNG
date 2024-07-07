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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.signInMemberBtn = new System.Windows.Forms.Button();
            this.signInCompBtn = new System.Windows.Forms.Button();
            this.tiepTanTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.getMemberListBtn = new System.Windows.Forms.Button();
            this.getCompListBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.compsDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tiepTanTab.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 553);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.userNameBox);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.getCompListBtn);
            this.panel2.Controls.Add(this.getMemberListBtn);
            this.panel2.Controls.Add(this.signInCompBtn);
            this.panel2.Controls.Add(this.signInMemberBtn);
            this.panel2.Location = new System.Drawing.Point(11, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 490);
            this.panel2.TabIndex = 0;
            // 
            // signInMemberBtn
            // 
            this.signInMemberBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInMemberBtn.Location = new System.Drawing.Point(0, 2);
            this.signInMemberBtn.Name = "signInMemberBtn";
            this.signInMemberBtn.Size = new System.Drawing.Size(218, 39);
            this.signInMemberBtn.TabIndex = 0;
            this.signInMemberBtn.Text = "Đăng kí thành viên";
            this.signInMemberBtn.UseVisualStyleBackColor = true;
            this.signInMemberBtn.Click += new System.EventHandler(this.signInMemberBtn_Click);
            // 
            // signInCompBtn
            // 
            this.signInCompBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInCompBtn.Location = new System.Drawing.Point(0, 58);
            this.signInCompBtn.Name = "signInCompBtn";
            this.signInCompBtn.Size = new System.Drawing.Size(218, 39);
            this.signInCompBtn.TabIndex = 0;
            this.signInCompBtn.Text = "Đăng kí doanh nghiệp";
            this.signInCompBtn.UseVisualStyleBackColor = true;
            this.signInCompBtn.Click += new System.EventHandler(this.signInCompBtn_Click);
            // 
            // tiepTanTab
            // 
            this.tiepTanTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tiepTanTab.Controls.Add(this.tabPage1);
            this.tiepTanTab.Controls.Add(this.tabPage2);
            this.tiepTanTab.Controls.Add(this.tabPage3);
            this.tiepTanTab.Controls.Add(this.tabPage4);
            this.tiepTanTab.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiepTanTab.Location = new System.Drawing.Point(235, 0);
            this.tiepTanTab.Name = "tiepTanTab";
            this.tiepTanTab.SelectedIndex = 0;
            this.tiepTanTab.Size = new System.Drawing.Size(827, 554);
            this.tiepTanTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(819, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Đăng kí thành viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(819, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đăng kí doanh nghiệp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(819, 524);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Danh sách thành viên";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.compsDataGrid);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(819, 524);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Danh sách doanh nghiệp";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // getMemberListBtn
            // 
            this.getMemberListBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getMemberListBtn.Location = new System.Drawing.Point(0, 115);
            this.getMemberListBtn.Name = "getMemberListBtn";
            this.getMemberListBtn.Size = new System.Drawing.Size(218, 39);
            this.getMemberListBtn.TabIndex = 0;
            this.getMemberListBtn.Text = "Danh sách thành viên";
            this.getMemberListBtn.UseVisualStyleBackColor = true;
            this.getMemberListBtn.Click += new System.EventHandler(this.getMemberListBtn_Click);
            // 
            // getCompListBtn
            // 
            this.getCompListBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getCompListBtn.Location = new System.Drawing.Point(0, 170);
            this.getCompListBtn.Name = "getCompListBtn";
            this.getCompListBtn.Size = new System.Drawing.Size(218, 39);
            this.getCompListBtn.TabIndex = 0;
            this.getCompListBtn.Text = "Danh sách doanh nghiệp";
            this.getCompListBtn.UseVisualStyleBackColor = true;
            this.getCompListBtn.Click += new System.EventHandler(this.getCompListBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLTUYENDUNG.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(60, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // userNameBox
            // 
            this.userNameBox.Enabled = false;
            this.userNameBox.Location = new System.Drawing.Point(38, 368);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(143, 22);
            this.userNameBox.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(816, 521);
            this.dataGridView1.TabIndex = 0;
            // 
            // compsDataGrid
            // 
            this.compsDataGrid.AllowUserToAddRows = false;
            this.compsDataGrid.AllowUserToDeleteRows = false;
            this.compsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.compsDataGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.compsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.compsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.compsDataGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.compsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compsDataGrid.GridColor = System.Drawing.Color.Black;
            this.compsDataGrid.Location = new System.Drawing.Point(3, 3);
            this.compsDataGrid.Name = "compsDataGrid";
            this.compsDataGrid.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.compsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.compsDataGrid.RowHeadersVisible = false;
            this.compsDataGrid.RowHeadersWidth = 51;
            this.compsDataGrid.RowTemplate.Height = 24;
            this.compsDataGrid.Size = new System.Drawing.Size(813, 518);
            this.compsDataGrid.TabIndex = 0;
            // 
            // TiepTanHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 553);
            this.Controls.Add(this.tiepTanTab);
            this.Controls.Add(this.panel1);
            this.Name = "TiepTanHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.TiepTanHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tiepTanTab.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button signInCompBtn;
        private System.Windows.Forms.Button signInMemberBtn;
        private System.Windows.Forms.TabControl tiepTanTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button getCompListBtn;
        private System.Windows.Forms.Button getMemberListBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView compsDataGrid;
    }
}