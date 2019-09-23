using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string categoryPeople = Console.ReadLine(); //Students, Business, Regular
            string visitDay = Console.ReadLine(); //Friday, Saturday, Sunday
            double totalPrice = 0;

            if (categoryPeople == "Students")
            {
                double dayPay = 0;
                if (visitDay == "Friday")
                {
                    dayPay = 8.45;
                }
                else if (visitDay == "Saturday")
                {
                    dayPay = 9.80;
                }
                else //Sunday
                {
                    dayPay = 10.46;
                }
                if (people >= 30)
                {
                    totalPrice = people * dayPay * 0.85;
                }
                else
                {
                    totalPrice = people * dayPay;
                }                  
            }

            else if (categoryPeople == "Business")
            {
                double dayPay = 0;
                if (visitDay == "Friday")
                {
                    dayPay = 10.90;
                }
                else if (visitDay == "Saturday")
                {
                    dayPay = 15.60;
                }
                else //Sunday
                {
                    dayPay = 16;
                }
                if (people >= 100)
                {
                    totalPrice = people * 0.9 * dayPay;
                }
                else
                {
                    totalPrice = people * dayPay;
                }
            }

            else //Regular
            {
                double dayPay = 0;
                if (visitDay == "Friday")
                {
                    dayPay = 15;
                }
                else if (visitDay == "Saturday")
                {
                    dayPay = 20;
                }
                else //Sunday
                {
                    dayPay = 22.50;
                }

                if ((people >= 10) && (people <=20))
                {
                    totalPrice = people * dayPay * 0.95;
                }
                else
                {
                    totalPrice = people * dayPay;
                }
            }

            Console.WriteLine("Total price: {0:f2}", totalPrice); 
        }
    }
}
