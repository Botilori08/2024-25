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
    }
}
