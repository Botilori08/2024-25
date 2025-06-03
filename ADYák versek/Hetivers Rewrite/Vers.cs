using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace versek
{
    internal class Vers
    {
        public string felelos;
        public string versSzerzo;
        public string versCim;
        public string datum;

        public Vers(string felelos, string versSzerzo, string versCim, string datum)
        {
            this.felelos = felelos;
            this.versSzerzo = versSzerzo;
            this.versCim = versCim;
            this.datum = datum;
        }
    }
}
