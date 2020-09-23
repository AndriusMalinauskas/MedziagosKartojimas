using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedziagosKartojimas
{
    class CKlase : BKlase
    {
        public int Skaicius { get; set; }
        public string Zodis { get; set; }
        public double DoubleSkaicius { get; set; }
        public AKlase AObjektas { get; set; }
        public CKlase(string name) : base (name)
        {

        }
        public CKlase()
        {

        }
        public CKlase(int skaicius)
        {
            Skaicius = skaicius;
        }
        public CKlase(int skaicius, string zodis)
        {
            Skaicius = skaicius;
            Zodis = zodis;
        }
        public CKlase(int skaicius, string zodis, double doubleSkaicius, AKlase aObjektas)
        {
            Skaicius = skaicius;
            Zodis = zodis;
            DoubleSkaicius = doubleSkaicius;
            AObjektas = aObjektas;
        }
       
    }
}
