using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._14_OOP
{
    internal class fuvar
    {
        public int nap;
        public int fuvarSzam;
        public int ut;

        public fuvar(string egySor)
        {
            string[] vag = egySor.Split(' ');
            nap = Convert.ToInt32(vag[0]);
            fuvarSzam = Convert.ToInt32(vag[1]);
            ut = Convert.ToInt32(vag[2]);


        }


    }
}
