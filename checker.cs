using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_testing1
{
    internal class checker
    {
        public string check(int n)
        {
            if (n == 0){
                return "This is Zero";
            }
            else
            {
                return "This is not Zero";
            }

        }
    }
}
