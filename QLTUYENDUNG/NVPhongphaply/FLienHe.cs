using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTUYENDUNG.NVPhongphaply
{
    public partial class FLienHe : Form
    {
        private readonly string email;
        private readonly string myMail = "duytest404@gmail.com";
        private readonly string password = "testaccount-1";
        public FLienHe(string email)
        {
            InitializeComponent();
            this.email = email;
            textBoxTu.Text = myMail;
            textBoxDen.Text = "duydangtr@gmail.com";
        }

        private void btnLienHe_Click(object sender, EventArgs e)
        {

        }
    }
}
