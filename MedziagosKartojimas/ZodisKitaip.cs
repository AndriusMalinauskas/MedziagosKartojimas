using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedziagosKartojimas
{
    interface ZodisKitaip
    {
        string ZodisBeBalsiu();
        string ZodisBePriebalsiu();
        string ZodisSuPakeistomisBalsemis(char a);
        string ZodisSuPakeistomisPriebalsemis(int a);

    }
}
