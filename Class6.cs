using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasktue
{
    class countnumbers
    {
        static void Main(string[] args)
        {
            int num = 234567;
             int count = 0;
             
            while( num > 0)
            {
                int result = num % 10;
                count++;

                num = num / 10;



            }
            Console.WriteLine(count);


        }
    }
}
