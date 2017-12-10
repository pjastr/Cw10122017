using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication44
{
    class Program
    {
        static void Main(string[] args)
        {
            throw new NaszWyjatekException("sjdhfhsd komunikat");
        }
    }

    class NaszWyjatekException:Exception
    {
        public NaszWyjatekException() { }

        public NaszWyjatekException(string message) 
            : base(message) { }

        public NaszWyjatekException(String message, Exception innerException)
            : base(message, innerException) { }


    }
}
