﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utca
{
    internal class Telek
    {
        public bool paros;
        public int szelesseg;
        public string szin;
        public int hazszam;

        public Telek(string egySor) 
        {
            string[] vag = egySor.Split(" ");

            paros = vag[0] == "0";
            szelesseg = Convert.ToInt32(vag[1]);
            szin = vag[2];  

        }

    }
}
