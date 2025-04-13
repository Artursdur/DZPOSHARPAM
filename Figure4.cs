using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZPOSHARPAM
{
    internal class Figure4
    {
        public double GetS(double r, double h)
        {
            return 2 * 3.14 * r * (r + h);
        }
        public double GetS(double r)
        {
            return 4 * 3.14 * Math.Pow(r,2);
        }
    }
}
