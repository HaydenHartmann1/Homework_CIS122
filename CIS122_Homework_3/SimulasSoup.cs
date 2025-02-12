/*
    Hayden Hartmann
    1/31/2025
    Simulas Soup : And Practice
*/

public class SimulasSoup
{
    public static void Main(string[] args)
    {

        /*
         var names = ("hayden", 1, 1.24332, '&');

        (string Name, int Number, int DNumber) values = ("Hayden", 13, 1);
        DisplayScore(values);
        var vals = (Name: "Hayden", Number: 5, DNumber: 5.55);


        void DisplayScore((string Name, int Points, int Level) score)
        {
            Console.WriteLine(score.Name);
            Console.WriteLine(score.Points);
            Console.WriteLine(score.Level);
        }

        (string Name, int Num1, int Num2) GameScore()
        {
            return ("Hayden", 5, 14);
        }
        Console.WriteLine(GameScore());

        (string, int, int)[] Testing()
        {
            return new (string, int, int)[3]
            {
                ("hayden", 1, 2),
                ("asd", 5, 1),
                ("asf", 3, 0)
            };
        }
        Console.WriteLine(Testing());


        var score = (3, "hello", 4.55);
        (string Name, int Number) svc = ("Hayden", 5);

        (string, int, int)[] Scores()
        {
            return new (string, int ,int)[3]
            { 
                ("g", 2, 3), 
                ("as", 4, 1), 
                ("asc", 6, 7)
            };
        }

        int x = 4;
        int y = 3;
        (x, y) = (y, x);
        Console.WriteLine(x);
*/


        Console.WriteLine($"{"Menu", 10}");
        Console.WriteLine("---------------------");

        Console.Write("Type: ");
        foreach (Type type in Enum.GetValues(typeof(Type)))
        {
            Console.Write(type + "  ");
        }
        Console.WriteLine();

        Console.Write("Main Ingrediant: ");
        foreach (MainIngrediant mainIngrediant in Enum.GetValues(typeof(MainIngrediant)))
        {
            Console.Write(mainIngrediant + "  ");
        }
        Console.WriteLine();

        Console.Write("Seasoning: ");
        foreach (Seasoning seasoning in Enum.GetValues(typeof(Seasoning)))
        {
            Console.Write(seasoning + "  ");
        }
        Console.WriteLine();

        Console.WriteLine("Im not finishing this lol :) ");


        Console.ReadKey();
    }
    enum Type { Soup, Stew, Gumbo };
    enum MainIngrediant { Mushrooms, Chicken, Carrots, Potatoes };
    enum Seasoning { Spicy, Salty, Sweet };
}





