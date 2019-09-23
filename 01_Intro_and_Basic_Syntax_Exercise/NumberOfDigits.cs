using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfDigits
{
    class NumberOfDigits
    {
        static void Main(string[] args)
        {
            long i = 0;
            double n;
            Console.Write("N? ");
            n = Convert.ToInt64(Console.ReadLine());

            do
            {
                n = n / 10;
                i++;
            }
            while (Math.Abs(n) > 1);
            Console.WriteLine(i);
        }
    }
}
