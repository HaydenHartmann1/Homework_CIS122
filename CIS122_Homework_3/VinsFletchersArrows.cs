/*
    Hayden Hartmann
    2/1/2025
    Vin Fletchers Arrows lvl 18/19/20/21
*/


namespace Vin_Fletchers_Arrows_lvl_18
{
    public class VinFletchersArrows
    {
        public static void Main(string[] args)
        {
            //creating a menu for user
            Console.Title = "The Arrow Menu";
            Console.WriteLine("                              Arrow Menu");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Arrowhead:    Steel = 10g    Wood = 3g    Obsidian = 5g");
            Console.WriteLine("Fletching:    Plastic = 10g    TurkeyFeathers = 5g    GooseFeathers = 3g");
            Console.WriteLine("Shaft length cost per cm = 0.05g");
            Console.WriteLine("-------------------------------------------------------------------------");

            //user input
            Console.Write("Which Arrowhead would you like: ");
            string userInput1 = Console.ReadLine();

            //user input
            Console.Write("Which Fletching would you like: ");
            string userInput2 = Console.ReadLine();

            //user input
            Console.Write("What length would you like: ");
            float shaft = Convert.ToSingle(Console.ReadLine());

            //sets bool for later use and calls methods to set values
            bool isValid = true;
            Arrowhead arrowhead = FindArrowhead(userInput1);
            Fletching fletching = FindFletching(userInput2);

            
            Console.WriteLine($"The arrow will cost {Arrows.EliteArrow().GetCost():F2}");
            Console.WriteLine($"The arrow will cost {Arrows.BeginnerArrow().GetCost():F2}");
            Console.WriteLine($"The arrow will cost {Arrows.MarksmanArrow().GetCost():F2}");

            //sets arrowhead value
            Arrowhead FindArrowhead(string input)
            {
                if (input == "Steel")
                {
                    return Arrowhead.Steel;
                }
                else if (input == "Wood")
                {
                    return Arrowhead.Wood;
                }
                else if (input == "Obsidian")
                {
                    return Arrowhead.Obsidian;
                }
                else
                {
                    Console.WriteLine("Not a valid choice");
                    isValid = false;
                    return Arrowhead.Steel;
                }
            }

            //sets fletching value
            Fletching FindFletching(string input)
            {
                if (input == "Plastic")
                {
                    return Fletching.Plastic;
                }
                else if (input == "TurkeyFeathers")
                {
                    return Fletching.TurkeyFeathers;
                }
                else if (input == "GooseFeathers")
                {
                    return Fletching.GooseFeathers;
                }
                else
                {
                    Console.WriteLine("Not a valid choice");
                    isValid = false;
                    return Fletching.Plastic;
                }
            }
            
            //if a value was not valid, bool will be false
            if (isValid == true)
            {
                //creates instance of Arrows and uses method
                Arrows arrow = new Arrows { Arrowhead = arrowhead, Fletching = fletching, Shaft = shaft };
                Console.WriteLine($"The arrow will cost {arrow.GetCost():F2}");
            }
            else
            {
                Console.WriteLine("One of the fields you entered was not valid");
            }

            Console.ReadKey();
        }
    }
    //declaring enumerations
    public enum Arrowhead { Steel = 10, Wood = 3, Obsidian = 5};
    public enum Fletching { Plastic = 10, TurkeyFeathers = 5, GooseFeathers = 3};

    //arrow class
    public class Arrows
    {
        //private instance variables
        public Arrowhead Arrowhead { get; set; } = 0;
        public Fletching Fletching { get; set; } = 0;
        public float Shaft { get; set; } = 0;

        /*
        //constructor
        public Arrows(Arrowhead arrowhead, Fletching fletching, float shaft)
        {

            _shaft = shaft;
            _arrowhead = arrowhead;
            _fletching = fletching;

        }
        */

        //method to get total cost of arrow
        public float GetCost() => ((Shaft * 0.05f) + (float)Arrowhead + (float)Fletching);

        public static Arrows EliteArrow()
        {
            Arrows arrow = new Arrows { Arrowhead = Arrowhead.Steel, Fletching = Fletching.Plastic, Shaft = 95 };
            return arrow;
        }

        public static Arrows BeginnerArrow()
        {
            Arrows arrow = new Arrows { Arrowhead = Arrowhead.Wood, Fletching = Fletching.GooseFeathers, Shaft = 75 };
            return arrow;
        }

        public static Arrows MarksmanArrow()
        {
            Arrows arrow = new Arrows { Arrowhead = Arrowhead.Steel, Fletching = Fletching.GooseFeathers, Shaft = 65 };
            return arrow;
        }

        /*
        //getters and setters
        public Arrowhead _Arrowhead
        {
            get => _arrowhead;
            set => _arrowhead = value;
        }
        public Fletching _Fletching
        {
            get => _fletching;
            set => _fletching = value;
        }
        public float _Shaft
        {
            get => _shaft;
            set => _shaft = value;
        }
        */
    }
    
}





