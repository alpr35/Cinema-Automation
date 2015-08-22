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
    public partial class SeansEkle : Form
    {
        public SeansEkle()
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
        VeritabaniIslemleri vt = new VeritabaniIslemleri();
        private void Ekle_Click(object sender, EventArgs e)
        {
            baglantiKur();
            //string sql2 = "Select saloonId from tblSaloon WHERE Name='Salon2'";
            //SqlCommand cmd2 = new SqlCommand(sql2, baglan);
            //SqlDataReader rd = cmd2.ExecuteReader();
            //while (rd.Read())
            //{
            //    saloonId = int.Parse(rd[0].ToString());
            //}
            string sql = "INSERT INTO tblSessions(saloonId,Time) VALUES('" + (int)(SaloonBox.SelectedValue) + "','" + Time.Text + "')";
            SqlCommand cmd = new SqlCommand(sql, baglan);
            cmd.ExecuteNonQuery();
            baglan.Close();
            /*SaloonBox.DataSource = vt.getDataTable("select saloonId from tblSaloon Where Name='Salon2'");
            SaloonBox.ValueMember = "id";
            SaloonBox.DisplayMember = "ad"; */
        }

        private void SeansEkle_Load(object sender, EventArgs e)
        {
           baglantiKur();
            string sql = "Select Name,SaloonId from tblSaloon";
            SaloonBox.DataSource = vt.getDataTable(sql);
                SaloonBox.ValueMember = "SaloonId";
                SaloonBox.DisplayMember = "Name";
            baglan.Close();
        }
    }
}
