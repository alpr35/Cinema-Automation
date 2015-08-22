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
    public partial class FilmAra : Form
    {
        public FilmAra()
        {
            InitializeComponent();
        }
        VeritabaniIslemleri vt = new VeritabaniIslemleri();
        private void FilmAra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinemaDataSet2.tblMovie' table. You can move, or remove it, as needed.
            this.tblMovieTableAdapter.Fill(this.sinemaDataSet2.tblMovie);
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
        private void Ara_Click(object sender, EventArgs e)
        {
            baglantiKur();
            string sql ="select * from tblMovie where Name like '%" + Arama.Text + "%'";
            SqlCommand cmdKLCgetir = new SqlCommand(sql, baglan);
            SqlDataAdapter da = new SqlDataAdapter(cmdKLCgetir);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewFilm.DataSource = dt;


        }

        private void dataGridViewFilm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
