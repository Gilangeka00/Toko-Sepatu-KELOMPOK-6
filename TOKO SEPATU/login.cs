using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOKO_SEPATU
{
    public partial class Form1 : Form
    {
        // Ganti dengan jalur file database Anda
        private string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\MATERI\S3\PEMOGRAMAN LANJUT\UTS\V1\TOKO SEPATU - Copy\dbtsepatu.mdb";

        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Username, Password FROM LOGIN_AWAL WHERE Username = ? AND Password = ?";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", textBoxUSER.Text);
                        command.Parameters.AddWithValue("@password", textBoxPASS.Text);

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Login berhasil
                                // Dapatkan username dan password jika perlu
                                string username = reader["Username"].ToString();
                                string password = reader["Password"].ToString();

                                // Lanjutkan dengan menampilkan form sesuai
                                // ...
                                if(username == "penjual" && password == "penjual")
                                {
                                    penjual menuPenjual = new penjual();
                                    menuPenjual.Show();
                                }
                                else if (username == "pembeli" && password == "pembeli")
                                {
                                    menu_awal menuPembeli = new menu_awal();
                                    menuPembeli.Show();
                                }

                                MessageBox.Show("Login Berhasil");
                            }
                            else
                            {
                                // Login gagal
                                MessageBox.Show("USERNAME ATAU PASSWORD YANG KAMU MASUKAN SALAH");
                            }
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBoxUSER_TextChanged(object sender, EventArgs e)
        {
            // Code lainnya
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
