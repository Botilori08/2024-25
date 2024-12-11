using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._11_Gyak_OOP
{
	internal class Buksza
	{
		int penz;
		public string szin;
		public int Penz
		{
			get { return penz; }

			set { penz = value; }

		}

		public Buksza(int penz)
		{
			Penz = penz;
		}
		public Buksza(int penz, string szin)
		{
			Penz = penz;
			this.szin = szin;
		}


		public override string ToString()
		{
			return $"{szin} buksza, benne {penz} forint";
		}

		public void noveles(int noveles)
		{
			 int osszeg = penz + noveles;
			if (osszeg <= 0)
			{
				Console.WriteLine("Üres a bukszád");
            }
			else
			{
				Console.WriteLine($"A bukszádban {osszeg} Ft van");
			}
		}
	}
}
