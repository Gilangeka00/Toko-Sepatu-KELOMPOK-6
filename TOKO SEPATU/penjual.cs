using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOKO_SEPATU
{
    public partial class penjual : Form
    {
        private OleDbCommand cmd;
        private DataSet ds;
        private OleDbDataAdapter da;
        private Koneksi koon = new Koneksi(); // Pastikan Anda memiliki kelas Koneksi yang sesuai

        public penjual()
        {
            InitializeComponent();
        }

        private void penjual_Load(object sender, EventArgs e)
        {
            // Form Loaded
        }

        public void TampilkanDataPemesanan()
        {
            using (OleDbConnection conn = koon.GetConn())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM Pemesanan";
                    da = new OleDbDataAdapter(query, conn);
                    ds = new DataSet();
                    da.Fill(ds, "Pemesanan");

                    // Bind DataGridView dengan DataSet
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "Pemesanan";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void tampilkan_data_Click(object sender, EventArgs e)
        {
            TampilkanDataPemesanan();
        }

        private void bukaDetailPemesanan_Click(object sender, EventArgs e)
        {
            // Buka form detail_pemesanan dan kirim referensi form penjual
            detail_pemesanan detailForm = new detail_pemesanan(this);
            detailForm.Show();
        }
    }

    public partial class detail_pemesanan : Form
    {
        private penjual formPenjual; // Tambahkan variabel untuk menyimpan referensi ke form penjual

        public detail_pemesanan(penjual penjualForm)
        {
            InitializeComponent();
            formPenjual = penjualForm; // Inisialisasi referensi ke form penjual
        }



        private void tampilkanDataDetail_Click(object sender, EventArgs e)
        {
            // Panggil metode TampilkanDataPemesanan dari form penjual
            formPenjual.TampilkanDataPemesanan();
        }
    }
}
