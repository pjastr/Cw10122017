using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication42
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba1 = 30;
            int liczba2 = 0;
            int liczba3;
            try
            {
                liczba3 = liczba1 / liczba2;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.HelpLink);
            }
            finally
            {
                Console.WriteLine("finally");
            }
            
            Console.ReadKey();
        }
    }
}
