using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZPOSHARPAM
{
    internal class Cat
    {
        private string _name;
        private string _poroda;
        private DateTime _birthDate;
        private double _weight;

        public double Weight { get; }

        public static bool operator <(Cat lsd, Cat rsd)
        {
            return lsd._weight < rsd._weight;
        }

        public static bool operator >(Cat lsd, Cat rsd)
        {
            return lsd._weight > rsd._weight;
        }

        public static string operator *(Cat lsd, Cat rsd)
        {
            if (lsd._poroda == rsd._poroda)
            {
                return "Селекция возможна";
            }
            return "Селекция невозможна";
        }
    }
}
