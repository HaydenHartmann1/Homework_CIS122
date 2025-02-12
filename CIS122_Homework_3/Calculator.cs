
/*
    Hayden Hartmann
    2/12/2025
    1.) and 2.) Homework Problems
*/

using System.Diagnostics.CodeAnalysis;

public class MyMain
{
    public static void Main(string[] args)
    {
        List<int> nums = new List<int> { 1, 2, 3 , 4, 5};
        Calculator calculator = new Calculator();

        Console.WriteLine(calculator.FindMax(nums));
        Console.WriteLine(calculator.FindMin(nums));
        Console.WriteLine(calculator.FindAverage(nums));
        Console.WriteLine(calculator.FindMinMax(nums)[0] + " " + calculator.FindMinMax(nums)[1]);
        Console.WriteLine(calculator.FindSum(nums));

        Console.ReadKey();
    }
}
public class Calculator
{
    public int FindMin(List<int> aList)
    {
        int min = aList[0];

        foreach (int i in aList)
        {
            if (i < min)
            {
                min = i;
            }
        }

        return min;
    }

    public int FindMax(List<int> aList)
    {
        int max = aList[0];

        foreach (int i in aList)
        {
            if (i > max)
            {
                max = i;
            }
        }

        return max;
    }

    public int FindAverage(List<int> aList)
    {
        int avg = 0;
        int sum = 0;

        foreach (int i in aList)
        {
            sum += i;
        }
        avg = sum / aList.Count;

        return avg;
    }

    public List<int> FindMinMax(List<int> aList)
    {
        int min = FindMin(aList);
        int max = FindMax(aList);

        List<int> minMax = new List<int>();
        minMax.Add(min);
        minMax.Add(max);

        return minMax;
    }
    public int FindSum(List<int> aList)
    {
        int sum = 0;
        foreach(int num in aList)
        {
            sum += Math.Abs(num);
        }
        return sum;
    }
}