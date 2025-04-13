using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZPOSHARPAM
{
    internal class Gosudarstvo
    {
        private string _name;
        
        public double Area { get; set; }   
        public int Population { get; set; }

        public static Gosudarstvo operator +(Gosudarstvo s1, Gosudarstvo s2)
        {
            Gosudarstvo res = new Gosudarstvo();
            res._name = s1._name;
            res.Population = s1.Population + s2.Population;
            res.Area = s1.Area + s2.Area;
            return res;
        }

        public static bool operator <(Gosudarstvo s1, Gosudarstvo s2)
        {
            if (s1.Population == s2.Population)
            {
                return s1.Area < s2.Area;
            }   
            return s1.Population < s2.Population;
        }

        public static bool operator >(Gosudarstvo s1, Gosudarstvo s2)
        {
            if (s1.Population == s2.Population)
            {
                return s1.Area > s2.Area;
            }
            return s1.Population > s2.Population;
        }
    }
}
