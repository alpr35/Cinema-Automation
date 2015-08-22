using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

//Alper ILCIKTAY
//13253030

namespace NewProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection();
        string  kulYetki;
        private void Giris_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(kAdi.Text) ||
               String.IsNullOrWhiteSpace(Sifre.Text))
            {
                MessageBox.Show("Giriş Başarısız! Eksiksiz Giriniz!", "..:: HATA ::..",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                // Sql bağlantı cümlemiz.
                baglan.ConnectionString = "Data Source=.;Initial Catalog=Sinema;Integrated Security=True";
                baglan.Open(); // Bağlantıyı aç.
                // Sorgumuz. 
                string sql = "SELECT * FROM Users WHERE userName=@userName AND Password=@Password";
                SqlParameter prms1 = new SqlParameter("@userName", kAdi.Text);
                SqlParameter prms2 = new SqlParameter("@Password", Sifre.Text);
                SqlCommand cmd = new SqlCommand(sql, baglan);
                cmd.Parameters.Add(prms1);
                cmd.Parameters.Add(prms2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                baglan.Close();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Hoşgeldin " + kAdi.Text);
                    //string komut = "Select accessType From Users Where userName='kAdi.Text' AND Password='Sifre.Text'";
                    //SqlCommand Command = new SqlCommand(komut, baglan);
                    baglan.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        kulYetki = dr[4].ToString();
                    }
                    if (kulYetki=="Admin")
                    {
                        MessageBox.Show("Hİ Admin");
                        AdminMenu admn = new AdminMenu();
                        admn.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Hi User");
                        KullanıcıMenu klnc = new KullanıcıMenu();
                        klnc.ShowDialog();
                    }
                } 
                else
                {
                    MessageBox.Show("Veritabanında böyle bir kullanıcı bulunamadı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void YniUye_Click(object sender, EventArgs e)
        {
            UyeKayit frm = new UyeKayit();
            frm.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
