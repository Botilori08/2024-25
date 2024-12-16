using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._14_OOP
{
	internal class Adas
	{
		public string elsoSor;

		public int napSorszam;
		public int radioAmator;
		public string feljegyzes;

		public int felnottF = -1;
		public int kolyokF = -1;


		public Adas(string elsoSor,string masodikSor) 
		{
			string[] vag = elsoSor.Split(" ");
			napSorszam = Convert.ToInt32(vag[0]);
			radioAmator = Convert.ToInt32(vag[1]);

			feljegyzes = masodikSor;
		}

		public void farkasKereso(string sor)
		{
			string[] levag = sor.Split(" ")[0].Split("/");
			try
			{
                felnottF = Convert.ToInt32(levag[0]);
                kolyokF = Convert.ToInt32(levag[1]);

            }
            catch (Exception)
			{
				//Ha throw, akkor hibaüzenetet dob
				//throw;
			}


		}
	}
}
