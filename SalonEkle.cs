using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NewProject
{
    public partial class SalonEkle : Form
    {
        public SalonEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection();

        void baglantiKur()
        {
            baglan.ConnectionString = "Data Source=.;Initial Catalog=Sinema;Integrated Security=True";
            if (baglan.State == ConnectionState.Closed)
            {

                baglan.Open();

            }

        }
        private void Ekle_Click(object sender, EventArgs e)
        {
            baglantiKur();
            string sql = "INSERT INTO tblSaloon(Name,Row,[Column]) VALUES('" + Adı.Text + "','" + Row.Text + "','" + Column.Text + "')";
            SqlCommand cmd = new SqlCommand(sql, baglan);
            cmd.ExecuteNonQuery();
            baglan.Close();
        }
    }
}
