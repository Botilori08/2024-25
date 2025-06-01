using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace konyvek
{
    internal class Konyv
    {
        public int ev;
        public int negyedEv;
        public string konyvEredete;
        public string leiras;
        public int peldanySzam;

        public Konyv(int ev, int negyedEv, string konyvEredete, string leiras, int peldanySzam)
        {
            this.ev = ev;
            this.negyedEv = negyedEv;
            this.konyvEredete = konyvEredete;
            this.leiras = leiras;
            this.peldanySzam = peldanySzam;
        }
    }
}
