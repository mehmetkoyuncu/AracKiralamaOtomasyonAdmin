using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class DataProvider
    {
        public SqlConnection Connection { get; set; }
        public SqlCommand komut { get; set; }

        public DataProvider(string connstr)
        {
            Connection = new SqlConnection(connstr);
            komut = Connection.CreateCommand();
        }

        public DataTable TabloGetir(string sorgu)
        {
            DataTable dt = new DataTable();
            komut.CommandText = sorgu;
            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            adapter.Fill(dt);
            return dt;
        }
        public object TekSatirGetir(string sorgu)
        {
            object result = null;
            komut.CommandText = sorgu;
            Connection.Open();
            result = komut.ExecuteScalar();
            Connection.Close();
            return result;

        }
        public int SorguyuCalistir(string sorgu)
        {
            int result = 0;
            komut.CommandText = sorgu;
            Connection.Open();
            result = komut.ExecuteNonQuery();
            Connection.Close();
            return result;

        }
    }
}
