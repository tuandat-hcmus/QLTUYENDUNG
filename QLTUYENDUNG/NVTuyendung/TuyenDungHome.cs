﻿using System;
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
    public partial class TuyenDungHome : Form
    {
        public TuyenDungHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemHoSoTuyenDung themHoSoTuyenDung = new ThemHoSoTuyenDung();
            themHoSoTuyenDung.ShowDialog();
        }
    }
}
