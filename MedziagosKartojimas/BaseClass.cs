using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedziagosKartojimas
{
   abstract class BaseClass
    {
        public string Name { get; }
        public char[] Balses { get; set; }
        public BaseClass(string name)
        {
            Name = name;
            char[] balses = { 'a', 'e', 'i', 'u', 'o', 'y' };
            Balses = balses;
        }
       public abstract string NameMetodas();
        public abstract int NameKodas(int a);

    }
}
