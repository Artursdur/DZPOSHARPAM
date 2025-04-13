using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZPOSHARPAM
{
    internal class Applicant
    {
        private string _fio;
        private double _avgBALL;
        private int _SigmoBall;
        private int _DateofPODACHA;

       public static bool operator < (Applicant lsd, Applicant rsd)
        {
            if (lsd._avgBALL != rsd._avgBALL)
            {
                return lsd._avgBALL < rsd._avgBALL;
            }
                return lsd._SigmoBall < rsd._SigmoBall;
        }

        public static bool operator >(Applicant lsd, Applicant rsd)
        {
            if (lsd._avgBALL != rsd._avgBALL)
            {
                return lsd._avgBALL > rsd._avgBALL;
            }
            return lsd._SigmoBall > rsd._SigmoBall;
        }
    }
}
