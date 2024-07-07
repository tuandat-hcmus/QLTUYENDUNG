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
    public partial class ThemHoSoTuyenDung : Form
    {
        private string IDTTDT = "";
        private string IDCTTTDT = "";
        public ThemHoSoTuyenDung()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViTriTuyenDung viTriTD = new ViTriTuyenDung();
            if (viTriTD.ShowDialog() == DialogResult.OK)
            {
                IDTTDT = (string)viTriTD.returnedIDTTDT;
                IDCTTTDT = viTriTD.returnedIDCTTTDT;
                string tenDN = viTriTD.returnedTenDN;
                string viTri = viTriTD.returnedViTri;
                label1.Text = tenDN + " - " + viTri;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cccd = textBox2.Text;
            string hocVan = textBox3.Text;
            string kinhNghiem = textBox4.Text;
            string kiNang = textBox5.Text;

            int res = HoSoUngVien.addHoSoUngVien(hocVan, kinhNghiem, kiNang, cccd, this.IDCTTTDT, this.IDTTDT);
            label6.Text = res.ToString();
        }
    }
}
