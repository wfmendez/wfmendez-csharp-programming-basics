using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        string sign = "";

        Console.WriteLine("Hello, please type your grade:");
        int grade = int.Parse(Console.ReadLine());
        

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        int lastDigit = grade / 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        
        else if (lastDigit <= 3)
        {
            sign = "-";
        }

        Console.WriteLine($"Your grade is {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! Your pass the semester.");
        }
        else {
            Console.WriteLine("Sorry, you don't pass the semester");
        }
    }
}