using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedziagosKartojimas
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = new AKlase("mama");
            Console.WriteLine(name.NameKodas(2));
            Console.WriteLine(name.NameMetodas());

            Console.ReadKey();
        }
    }
}
