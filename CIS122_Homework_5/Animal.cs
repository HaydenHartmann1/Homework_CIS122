/*
    Hayden Hartmann
    2/26/2025
    This file contains Animal and sub classes 
*/

public class Animal
{
    protected string _name = "n/a";

    public Animal(string name)
    {
        _name = name;
    }
    public virtual string MakeSound()
    {
        return $"Some generic animal sound";
    }
    public override string ToString()
    {
        return $"Animal: {_name}, Sound: {MakeSound()}";
    }
}
public class Dog : Animal
{
    public Dog(string name) : base(name)
    {

    }
    public override string MakeSound()
    {
        return "Bark";
    }
}

public class Cat : Animal
{
    public Cat(string name) : base(name)
    {

    }
    public override string MakeSound()
    {
        return "Meow";
    }
}