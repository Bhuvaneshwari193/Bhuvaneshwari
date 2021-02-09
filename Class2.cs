using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasktue
{
    class reversenumber
    {
        static void Main(string[] args)
        {

     
        int num = 234567;
        int rev = 0;
            while (num>0)
            {
                    int result = num % 10;
                    rev= rev*10+result;
                    num /= 10;
               
            }

             Console.WriteLine($"{rev} : ");
        }
    }
}
