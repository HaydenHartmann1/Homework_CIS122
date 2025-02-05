/*
    Hayden Hartmann
    1/24/2025
    The Prototype: The C# Players Guide
*/


namespace The_Prototype_lvl_11
{
    //class creation
    public class The_Portotype
    {
        //creates main
        public static void Main(string[] args)
        {
            //asks pilot for num to convert to int
            Console.Write("Pilot pick number 1-100: ");
            int pilot = Convert.ToInt32(Console.ReadLine());

            //loops till hunter == pilot
            while (true)
            {
                //hunter enters number, converts to int, and is then run through if else block to test value
                Console.Write("Hunter pick number 1-100: ");
                int hunter = Convert.ToInt32(Console.ReadLine());
                if (hunter > pilot)
                {
                    Console.WriteLine("Too high");
                }
                else if (hunter < pilot)
                {
                    Console.WriteLine("Too low");
                }
                else
                {
                    //loop only ends when hunter == pilot, break statement used
                    Console.WriteLine("Correct! Ships position is: "+pilot);
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}



