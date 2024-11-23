using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third number: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        double product = num1 * num2 * num3;

        Console.WriteLine($"The product of {num1}, {num2}, and {num3} is: {product}");
    }
}
