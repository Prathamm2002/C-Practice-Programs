using System;

class Program
{
    static void Main()
    {
        int rollNo;
        string name;
        int numSubjects;

        Console.Write("Enter Roll No: ");
        rollNo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        name = Console.ReadLine();

        Console.Write("Enter the number of subjects: ");
        numSubjects = Convert.ToInt32(Console.ReadLine());

        double[] marks = new double[numSubjects];
        double total = 0;
        int maxMarks = 100;  // You can adjust this to the maximum marks for each subject.

        for (int i = 0; i < numSubjects; i++)
        {
            Console.Write($"Enter Marks for Subject {i + 1} (out of {maxMarks}): ");
            marks[i] = Convert.ToDouble(Console.ReadLine());
            total += marks[i];
        }

        double percentage = (total / (numSubjects * maxMarks)) * 100;

        string division;

        if (percentage >= 90)
            division = "A+";
        else if (percentage >= 80)
            division = "A";
        else if (percentage >= 70)
            division = "B+";
        else if (percentage >= 60)
            division = "B";
        else if (percentage >= 50)
            division = "C+";
        else if (percentage >= 40)
            division = "C";
        else
            division = "Fail";

        Console.WriteLine("\n----- Result -----");
        Console.WriteLine($"Roll No: {rollNo}");
        Console.WriteLine($"Name: {name}");

        Console.WriteLine("\nMarks for each subject:");
        for (int i = 0; i < numSubjects; i++)
        {
            Console.WriteLine($"Subject {i + 1}: {marks[i]}/{maxMarks}");
        }

        Console.WriteLine($"Total Marks: {total}/{numSubjects * maxMarks}");
        Console.WriteLine($"Percentage: {percentage}%");
        Console.WriteLine($"Division: {division}");
    }
}
