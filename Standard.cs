using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZPOSHARPAM
{
    internal class Standard
    {
        public static int MinStudents = 100;
        public static int MinTeachers = 10;

        public static bool CheckStandards(College college)
        {
            return college.StudentsCount >= MinStudents && college.TeachersCount >= MinTeachers;
        }
    }
}
