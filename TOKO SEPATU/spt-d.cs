using System;
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
    public partial class spt_d : Form
    {
        public spt_d()
        {
            InitializeComponent();
        }

        private void lanjut_Click(object sender, EventArgs e)
        {
            pemesanan pesan = new pemesanan();
            pesan.Show();
            this.Hide();
        }

        private void spt_d_Load(object sender, EventArgs e)
        {

        }
    }
}
