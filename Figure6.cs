using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZPOSHARPAM
{
    internal class Figure6
    {
        public double GetP(double a)
        {
            return a * 4;
        }
        public double GetP(double a, double b)
        {
            return 2 * (a + b);
        }
        public double GetP(double a, double b, double c)
        {
            return a + b + c;
        }
        public double GetP(double a, double b, double d)
        {
            return a + b + 2 * d;
        }
    }
}
