using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032_OOPGiris
{
    class Otomobil
    {
        public string marka
        {
            get;
            set;
        }
        public string model
        {
            get;
            set;
        }
        public int yil
        {
            get;
            set;
        }
        public string renk
        {
            get;
            set;
        }
        public string vites
        {
            get;
            set;
        }

        public string markagetir()
        {
            return marka;
            
        }
    }
}
