using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultrabalaton
{
    internal class Adatok
    {
        public string nev;
        public int rajtSzam;
        public string kategoria;
        public string idoEredmeny;
        public int befSzazalek;

        public Adatok(string sor)
        {
            string[] vag = sor.Split(';');

            nev = vag[0];
            rajtSzam = Convert.ToInt32(vag[1]);
            kategoria = vag[2];
            idoEredmeny = vag[3];
            befSzazalek = Convert.ToInt32(vag[4]);
        }
    }
}
