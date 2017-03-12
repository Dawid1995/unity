using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DawidSymonowicz.klasy
{
   abstract class Figury
    {
        protected pozycja pozycja = null;
        protected pozycja Pozycja

        {
            get
            {
            return pozycja;
            }
        }
        public string kolor;
        protected bool CzyPionowo(pozycja nowaPozycja)
            {
            return Pozycja.Y == nowaPozycja.Y;

            }
        protected bool CzyPoziomo(pozycja nowaPozycja)
            {
            return Pozycja.X == nowaPozycja.X;

            }
        protected bool CzySkos(pozycja nowaPozycja)
            {
            return Math.Abs(Pozycja.Y - nowaPozycja.Y) == Math.Abs(Pozycja.X - nowaPozycja.X);

            }
        public virtual bool CzyMoznaPrzesunac(pozycja nowaPozycja)
            {
            return CzyPionowo(nowaPozycja) || CzyPoziomo(nowaPozycja) || CzySkos(nowaPozycja);

            }
        public Figury(pozycja pozycja, string kolor)
            {
            this.pozycja = pozycja;
            this.kolor = kolor;

            }
    }
}
