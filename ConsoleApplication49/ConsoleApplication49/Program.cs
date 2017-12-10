using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication49
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba1 = 30;
            int liczba2 = 0;
            try
            {
                int liczba3 = liczba1 / liczba2;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finally");
            }

            Console.ReadKey();
        }
    }
}
