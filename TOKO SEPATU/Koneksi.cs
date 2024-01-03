using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace TOKO_SEPATU
{
    public class Koneksi
    {
        public OleDbConnection GetConn()
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\\MATERI\\S3\\PEMOGRAMAN LANJUT\\UTS\\V1\\TOKO SEPATU - Copy\\dbtsepatu.mdb;";
            return conn;
        }
    }
}
