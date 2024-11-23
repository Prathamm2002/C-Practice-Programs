using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        double number;

        // I took Double, so as to consider if a user puts in decimal values
        if (double.TryParse(Console.ReadLine(), out number))
        {
            if (number % 1 == 0)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} is an even number.");
                }
                else
                {
                    Console.WriteLine($"{number} is an odd number.");
                }
            }
            else
            {
                Console.WriteLine($"{number} is a decimal number and cannot be classified as odd or even.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
