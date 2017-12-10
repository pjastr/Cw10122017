using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication50
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int liczba = Convert.ToInt32(Console.ReadLine());
                Osoba os1 = new Osoba(liczba);
            }

            catch(NaszWyjatekException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("błędny format");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
            }
            

            Console.ReadKey();
        }
    }

    class Osoba
    {
        private int wiek;

        public Osoba(int wiek)
        {
            if (wiek < 0) throw new NaszWyjatekException("wiek nie może być ujemny");
            this.wiek = wiek;
        }
    }

    class NaszWyjatekException:Exception
    {
        public NaszWyjatekException() { }

        public NaszWyjatekException(string message) : base(message) { }
        public NaszWyjatekException(String message, Exception innerException)
            : base(message, innerException) { }

    }
}
