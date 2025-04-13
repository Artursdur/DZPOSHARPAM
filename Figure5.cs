using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZPOSHARPAM
{
    internal class Figure5
    {
        public double GetS(double a)
        {
            return a * a;
        }
        public double GetS(int a, int b)
        {
            return a * b;
        }
        public double GetS(double a, double b)
        {
            return a * b / 2;
        }
        public double GetS(double a, double b, double h)
        {
            return (a + b) * h / 2;
        }
    }
}
