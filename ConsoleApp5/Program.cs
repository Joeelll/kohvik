using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            int usersEnergy = 0;
            bool firstTime = true;
            //var vastus = Shop(userInput, firstTime);
            Shop(userInput, firstTime);
        }

        public static void Shop(string userInput, bool firstTime)
        {
            while (true)
            {
                if (firstTime == true)
                {
                    Console.WriteLine("What do you want to buy? (Coffee/Bakery/Sandwiches/Salads)");
                }
                else if (firstTime == false)
                {
                    Console.WriteLine("This is not an option, please try again. (Coffee/Bakery/Sandwiches/Salads)");
                }

                userInput = Console.ReadLine();
                Console.Clear();
                if (userInput == "Coffee")
                {                   
                    Coffee.BuyCoffee();
                }
                else if (userInput == "Food")
                {
                }
                else
                {
                    firstTime = false;
                    Shop(userInput, firstTime);
                }
            }
        }
    }
}
