/*
    Hayden Hartmann
    1/24/2025
    Buying Inventory & Discounted Inventory
*/


namespace Buying_Inventory_lvl10
{
    //class creation (Name is from original problem, Discounted Inventory is an add on)
    public class Buying_Inventory
    {
        //main method
        public static void Main(string[] args)
        {
            //shoping list menu
            Console.WriteLine("Shop List");
            Console.WriteLine("1 - Rope");
            Console.WriteLine("2 - Torches");
            Console.WriteLine("3 - Climbing Gear");
            Console.WriteLine("4 - Clean Water");
            Console.WriteLine("5 - Machete");
            Console.WriteLine("6 - Canoe");
            Console.WriteLine("7 - Food Supplies");

            //asks user for number, assigned to num
            Console.Write("What item would you like to see the price of (int): ");
            int num = Convert.ToInt32(Console.ReadLine());

            //asks user for their name, assigned to name
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();

            //declares variables and assigns discount to 1
            double price;
            double discount = 1;

            //if name is Hayden, then discount re-assigned to 0.5, giving half off discount
            if (name == "Hayden")
            {
                discount = 0.5;
            }

            //switch case to check num against each case. Corresponds with each item
            switch (num)
            {
                //if num == 1
                case 1:
                    //price is assigned to item cost * discount (will be 1 still if not Hayden)
                    price = 10 * discount;
                    //string interpolation to display
                    Console.WriteLine($"The price for Rope is {price}g");
                    //break statement to prevent every other case following this one to run
                    break;
                case 2:
                    price = 15 * discount;
                    Console.WriteLine($"The price for Torches is {price}g");
                    break;
                case 3:
                    price = 25 * discount;
                    Console.WriteLine($"The price for Climbing Gear is {price}g");
                    break;
                case 4:
                    price = 1 * discount;
                    Console.WriteLine($"The price for Clean Water is {price}g");
                    break;
                case 5:
                    price = 20 * discount;
                    Console.WriteLine($"The price for Machete is {price}g");
                    break;
                case 6:
                    price = 200 * discount;
                    Console.WriteLine($"The price for Canoe is {price}g");
                    break;
                case 7:
                    price = 1 * discount;
                    Console.WriteLine($"The price for Food Supplies is {price}g");
                    break;
            }


            Console.ReadKey();
        }
    }
}











