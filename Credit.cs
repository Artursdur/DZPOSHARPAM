using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZPOSHARPAM
{
    internal class Credit
    {
        public string _fio;
        public double _money;
        public static double _procent;

        public static Credit operator-(Credit lsd)
        {
            lsd._money -= lsd._money / 100 * _procent;
            return lsd;
        }
        
        public static double GetProcent()
        {
            return _procent; 
        }
    }
}
