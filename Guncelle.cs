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
    public partial class Guncelle : Form
    {
        public Guncelle()
        {
            InitializeComponent();
        }

        private void flmguncel_Click(object sender, EventArgs e)
        {
            FlmGuncll frm1 = new FlmGuncll();
            frm1.ShowDialog();
        }
    }
}
