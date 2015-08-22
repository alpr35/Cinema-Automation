using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NewProject
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void KullaniciEkle_Click(object sender, EventArgs e)
        {
            aEkle frm1 = new aEkle();
            frm1.ShowDialog();
        }

        private void SlnEkle_Click(object sender, EventArgs e)
        {
            SalonEkle frm2 = new SalonEkle();
            frm2.ShowDialog();
        }

        private void FlmEkle_Click(object sender, EventArgs e)
        {
            FilmEkle frm3 = new FilmEkle();
            frm3.ShowDialog();
        }

        private void seansEkle_Click(object sender, EventArgs e)
        {
            SeansEkle frm4 = new SeansEkle();
            frm4.ShowDialog();
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            Guncelle frm5 = new Guncelle();
            frm5.ShowDialog();
        }
    }
}
