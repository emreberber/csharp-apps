using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _046_Kapsulleme
{
    class Emlak
    {
        private string semt;

        public string Semt
        {
            get { return semt; }
            set { semt = value.ToUpper(); }
        }
        private int odasayisi;

        public int Odasayisi
        {
            get { return odasayisi; }
            set { odasayisi = Math.Abs(value); }
        }

        private int katno;

        public int Katno
        {
            get { return katno; }
            set { katno = Math.Abs(value); }
        }
        private int alan;

        public int Alan
        {
            get { return alan; }
            set { alan = Math.Abs(value); }
        }
    }
}
