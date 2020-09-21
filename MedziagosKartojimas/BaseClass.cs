﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedziagosKartojimas
{
   abstract class BaseClass
    {
        public string Name { get; }
        public BaseClass(string name)
        {
            Name = name;
        }
       public abstract string NameMetodas();
        public abstract int NameKodas(int a);

    }
}