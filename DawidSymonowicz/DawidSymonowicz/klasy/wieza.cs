using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DawidSymonowicz.klasy
{
    class wieza:Figury
    {
        public wieza(pozycja pozycja, string kolor) : base(pozycja,kolor)
        {

        }
        public virtual bool CzyMoznaPrzesunac(pozycja nowaPozycja)
        {
            return CzyPionowo(nowaPozycja) || CzyPoziomo(nowaPozycja) ;

        }
    }
}
