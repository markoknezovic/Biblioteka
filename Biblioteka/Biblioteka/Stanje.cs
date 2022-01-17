using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Stanje
    {
        int ID_knjige, Kolicina;

        public Stanje(int iD_knjige, int kolicina)
        {
            ID_knjige = iD_knjige;
            Kolicina = kolicina;
        }

        public int ID_knjige1 { get => ID_knjige; set => ID_knjige = value; }
        public int Kolicina1 { get => Kolicina; set => Kolicina = value; }
    }
}
