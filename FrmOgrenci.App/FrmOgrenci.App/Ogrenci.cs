using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmOgrenci.App
{
    public class Ogrenci
    {
		private int ogrNo;

		public int OgrNo
		{
			get { return ogrNo; }
			set { ogrNo = value; }
		}
		private string adi;

		public string Adi
		{
			get { return adi; }
			set { adi = value; }
		}

		private string soyad;

		public string Soyad
		{
			get { return soyad; }
			set { soyad = value; }
		}


	}
}
