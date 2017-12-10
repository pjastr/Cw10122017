using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication53
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringLiczba = "245232";
            string stringPusty = null;
            string blednyFormat = "5.287";
            string pozaZakres = "9876225432123456";
            int liczba;

            liczba = int.Parse(stringLiczba);
            //liczba = int.Parse(stringPusty);
            //liczba = int.Parse(blednyFormat);
            //liczba = int.Parse(pozaZakres);

            liczba = Convert.ToInt32(stringLiczba);
            liczba = Convert.ToInt32(stringPusty);
            //liczba = Convert.ToInt32(blednyFormat);
            //liczba = Convert.ToInt32(pozaZakres);

            bool wynik;
            wynik = int.TryParse(stringLiczba, out liczba);
            wynik = int.TryParse(stringPusty, out liczba);
            wynik = int.TryParse(blednyFormat, out liczba);
            wynik = int.TryParse(pozaZakres, out liczba);

            Console.ReadKey();
        }
    }
}
