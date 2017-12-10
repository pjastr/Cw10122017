using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Kwadrat:Figura
    {
        public override double ObliczPole()
        {
            return a*a;
        }

        public Kwadrat(double a)
        {
            this.a = a;
        }
    }
}
