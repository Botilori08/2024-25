using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juta
{
	internal class Dolgozo
	{
		public int azonosito;
		public string nev;
		public string anyjaNeve;
		public string telepules;
		public string cim;
		public int fizetes;
		public int jutalom;
		public string belepes;
		public string szuletes;
		public string szuletesiHely;

		public Dolgozo(string sor)
		{
			string[] vag = sor.Split(';');
			azonosito = Convert.ToInt32(vag[0]);
			nev = vag[1];
			anyjaNeve = vag[2];
			telepules = vag[3];
			cim = vag[4];
			fizetes = Convert.ToInt32(vag[5]);
			jutalom = Convert.ToInt32(vag[6]);
			belepes = vag[7];
			szuletes = vag[8];
			szuletesiHely = vag[9];
		}
	}
}
