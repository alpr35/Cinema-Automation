using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace NewProject
{
    class VeritabaniIslemleri
    {
        SqlConnection connect = new SqlConnection
            ("Data Source=.;Initial Catalog=Sinema;Integrated Security=True");



        public DataTable getDataTable(string sorgu)
        {
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(sorgu, connect);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                connect.Close();
                return dt;
            }
            catch
            {
                throw new Exception("Hata");
            }

        }
        public void kayitEkle(string sorgu)
        {
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(sorgu, connect);
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch
            {
                throw new Exception("Hata");
            }

        }



    }
}
