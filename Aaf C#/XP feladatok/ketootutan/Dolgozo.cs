﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ketootutan
{
    class Dolgozo
    {
        public string azonosito;
        public string nev;
        public string anyjaNeve;
        public string telepules;
        public string cim;
        public int netto;
        public int juttatas;
        public string belepes;
        public string szuletes;
        public string szulHely;

        public Dolgozo(string sor)
        {
            string[] vag = sor.Split(';');
            azonosito = vag[0].Substring(1, vag[0].Length -2);
            //Console.WriteLine(azonosito);
            nev = vag[1].Substring(1, vag[1].Length - 2);
            //Console.WriteLine(nev);
            anyjaNeve = vag[2].Substring(1, vag[2].Length - 2); ;
            telepules = vag[3].Substring(1, vag[3].Length - 2);
            cim = vag[4].Substring(1, vag[4].Length - 2);
            string get_netto = vag[5].Substring(1, vag[5].Length - 2);
            netto = Convert.ToInt32(get_netto);
            string juttatas_get = vag[6].Substring(1,vag[6].Length - 2);
            juttatas = Convert.ToInt32(juttatas_get);
            belepes = vag[7].Substring(1, vag[7].Length - 2);
            szuletes = vag[8].Substring(1, vag[8].Length - 2);
            szulHely = vag[9].Substring(1, vag[9].Length - 2);
        }

        public int Ev()
        {
            return Convert.ToInt32(belepes.Substring(0, 3));
        }
    }
}
