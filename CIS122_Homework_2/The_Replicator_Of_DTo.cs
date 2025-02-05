/*
    Hayden Hartmann
    1/24/2025
    The Replicator Of D'To: The C# Players Guide 
*/


namespace The_Replicator_Of_DTo_lvl_12
{
    //creates class
    public class The_Replicator_Of_DTo
    {
        //main method
        public static void Main(string[] args)
        {
            // creates empty array
            int[] _array = new int[5];

            //user input is read and assigned to array tokens
            Console.Write("Enter five numbers all with spaces: ");
            string[] tokens = Console.ReadLine().Split(" ");

            //tokens are converted and inserted into _array
            int count = 0;
            foreach(string token in tokens)
            {
                _array[count] = Convert.ToInt32(token);

                //count keeps track of position token should be assigned to
                count++;
            }

            //creates empty array
            int[] new_array = new int[5];

            //cycles through _array this time and adds the tokens to new_array in position[count]
            count = 0;
            foreach(int token in _array)
            {
                new_array[count] = token;
                count++;
            }

            //these two loops print both arrays
            Console.Write("_array: ");
            foreach(int num in _array)
            {
                Console.Write(num);
            }
            Console.WriteLine();
            Console.Write("new_array: ");
            foreach (int num in new_array)
            {
                Console.Write(num);
            }

            Console.ReadLine();
        }
    }
}







