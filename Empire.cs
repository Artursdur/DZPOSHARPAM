using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZPOSHARPAM
{
    internal class Empire
    {
        public static int s_population = 300000;
        public static double s_area = 900000;

        public static void CheckEmpire(Gosudarstvo country)
        {
            if (country.Population >= s_population && country.Area >= s_area)
            {
                Console.WriteLine("Это государство – империя"); 
            }
            Console.WriteLine("Это государство не империя");
        }
    }

}
}
