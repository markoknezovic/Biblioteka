using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Korisnici
    {
        int OIB;
        string Ime, Prezime;

        public Korisnici(int oIB, string ime, string prezime)
        {
            OIB = oIB;
            Ime = ime;
            Prezime = prezime;
        }

        public int OIB1 { get => OIB; set => OIB = value; }
        public string Ime1 { get => Ime; set => Ime = value; }
        public string Prezime1 { get => Prezime; set => Prezime = value; }
    }
}
