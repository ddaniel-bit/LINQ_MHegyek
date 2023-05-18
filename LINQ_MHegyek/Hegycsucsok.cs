using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_MHegyek
{
    internal class Hegycsucsok
    {
        string nev;
        string hegyseg;
        int magassag;

        public Hegycsucsok(string nev, string hegyseg, int magassag)
        {
            this.nev = nev;
            this.hegyseg = hegyseg;
            this.magassag = magassag;
        }
        public string Nev { get => nev; }
        public string Hegyseg { get => hegyseg; }
        public int Magassag { get => magassag; }
    }
}
