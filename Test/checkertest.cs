using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_testing1.Test
{
    public class checkertest
    {
       
        //naming conviction:classname_methodname_returntype
        public void checker_check_ReturnString()
        {
            try
            {
                //arrange-gather resources
                checker checker = new checker();
                int n = 1;

                //act-what action will we want
                //method execution
                string result = checker.check(n);

                //assertion-pass/fail
                if (result == "This is Zero")
                {
                    Console.WriteLine("test passed:checker_check_ReturnString");
                }
                else
                {
                    Console.WriteLine("tast failed:checker_check_ReturnString");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
