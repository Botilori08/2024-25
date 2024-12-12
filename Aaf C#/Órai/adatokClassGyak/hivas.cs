using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adatokClassGyak
{
	internal class hivas
	{

		public int[] kezdIdo = new int[3];
		public int[] vegIdo = new int[3];

		public hivas(string sor)
		{
			// egy sor: "7 58 33 7 58 47"

			string[] vag = sor.Split(' ');
			kezdIdo[0] = int.Parse(vag[0]);
			kezdIdo[1] = Convert.ToInt32(vag[1]);
            kezdIdo[2] = Convert.ToInt32(vag[2]);
            vegIdo[3] = Convert.ToInt32(vag[3]);
            vegIdo[4] = Convert.ToInt32(vag[4]);
            vegIdo[5] = Convert.ToInt32(vag[5]);

        }

        public int idoMpkezd()
        {
			return kezdIdo[0] * 60 * 60 + kezdIdo[1] * 60 + kezdIdo[2];

        }

        public int idoMpVeg()
        {
            return vegIdo[0] * 60 * 60 + vegIdo[1] * 60 + vegIdo[2];

        }
    }
}
