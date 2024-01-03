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
    public partial class menu_awal : Form
    {
        public menu_awal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            spt_a spt1 = new spt_a();
            spt1.Show();
            this.Hide();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            spt_b spt1 = new spt_b();
            spt1.Show();
            this.Hide();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            spt_c spt1 = new spt_c();
            spt1.Show();
            this.Hide();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            spt_d spt1 = new spt_d();
            spt1.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void menu_awal_Load(object sender, EventArgs e)
        {

        }
    }
}
