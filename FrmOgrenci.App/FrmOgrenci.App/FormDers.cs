using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmOgrenci.App
{
    public partial class FormDers : Form
    {
        public FormDers()
        {
            this.InitializeComponent();
        }

        public FormDers(Ogrenci ogr)
        {
            InitializeComponent();
           
            string a = ogr.Adi;
            string b = ogr.Soyad;
            int c=Convert.ToInt32(ogr.OgrNo);
            FormDers frm = new FormDers();
            
        }

       

        private void btnileri_Click(object sender, EventArgs e)
        {
            int kod=Convert.ToInt32(txtKodu.Text);
            string adi=txtAdi.Text;
            float v = float.Parse(txtViz.Text);
            float fnl = float.Parse(txtFnl.Text);
            float ort = (float)((float.Parse(txtViz.Text) * 0.4) + (float.Parse(txtFnl.Text) * 0.6));
            frmSonuc frmsonuc = new frmSonuc();
            frmsonuc.Show();
        }
    }
}
