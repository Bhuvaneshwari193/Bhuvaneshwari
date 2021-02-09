using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasktue
{
    class sum
    {
        static void Main(string[] args)
        {
            int num = 123;
            int sum = 0;
            while (num > 0)
            {
                int Digit = num % 10;
                sum = sum + Digit;
                num = num / 10;
            }
            Console.WriteLine(sum);

        }
    }
}
