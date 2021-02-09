using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seperatevalues
{
    class seperatenumber
    {
        static void Main(string[] args)
        {


            int num = 123;
            while (num > 0)
            {
                int digit = num % 10;

                num = num / 10;
                Console.WriteLine(digit);

            }
        }
    }
}

