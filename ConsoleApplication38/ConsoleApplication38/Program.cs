using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Program
    {
        static void Main(string[] args)
        {
            //Figura f1 = new Figura();
            Kwadrat k1 = new Kwadrat(5);
            Trojkat t1 = new Trojkat(2,3,4);

            List<Figura> figury = new List<Figura>();
            figury.Add(new Trojkat(3, 4, 5));
            figury.Add(new Kwadrat(51));
            figury.Add(new Trojkat(5, 12, 13));
            figury.Add(new Kwadrat(4));
            foreach(var element in figury)
            {
                Console.WriteLine(element.ObliczPole());
            }
            Console.ReadKey();
        }
    }
}
