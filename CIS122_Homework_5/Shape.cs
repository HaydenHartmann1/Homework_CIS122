/*
    Hayden Hartmann
    2/26/2025
    This file contains Shape and sub classes 
*/

using System.Drawing;

public abstract class Shape
{
    protected string _color = "n/a";

    public Shape(string color)
    {
        _color = color;
    }

    public string Color
    {
        get => _color;
        set => _color = value;
    }

    public abstract double GetArea();

    public override string ToString()
    {
        string message = $"Color: {_color}, Shape: X";
        return message;
    }
}

public class Rectangle : Shape
{
    private double _width = -1.0;
    private double _height = -1.0;

    public Rectangle(double width, double height, string color) : base(color)
    {
        _width = width;
        _height = height;
    }

    public override double GetArea()
    {
        return _width * _height;
    }

    public override string ToString()
    {
        string message = $"Rectangle, Color: {_color}, Height: {_height}, Width: {_width}, Area: {GetArea()}";
        return message;
    }
}

public class Circle : Shape
{
    private double _radius = -1.0;

    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }

    public override string ToString()
    {
        string message = $"Circle, Color: {_color}, Radius: {_radius}, Area: {GetArea()}";
        return message;
    }
}