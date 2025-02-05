/*
    Hayden Hartmann
    2/5/2025
    The Magic Cannon
*/

//creates class
public class TheMagicCannon
{
    //class main method
    public static void Main(string[] args)
    {
        //loops through the numbers 1-100
        for (int i = 1; i <= 100; i++)
        {
            //every 3rd and 5th crank line up
            if (i % 3 == 0 && i % 5 == 0)
            {
                //changes background color before displaying the result using string interpolation
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{i}: Electric and Fire");
            }
            //every 5th crank
            else if (i % 5 == 0)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{i}: Electric");
            }
            //every 3rd crank
            else if (i % 3 == 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"{i}: Fire");
            }
            //all subsequent cranks
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine($"{i}: Normal");
            }
        }

        Console.ReadKey();
    }
}




