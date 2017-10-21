using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        //1. Write a C# program that takes two numbers as input, 
        //adds them together, and displays the result of that operation

        //Ask for first number
        Console.WriteLine("What's the first number?");

        //Save that number
        int firstNumber;

        var didItParsed = int.TryParse(Console.ReadLine(), out firstNumber);

        if (!didItParsed) //when didItPassed == false
        {
            firstNumber = 0;
        }

        //Ask for second number
        Console.WriteLine("What's the second number?");

        //Save second number
        int secondNumber;

        didItParsed = int.TryParse(Console.ReadLine(), out secondNumber);

        if (!didItParsed)
        {
            secondNumber = 0;
        }

        //Add
        int result = firstNumber + secondNumber;

        //Show the result
        Console.WriteLine("The result is: " + result);

        Console.ReadLine();
    }
}
