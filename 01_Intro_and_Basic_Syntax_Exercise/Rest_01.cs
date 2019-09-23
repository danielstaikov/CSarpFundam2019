using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest_01
{
    class Rest_01
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int singleNum = 0;
            singleNum = number % 10;
            Console.WriteLine(singleNum);
        }
    }
}
