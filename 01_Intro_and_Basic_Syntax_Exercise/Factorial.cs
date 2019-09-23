using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int res = 1;
            while (n != 1)
            {
                res = res * n;
                n = n - 1;
            }
            Console.WriteLine(res);
        }
    }
}
