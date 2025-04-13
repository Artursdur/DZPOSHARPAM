using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DZPOSHARPAM
{
    internal class Nums7
    {
        public int MaxNum(int a, int b) => a > b ? a : b;
        
        public int MaxNum(int a, int b, int c)
        {
           int max = new[] { a, b, c }.Max();
            return max;
        }
        public int MaxNum(int a, int b, int c, int d)
        {
            int max = new[] { a, b, c, d }.Max();
            return max;
        }
        public int MaxNum(int a, int b, int c, int d, int e)
        {
            int max = new[] { a, b, c, d, e }.Max();
            return max;
        }
    }
}
