using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Knjige
    {
        int ISBN;
        string Naziv, Autor;

        public Knjige(int iSBN, string naziv, string autor)
        {
            ISBN = iSBN;
            Naziv = naziv;
            Autor = autor;
        }

        public int ISBN1 { get => ISBN; set => ISBN = value; }
        public string Naziv1 { get => Naziv; set => Naziv = value; }
        public string Autor1 { get => Autor; set => Autor = value; }
    }
}
