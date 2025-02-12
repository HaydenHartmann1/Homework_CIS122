/*
    Hayden Hartmann
    1/31/2025
    Simulas Test : And Practice
*/

namespace Simulas_Test_lvl_16
{
    public class Simulas_Test
    {
        public static void Main(string[] args)
        {
            // creating chest object from Chest enum
            Chest chest = Chest.Locked;
            //Locking, unlocking, and opening a chest
            while (true)
            {
                Console.Write($"The chest is {chest}, what would you like to do?: ");
                string answer = Console.ReadLine();
                if (answer == "unlock" && chest == Chest.Locked)
                {
                    chest = Chest.Unlocked;
                }
                else if (answer == "open" && chest == Chest.Unlocked)
                {
                    chest = Chest.Open;
                }
                else if (answer == "close" && chest == Chest.Open)
                {
                    chest = Chest.Unlocked;
                }
                else if (answer == "lock" && chest == Chest.Unlocked)
                {
                    chest = Chest.Locked;
                }
            }


            Console.ReadKey();
        }
        // creating an enum for Chest 
        enum Chest { Locked, Unlocked, Open };
    }
}







