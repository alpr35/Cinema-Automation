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
    public partial class FlmGuncll : Form
    {
        public FlmGuncll()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection();
        VeritabaniIslemleri vt = new VeritabaniIslemleri();
        void baglantiKur()
        {
            baglan.ConnectionString = "Data Source=.;Initial Catalog=Sinema;Integrated Security=True";
            if (baglan.State == ConnectionState.Closed)
            {

                baglan.Open();

            }
        }
        private void Güncelle_Click(object sender, EventArgs e)
        {
           
        }

        private void FlmGuncll_Load(object sender, EventArgs e)
        {
            baglantiKur();
            string sql = "Select Name,movieId from tblMovie";
            Güncelle.DataSource = vt.getDataTable(sql);
            Güncelle.ValueMember = "movieId";
            Güncelle.DisplayMember = "Name";
            baglan.Close();
        }
    }
}
