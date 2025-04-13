using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZPOSHARPAM
{
    internal static class Admission
    {
        public static double _BALLvSHARAGY = 4.5;

        public static bool IsPassed(double score)
        {
            return score > _BALLvSHARAGY;
        }
    }
}
