using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FrmOgrenci.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            string ad=txtAd.Text;
            string syd=txtSoyad.Text;
            int no = Convert.ToInt32(txtNo.Text);
            FormDers frmDers = new FormDers();
            frmDers.Show();

        }
    }
}
