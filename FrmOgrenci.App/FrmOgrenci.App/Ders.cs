using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmOgrenci.App
{
  public  class Ders
    {
		private int dersKodu;

		public int DersKodu
		{
			get { return dersKodu; }
			set { dersKodu = value; }
		}

		private string dersAd;

		public string DersAd
		{
			get { return dersAd; }
			set { dersAd = value; }
		}

		private int viz;

		public int Viz
		{
			get { return viz; }
			set { viz = value; }
		}

		private int fnl;

		public int Fnl
		{
			get { return fnl; }
			set { fnl = value; }
		}

	}
}
