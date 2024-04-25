using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int addNumber = 1;
        int sum = 0;
        List<int> numbers = new List<int>();
        
        while (addNumber != 0)
        {
            Console.WriteLine("Enter number: "); 
            addNumber = int.Parse(Console.ReadLine());
            sum += addNumber;
            if (addNumber != 0)
            {
                numbers.Add(addNumber);
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        
        int count = numbers.Count;
        int average = sum / count;
        Console.WriteLine($"The average is: {average}");

        int largestNumber = 0;

        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }

        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}