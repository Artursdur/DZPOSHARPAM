using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZPOSHARPAM
{
    internal class Figure2
    {
        public double Volume(int r, int h)
        {
            return 3.14 * Math.Pow(r,2) * h;
        }
        public double Volume(int r)
        {
            return (4 / 3) * (3.14 * Math.Pow(r, 3));
        }
    }
}
