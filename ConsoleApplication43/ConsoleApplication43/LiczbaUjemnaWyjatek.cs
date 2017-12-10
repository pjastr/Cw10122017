using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication43
{
    class LiczbaUjemnaWyjatek:Exception
    {
        public LiczbaUjemnaWyjatek()
            : base("Wiek nie może być liczbą ujemną")
        {
            
        }
    }
}
