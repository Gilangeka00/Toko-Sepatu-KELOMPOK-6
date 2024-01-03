using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace TOKO_SEPATU
{
    public partial class pemesanan : Form
    {
        private OleDbCommand cmd;
        private DataSet ds;
        private OleDbDataAdapter da;
        private Koneksi koon = new Koneksi();
      
        public pemesanan()
        {
            InitializeComponent();
        }

        public void tambahData(string NAMA, string ALAMAT, string PROVINSI, string KOTA, string NO_HP, string EMAIL, string KODE_POS, string KODE_DISKON)
        {
            using (OleDbConnection conn = koon.GetConn())
            {
                try
                {
                    conn.Open();

                    // Gunakan parameterized query untuk mencegah SQL Injection
                    string query = "INSERT INTO Pemesanan (NAMA, ALAMAT, PROVINSI, KOTA, NO_HP, EMAIL, KODE_POS, KODE_DISKON) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
                    cmd = new OleDbCommand(query, conn);

                    // Tentukan nilai parameter
                    cmd.Parameters.AddWithValue("?", NAMA);
                    cmd.Parameters.AddWithValue("?", ALAMAT);
                    cmd.Parameters.AddWithValue("?", PROVINSI);
                    cmd.Parameters.AddWithValue("?", KOTA);
                    cmd.Parameters.AddWithValue("?", NO_HP);
                    cmd.Parameters.AddWithValue("?", EMAIL);
                    cmd.Parameters.AddWithValue("?", KODE_POS);
                    cmd.Parameters.AddWithValue("?", KODE_DISKON);

                    // Jalankan perintah INSERT
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil ditambahkan!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void lanjutkan_Click(object sender, EventArgs e)
        {
            // Panggil fungsi tambahData dengan nilai yang sesuai dari TextBox
            tambahData(nama.Text, alamat.Text, prov.Text, kota.Text, nomer.Text, email.Text, pos.Text, kd_diskon.Text);
            MessageBox.Show("Data berhasil disimpan!");

            // Bersihkan nilai TextBox jika diperlukan
            
            // Lanjutkan ke form selanjutnya jika diperlukan
            detail_pemesanan detail = new detail_pemesanan();
            detail.Show();
            this.Hide();
        }


        private void pemesanan_Load(object sender, EventArgs e)
        {

        }
    }
}