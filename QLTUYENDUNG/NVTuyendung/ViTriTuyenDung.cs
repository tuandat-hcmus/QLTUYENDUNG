using QLTUYENDUNG.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTUYENDUNG.NVTuyendung
{
    public partial class ViTriTuyenDung : Form
    {
        public string returnedIDTTDT { get; set; }
        public string returnedIDCTTTDT {  get; set; }
        public string returnedTenDN {  get; set; }
        public string returnedViTri { get; set; }
        public ViTriTuyenDung()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string tenDN = textBox1.Text;
            string viTri = textBox2.Text;
            dataGridView1.DataSource = VTTD.getViTriTuyenDungDataTable(tenDN, viTri);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                returnedIDTTDT = dataGridView1.SelectedRows[0].Cells["IDTTDT"].Value.ToString();
                returnedIDCTTTDT = dataGridView1.SelectedRows[0].Cells["IDCTTTDT"].Value.ToString();
                returnedTenDN = dataGridView1.SelectedRows[0].Cells["Ten"].Value.ToString();
                returnedViTri = dataGridView1.SelectedRows[0].Cells["ViTri"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
