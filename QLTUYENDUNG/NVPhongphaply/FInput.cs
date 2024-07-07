using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTUYENDUNG.NVPhongphaply
{
    public partial class FInput : Form
    {
        public int output { get; set; }
        public FInput()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            output = Convert.ToInt32(textBoxInput.Text);
            if (output > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ngày không hợp lệ !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
