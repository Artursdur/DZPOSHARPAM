using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZPOSHARPAM
{
    internal class Figure1
    {
        public double Volume(int a)
        {
            return Math.Pow(a, 3);
        }
        public double Volume(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}
