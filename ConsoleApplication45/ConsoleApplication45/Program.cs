using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");
            double a;
            while (true)
            {
                try
                {
                    a = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            Console.WriteLine("a ={0}", a);
            Console.ReadKey();
        }
    }
}
