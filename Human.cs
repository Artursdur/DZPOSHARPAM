using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZPOSHARPAM
{
    internal class Human
    {
        private string _fullName;
        private string _pol;
        private string _eyeColor;

        public int Age { get; set; }

       
        public static string operator +(Human lsd, Human rsd)
        {
            if (lsd._eyeColor == "Карие" || rsd._eyeColor == "Карие")
                return "Карие";
            if (lsd._eyeColor == "Зеленые" && rsd._eyeColor == "Зеленые")
                return "Зеленые";
            if (lsd._eyeColor == "Голубые" && rsd._eyeColor == "Голубые")
                return "Голубые";
            return "Зеленые";
        }
    }
}
