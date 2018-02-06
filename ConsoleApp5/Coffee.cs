using System;

namespace ConsoleApp5
{
    public class Coffee
    {
        public string Name;
        public string Currency;
        public double Price;
        public int Energy;
        public static bool firstTime = true;

        public Coffee()
        {
            Currency = " euros";
        }

        public static bool BuyCoffee()
        {
            string userInput = "";
            if (firstTime == true)
            {
                Console.WriteLine("Which coffee do you want? (Black coffee/Coffee with milk/Cappuccino/Latte/Americano/Espresso)");
            }
            else if(firstTime == false)
            {
                Console.WriteLine("This is not an option, please try again. (Black coffee/Coffee with milk/Cappuccino/Latte/Americano/Espresso)");
            }
            firstTime = true;
            userInput = Console.ReadLine();
            Console.Clear();

            //Coffee types
            if (userInput == "Black coffee")
            {
                var BlackCoffee = new BlackCoffee();
                BlackCoffee.afterPurchase();
            }
            else if (userInput == "Coffee with milk")
            {
                var CoffeeWithMilk = new CoffeeWithMilk();
                CoffeeWithMilk.afterPurchase();
            }
            else if (userInput == "Cappuccino")
            {
                var Cappuccino = new Cappuccino();
                Cappuccino.afterPurchase();
            }
            else if (userInput == "Latte")
            {
                var Latte = new Latte();
                Latte.afterPurchase();
            }
            else if (userInput == "Americano")
            {
                var Americano = new Americano();
                Americano.afterPurchase();
            }
            else if (userInput == "Espresso")
            {
                var Espresso = new Espresso();
                Espresso.afterPurchase();
            }
            else
            {
                firstTime = false;
                BuyCoffee();
            }
            Console.WriteLine("Do you wish to continue? (yes/no)");
            userInput = Console.ReadLine();
            Console.Clear();
            if (userInput == "yes")
            {
                return true;
            }
            else
            {
                Environment.Exit(0);
            }
            return false;
        }

        public void afterPurchase()
        {
            Console.WriteLine(Name + " cost you " + Price + Currency + " and gave you "
                    + Energy + " energy.");
        }
    }
}
