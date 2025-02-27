/*
    Hayden Hartmann
    2/26/2025
    This file contains vehicle and sub classes 
*/

public class Vehicle
{
    protected string _make = "n/a";
    protected string _model = "n/a";
    protected int _year = 0;

    public Vehicle(string make, string model, int year)
    {
        _make = make;
        _model = model;
        _year = year;
    }

    public string Make
    {
        get => _make;
        set => _make = value;
    }
    public string Model
    {
        get => _model;
        set => _model = value;
    }
    public int Year
    {
        get => _year;
        set => _year = value;
    }

    public override string ToString()
    {
        string message = $"Year: {_year}\nMake: {_make}\nModel: {_model}";
        return message;
    }

}

public class Car : Vehicle
{
    private int _numOfDoors;

    public Car(int numOfDoors, string make, string model, int year) : base(make, model, year)
    {
        _numOfDoors = numOfDoors;
    }

    public override string ToString()
    {
        string message = $"Year: {_year}\nMake: {_make}\nModel: {_model}\nwith {_numOfDoors} doors";
        return message;
    }
}

public class Motorcycle : Vehicle
{
    private bool _hasSideCar;

    public Motorcycle(bool hasSideCar, string make, string model, int year) : base(make, model, year)
    {
        _hasSideCar = hasSideCar;
    }

    public override string ToString()
    {
        string message = $"Year: {_year}\nMake: {_make}\nModel: {_model}\n(Has Sidecar) {_hasSideCar}";
        return message;
    }
}