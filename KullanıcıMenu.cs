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
    public partial class KullanıcıMenu : Form
    {
        public KullanıcıMenu()
        {
            InitializeComponent();
        }

        private void FilmArama_Click(object sender, EventArgs e)
        {
            FilmAra frm1 = new FilmAra();
            frm1.ShowDialog();
        }
    }
}
