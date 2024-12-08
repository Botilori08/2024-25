using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hf12._06
{
    internal class Ikarus
    {
        public string tipus;
        public string gyartasIdo;
        public int darabszam;

        public Ikarus(string type,string made,int mennyi)
        {
            tipus = type;
            gyartasIdo = made;
            darabszam = mennyi;
        }
    }
}
