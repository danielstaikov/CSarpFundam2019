using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Intro_and_Basic_Syntax_Exercise
{
    class Ages
    {
        static void Main(string[] args)
        {
            //0-2 – baby; 
            //3 - 13 – child; 
            //14 - 19 – teenager;
            //20 - 65 – adult;
            //>= 66 – elder;
            int Ages = int.Parse(Console.ReadLine());
            if (Ages >= 0 && Ages < 3)
            {
                Console.WriteLine("baby");
            }
            else if (Ages < 14)
            {
                Console.WriteLine("child");
            }
            else if (Ages < 20)
            {
                Console.WriteLine("teenager");
            }
            else if (Ages < 66)
            {
                Console.WriteLine("adult");
            }
            else
            {
                Console.WriteLine("elder");
            }
        }
    }
}
