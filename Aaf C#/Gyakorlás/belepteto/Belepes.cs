using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace belepteto
{
    internal class Belepes
    {
        public string tanuloKod;
        public string idopont;
        public int mitCsinalt;

        public Belepes(string sor) {
            string[] vag = sor.Split(' ');

            tanuloKod = vag[0];
            idopont = vag[1];
            mitCsinalt = int.Parse(vag[2]);
        }

        public int idoValto(string idopont)
        {
            int ora = Convert.ToInt32(idopont.Split(":")[0]);
            int perc = Convert.ToInt32(idopont.Split(",")[1]);

            return ora * 60 + perc;
        }
    }
}
