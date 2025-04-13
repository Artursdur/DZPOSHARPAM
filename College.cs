using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZPOSHARPAM
{

    internal class College
    {
        private string _title;
      


        private int _auditoriesCount;

        public int StudentsCount { get; set; }
        public int TeachersCount { get; set; }


        public static bool operator <(College c1, College c2)
        {
            if (c1.StudentsCount == c2.StudentsCount)
                return c1._auditoriesCount < c2._auditoriesCount;
            return c1.StudentsCount < c2.StudentsCount;
        }

        public static bool operator >(College c1, College c2)
        {
            if (c1.StudentsCount == c2.StudentsCount)
                return c1._auditoriesCount > c2._auditoriesCount;
            return c1.StudentsCount > c2.StudentsCount;
        }       
    }
}
