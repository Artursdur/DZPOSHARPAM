using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZPOSHARPAM
{
    internal class Arrays
    {
        public int GetMid(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return sum / arr.Length;
        }
        public double GetMid(double[] arr)
        {
            double sum = 0;
            foreach (double d in arr)
            {
                sum += d;
            }
            return sum / arr.Length;
        }
    }
}
