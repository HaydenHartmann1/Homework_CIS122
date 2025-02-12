/*
    Hayden Hartmann
    1/29/2025
    Hunting The Manticore : And Practice
*/

namespace Hunting_The_Manticore_lvl_14
{
    public class BossBattle
    {
        public static void Main(string[] args)
        {
            Console.Write("Player 1, how far away would you like to station the Manticore?: ");
            int manticorePosition = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            string seperator = "----------------------------------------";
            int cityHealth = 15;
            int manticoreHealth = 10;
            int round = 1;
            int cannonRange;

            Console.WriteLine("Player 2, it is your turn.");
            Console.WriteLine(seperator);

            while (true)
            {
                Console.WriteLine($"STATUS: Round: {round}  City: {cityHealth}/15  Manticore: {manticoreHealth}/10");

                int cannonDamage = 1;
                if (round % 3 == 0 && round % 5 == 0)
                {
                    cannonDamage = 10;
                }
                else if (round % 3 == 0 || round % 5 == 0)
                {
                    cannonDamage = 3;
                }

                Console.WriteLine($"The cannon is expected to deal {cannonDamage} damage this round.");
                Console.Write("Enter desired cannon range: ");
                cannonRange = Convert.ToInt32(Console.ReadLine());
                if (cannonRange > manticorePosition)
                {
                    Console.WriteLine("That round OVERSHOT the target.");
                }
                else if (cannonRange < manticorePosition)
                {
                    Console.WriteLine("That round FELL SHORT of the target.");
                }
                else
                {
                    Console.WriteLine("That round was a DIRECT HIT!");
                    manticoreHealth -= cannonDamage;
                }
                cityHealth--;
                round++;

                if (manticoreHealth <= 0)
                {
                    Console.WriteLine("The manticore has been destroyed! The city of Consolas has been saved!");
                    break;
                }
                else if (cityHealth <= 0)
                {
                    Console.WriteLine("The city has been destroyed...");
                    break;
                }
                Console.WriteLine(seperator);
            }


            Console.ReadKey();
        }
    }
}








