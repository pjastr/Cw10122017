using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication43
{
    class Osoba
    {
        private int wiek;

        public Osoba(int wiek)
        {
            if (wiek < 0) throw new LiczbaUjemnaWyjatek();
            this.wiek = wiek;
        }
    }
}
