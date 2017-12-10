using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Trojkat:Figura
    {
        public override double ObliczPole()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }

        public Trojkat(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }
}
