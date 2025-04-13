using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZPOSHARPAM
{
    internal class Vklad
    {
        public string _fio;
        public double _money;
        public static double procent = 10.5;


        public static Vklad operator++ (Vklad lsd)
        {
            lsd._money += lsd._money / 100 * procent;
            return lsd;
        }
    }
}
