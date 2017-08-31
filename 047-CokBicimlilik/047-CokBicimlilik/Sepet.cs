using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _047_CokBicimlilik
{
    public class Sepet
    {
        private List<URUN> urunler = new List<URUN>();
        public double toplamTutar()
        {
            double toplamfiyat = 0;
            foreach(URUN item in urunler)
            {
                toplamfiyat += item.kdvuygula();
            }
            return toplamfiyat;
        }
        public void Urunekle(URUN yeniurun)
        {
            urunler.Add(yeniurun);
        }
    }
}
