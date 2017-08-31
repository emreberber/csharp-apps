using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _047_CokBicimlilik
{
    public class Ekmek:URUN
    {
        public string Ekmekturu { get; set; }
        public int Gramaj { get; set; }
        public override double kdvuygula()
        {
            return Fiyat * 1.01;
        }
        public Ekmek(string ad , double fiyat , string ekmekturu , int gramaj)
        {
            urunadi = ad;
            Fiyat = fiyat;
            Ekmekturu = ekmekturu;
            Gramaj = gramaj;
        }
    }
}
