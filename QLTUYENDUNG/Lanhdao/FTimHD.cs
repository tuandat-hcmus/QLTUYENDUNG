﻿using QLTUYENDUNG.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTUYENDUNG.Lanhdao
{
    public partial class FTimHD : Form
    {
        public string returnedIdTTDT { get; set; }
        public FTimHD()
        {
            InitializeComponent();
            loadData();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (dataGridViewDSHD.Rows.Count > 0)
            {
                returnedIdTTDT = dataGridViewDSHD.SelectedRows[0].Cells["IDTTDT"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void loadData()
        {
            // Lọc các hợp đồng có trạng thái đang chờ xét duyệt
            dataGridViewDSHD.DataSource = TTDT.getTTDTHetHanDataTable(-1, 1);
            if (dataGridViewDSHD.Rows.Count <= 0) {
                btnChon.Enabled = false;
            }
        }
    }
}
