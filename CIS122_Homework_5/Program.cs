/*
    Hayden Hartmann 
    2/26/2025
    Homework 5
*/


public class MyMain
{
    public static void Main(string[] args)
    {

        Car car1 = new Car(4, "Ford", "Ranger", 2015);
        Motorcycle motorcycle1 = new Motorcycle(true, "cool bike", "awsome bike", 2055);

        Console.WriteLine(car1);
        Console.WriteLine();
        Console.WriteLine(motorcycle1);
        Console.WriteLine();

        Manager manager1 = new Manager(5, "Bob", 123.456);
        Engineer engineer1 = new Engineer("Bubbles", "Jimmy", 12.23);

        Console.WriteLine(manager1);
        Console.WriteLine();
        Console.WriteLine(engineer1);
        Console.WriteLine();

        Circle circle1 = new Circle(5.5, "blue");
        Rectangle rectangle1 = new Rectangle(5.5, 3.4, "red");

        Console.WriteLine(circle1);
        Console.WriteLine();
        Console.WriteLine(rectangle1);
        Console.WriteLine();

        Dog dog1 = new Dog("Fred");
        Cat cat1 = new Cat("Cit");

        Console.WriteLine(dog1);
        Console.WriteLine();
        Console.WriteLine(cat1);
        Console.WriteLine();

        Ebook ebook1 = new Ebook("123", "Hayden", "buba", "2015");
        Printedbook printedbook1 = new Printedbook("111", "Ha12n", "bub2212a", "215");

        Console.WriteLine(ebook1);
        Console.WriteLine();
        Console.WriteLine(printedbook1);
        Console.WriteLine();

        Console.ReadKey();
    }
}