using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZPOSHARPAM
{
    static internal class MiniPrice
    {
        public static double SmallPrice = 100;
        public static double MediumPrice = 500;
        public static double LargePrice = 1500;

        public static void CheckPrice(Ingredient ingredient)
        {
            if (ingredient.Price < SmallPrice)
            {
                Console.WriteLine("Цена очень низкая");
            }
            if (ingredient.Price < MediumPrice)
            {
                Console.WriteLine("Цена низкая");
            }
            if (ingredient.Price < LargePrice)
            {
                Console.WriteLine( "Цена завышена");
            }
            Console.WriteLine("Цена слишком высокая");
        }
    }
}
