using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Login
{
    class Login
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string logIn = Console.ReadLine();
            // Incorrect password. Try again.
            // User {username} logged in.
            // User {username} blocked!
            int conter = 1;
            string reversedUsername = new string(username.Reverse().ToArray());
            while (reversedUsername != logIn || conter >= 4)
            {
                                
                conter++;
                if (conter >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                logIn = Console.ReadLine();
            }
            if (reversedUsername == logIn)
                {
                Console.WriteLine($"User {username} logged in.");
                }
            
         }

     }
}
