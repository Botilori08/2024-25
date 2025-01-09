using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autok_01._07
{
    internal class Adatok
    {
        public string rendszam;
        public int ora;
        public int perc;
        public int sebesseg;

        public Adatok(string rendszam, int ora, int perc,int sebesseg)
        {
            this.rendszam = rendszam;
            this.ora = ora;
            this.perc = perc;
            this.sebesseg = sebesseg;
        }


        public Adatok(string sor)
        {
            string[] vag = sor.Split("\t");

            rendszam = vag[0];
            ora = Convert.ToInt32(vag[1]);
            perc = Convert.ToInt32(vag[2]);
            sebesseg = Convert.ToInt32(vag[3]);
        }

        public string ido()
        {
            return $"{ora}:{perc:00}";
        }

        public bool check(int ora, int perc)
        {
            return ora==this.ora && perc==this.perc;
        }

    }
}
