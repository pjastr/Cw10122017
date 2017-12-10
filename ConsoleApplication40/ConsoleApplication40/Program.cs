using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication40
{
    class Program
    {
        static void Main(string[] args)
        {
            Ccc obiekt = new Ccc();
            obiekt.Metoda();

            Console.ReadKey();
        }
    }

    class Aaa
    {
        public virtual void Metoda()
        {
            Console.WriteLine("Aaa");
        }

    }

    class Bbb : Aaa 
    {
        public override sealed void Metoda()
        {
            Console.WriteLine("bbb");
        }
    }

    class Ccc : Bbb 
    {
        //public override void Metoda()
        //{
        //    Console.WriteLine("ccc");
        //}
    }
}
