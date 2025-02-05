/*
    Hayden Hartmann
    1/24/2025
    Watchtower: The C# Players Guide
*/

namespace Watchtower_lvl_9
{
    //class creation
    public class Watchtower
    {
        //main method
        public static void Main(string[] args)
        {
            //asks user for int input, converted to in and assigned to x
            Console.Write("Enter x val: ");
            int x = Convert.ToInt32(Console.ReadLine());

            //asks user for int input, converted to in and assigned to y
            Console.Write("Enter y val: ");
            int y = Convert.ToInt32(Console.ReadLine());

            //large if if else statement to determin x and y values and then display location of enemy
            //if x is equal to 0 then run this
            if (x == 0)
            {
                //if y is equal to 0 then run this
                if (y == 0)
                {
                    Console.WriteLine("The enemy is here!");
                }
                //if y is greater than 0 then run this
                else if (y > 0)
                {
                    Console.WriteLine("The enemy is to the North!");
                }
                //could have just made else statement but kept for clearity
                if (y < 0)
                {
                    Console.WriteLine("The enemy is to the South!");
                }
            }
            //else if x is greater than 0 run this  (and so on)
            else if (x > 0)
            {
                if (y == 0)
                {
                    Console.WriteLine("The enemy is to the East!");
                }
                else if (y > 0)
                {
                    Console.WriteLine("The enemy is to the North Eeast!");
                }
                else if (y < 0)
                {
                    Console.WriteLine("The enemy is to the South East!");
                }
            }
            else if (x < 0)
            {
                if (y == 0)
                {
                    Console.WriteLine("The enemy is to the West!");
                }
                if (y > 0)
                {
                    Console.WriteLine("The enemy is to the North West!");
                }
                if (y < 0)
                {
                    Console.WriteLine("The enemy is to the South West!");
                }
            }

            Console.ReadKey();
        }
    }
}

