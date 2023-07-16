using System;
using System.Collections.Generic;
using System.Linq;

class SkipTakeSumAvg
{
    public void Sum(List<double> numbers)
    {
        Console.Write("Enter the skip value: ");
        int skipValue = int.Parse(Console.ReadLine());

        Console.Write("Enter the take value: ");
        int takeValue = int.Parse(Console.ReadLine());

        var sum = numbers.Skip(skipValue).Take(takeValue).Sum();
        Console.WriteLine($"Sum :{sum}");
    }

    public void Avg(List<double> numbers)
    {
        Console.WriteLine("Enter skip value :");
        int skipValue = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter take value:");
        int takeValue = int.Parse(Console.ReadLine());
        var average = numbers.Skip(skipValue).Take(takeValue).Average();
        Console.WriteLine($"Average :{average}");
    }
}
