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
    public partial class frmSonuc : Form
    {
       

        

        public frmSonuc(Ders drs)
        {

            InitializeComponent();
            float ort = (float)(drs.Viz * 0.4 + drs.Fnl * 0.6);
            lblSonuc.Text = $" {drs.DersKodu} {drs.Viz} {drs.Fnl} {ort}";
            FormDers frmders = new FormDers();


        }
    }
}
