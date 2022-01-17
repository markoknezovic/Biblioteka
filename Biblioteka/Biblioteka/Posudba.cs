using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Posudba
    {
        DateTime datum_p, datum_v;
        int ID_knjige, ID_kor;

        public Posudba(DateTime datum_p, DateTime datum_v, int iD_knjige, int iD_kor)
        {
            this.datum_p = datum_p;
            this.datum_v = datum_v;
            ID_knjige = iD_knjige;
            ID_kor = iD_kor;
        }

        public DateTime Datum_p { get => datum_p; set => datum_p = value; }
        public DateTime Datum_v { get => datum_v; set => datum_v = value; }
        public int ID_knjige1 { get => ID_knjige; set => ID_knjige = value; }
        public int ID_kor1 { get => ID_kor; set => ID_kor = value; }
    }
}
