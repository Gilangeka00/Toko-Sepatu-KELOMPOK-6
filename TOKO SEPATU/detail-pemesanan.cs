using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Windows.Forms;

namespace TOKO_SEPATU
{
    public partial class detail_pemesanan : Form
    {
        private ListView listView; // Corrected variable name

    // Declare da and ds to use them in the GetDataFromDatabase method
    private OleDbDataAdapter da;
    private DataSet ds;
        public detail_pemesanan()
        {
            InitializeComponent();
        }
        public detail_pemesanan(DataTable data)
        {
            InitializeComponent();

            // Inisialisasi ListView
            listViewDetail = new ListView();
            listViewDetail.View = View.Details;
            listViewDetail.FullRowSelect = true;

            // Menambah kolom-kolom pada ListView sesuai dengan kolom-kolom pada tabel Pemesanan
            foreach (DataColumn column in data.Columns)
            {
                listViewDetail.Columns.Add(column.ColumnName);
            }

            // Menambah data ke ListView
            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row.ItemArray.Select(i => i.ToString()).ToArray());
                listViewDetail.Items.Add(item);
            }

            // Menambahkan ListView ke form
            Controls.Add(listViewDetail);
        }
        private DataTable GetDataFromDatabase()
        {
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\\MATERI\\S3\\PEMOGRAMAN LANJUT\\UTS\\V1\\TOKO SEPATU - Copy\\dbtsepatu.mdb;User Id=YourUsername;Password=YourPassword;Persist Security Info=False;"))
            {
                
                
                conn.Open();
                string query = "SELECT * FROM Pemesanan ORDER BY ID DESC";
                da = new OleDbDataAdapter(query, conn);
                ds = new DataSet();
                da.Fill(ds, "Pemesanan");
            }

            return ds.Tables["Pemesanan"];
        }
        
        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void tampilkan_Click(object sender, EventArgs e)
        {
            
        }

        public void detail_pemesanan_Load(object sender, EventArgs e)
        {

        }

        private void listViewDetail_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void KONFIRMASI_Click(object sender, EventArgs e)
        {
            DataTable data = GetDataFromDatabase();

            // Check if there is any data to display
            if (data.Rows.Count > 0)
            {
                // Build a message to display the data
                StringBuilder message = new StringBuilder();
                foreach (DataRow row in data.Rows)
                {
                    // Customize this part based on your data structure
                    message.AppendLine($"ID: {row["ID"]}, Nama: {row["NAMA"]}, Alamat: {row["ALAMAT"]}, ...");
                }

                // Display the data in a MessageBox
                MessageBox.Show(message.ToString(), "Data Pemesanan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tidak ada data pemesanan yang dikonfirmasi.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}