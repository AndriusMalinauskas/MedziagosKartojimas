using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedziagosKartojimas
{
    class BKlase : BaseClass, ZodisKitaip
    {
        public BKlase(string name) : base(name)
        {

        }
        public override int NameKodas(int a)
        {
            var kodas = 0;
            foreach (var item in Name)
            {
                kodas += (int)item - a;
            }
            return kodas;
        }

        public override string NameMetodas()
        {
            var zodis = "";
            foreach (var item in Name)
            {
                if (Balses.Contains(item))
                {
                    zodis += (int)item;
                }
                else
                {
                    zodis += item;
                }
            }
            return zodis;
        }

        public string ZodisBeBalsiu()
        {
            var zodis = "";
            foreach (var item in Name)
            {
                if (!Balses.Contains(item))
                {
                    zodis += item;
                }
            }
            return zodis;
        }

        public string ZodisBePriebalsiu()
        {
            var zodis = "";
            foreach (var item in Name)
            {
                if (Balses.Contains(item))
                {
                    zodis += item;
                }
            }
            return zodis;
        }

        public string ZodisSuPakeistomisBalsemis(char a)
        {
            var zodis = "";
            foreach (var item in Name)
            {
                if (Balses.Contains(item))
                {
                    zodis += a;
                }
                else
                {
                    zodis += item;
                }
            }
            return zodis;
        }

        public string ZodisSuPakeistomisPriebalsemis(int a)
        {
            var zodis = "";
            foreach (var item in Name)
            {
                if (!Balses.Contains(item))
                {
                    zodis += a;
                }
                else
                {
                    zodis += item;
                }
            }
            return zodis;
        }
    }
}
