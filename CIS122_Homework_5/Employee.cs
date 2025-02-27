/*
    Hayden Hartmann
    2/26/2025
    This file contains Employee and sub classes 
*/

public class Employee
{
    protected string _name = "n/a";
    protected double _salary = -10.0;

    public Employee(string name, double salary)
    {
        _name = name;
        _salary = salary;
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }
    public double Salary
    {
        get => _salary;
        set => _salary = value;
    }

    public override string ToString()
    {
        string message = $"Employee: {_name} Salary: ${_salary}";
        return message;
    }

}

public class Manager : Employee
{
    private int _numberOfEmployeesManaged = -1;

    public Manager(int numberOfEmployeesManaged, string name, double salary) : base(name, salary)
    {
        _numberOfEmployeesManaged = numberOfEmployeesManaged;
    }

    public override string ToString()
    {
        string message = $"Employee: {_name} Salary: ${_salary}: Employees Managed: {_numberOfEmployeesManaged}";
        return message;
    }

}

public class Engineer : Employee
{
    private string _specalization = "n/a";

    public Engineer(string specalization, string name, double salary) : base(name, salary)
    {
        _specalization = specalization;
    }

    public override string ToString()
    {
        string message = $"Employee: {_name} Salary: ${_salary}: Specalization: {_specalization}";
        return message;
    }

}