﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOKO_SEPATU
{
    public partial class spt_a : Form
    {
        public spt_a()
        {
            InitializeComponent();
        }

        private void lanjut_Click(object sender, EventArgs e)
        {
            pemesanan pesan = new pemesanan();
            pesan.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void spt_a_Load(object sender, EventArgs e)
        {

        }
    }
}
