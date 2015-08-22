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
    public partial class aEkle : Form
    {
        public aEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection();
        private void Ekle_Click(object sender, EventArgs e)
        {
            baglan.ConnectionString = "Data Source=.;Initial Catalog=Sinema;Integrated Security=True";
            baglan.Open(); // Bağlantıyı aç.
            string sql = "INSERT INTO Users(userName,Password,accessType,Name,Surname,Phone) VALUES('" + kAdi.Text + "','" + Sifre.Text + "','" + ((string)YetkiBox.Items[YetkiBox.SelectedIndex]) + "','" + Adı.Text + "','" + Soyadı.Text + "','" + Tel.Text + "')";
            SqlCommand cmd = new SqlCommand(sql, baglan);
            cmd.ExecuteNonQuery();
            baglan.Close();
        }
    }
}
