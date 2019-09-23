using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());// четем конзолата
           
            List<int> longitude = new List<int>();
            int singleNum = 0;
            int sum = 0;
            int result = 1;// факториел на цифрата (number)

            do
            {
                singleNum = number % 10;
                number = number / 10;
                longitude.Add(singleNum);
                              
            } 
            while (Math.Abs(number) > 1);

            for (int index = 0; index < longitude.Count; index++)
            {
                result = 1;
                number = longitude[index];
                while (number != 1)
                {
                    result = result * number;
                    number = number - 1;
                 }
                sum = sum + result;
            }
            
            Console.WriteLine(sum);
        }
    }
}
