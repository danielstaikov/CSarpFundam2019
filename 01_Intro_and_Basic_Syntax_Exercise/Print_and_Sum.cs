using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Print_and_Sum
{
    class Print_and_Sum
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = startNum; i <= endNum; i++ )
                {
                sum = sum + i;
                Console.Write($"{i} ");
                 }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
