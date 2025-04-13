using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZPOSHARPAM
{
    internal class Figure3
    {
        public double GetS(double a)
        {
            return 6 * a * a;
        }
        public double GetS(double a, double b, double c)
        {
            return 2 * (a * b + a * c + b * c);
        }
    }
}
