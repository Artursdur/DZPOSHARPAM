using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZPOSHARPAM
{
    internal class CatWeightStandart
    {
        public static double SmallWeight { get; set; } = 1; 
        public static double MediumWeight { get; set; } = 3; 
        public static double LargeWeight { get; set; } = 5;

        public static void CheckWeight(Cat cat)
        {
            if (cat.Weight < SmallWeight)
            {
                Console.WriteLine("Котик очень худой");
            }
            if (cat.Weight < MediumWeight)
            {
                Console.WriteLine("Котик худой");
            }
            if (cat.Weight < LargeWeight)
            {
                Console.WriteLine("Котик полноват");
            }
            Console.WriteLine("Котик полный");
        }
    }
}
