using GradeBook.Console;
using System;
using System.IO;
using System.Reflection.PortableExecutable;


GradeBookModel book = new GradeBookModel("Tony's Book");

try
{
    using (FileStream stream = File.Open("Grades.txt", FileMode.Open))
    using (StreamReader reader = new StreamReader(stream))
    {
        string line = reader.ReadLine();

        while(line != null)
        {
            float grade = float.Parse(line);
            book.AddGrade(grade);
            line = reader.ReadLine();
        }
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine("Could not locate the file Grades.txt");
    return;
}
catch (UnauthorizedAccessException ex)
{
    Console.WriteLine("No access");
    return;
}

book.WriteGrades(Console.Out);

try
{
    Console.WriteLine("Please enter a name for the book:");
    book.Name = Console.ReadLine();
}
catch (ArgumentException ex)
{
    Console.WriteLine("Invalid name");
}

GradeStatistics stats = book.ComputeStatistics();
Console.WriteLine("Average Grade: " + stats.AverageGrade);
Console.WriteLine("Highest Grade: " + stats.HighestGrade);
Console.WriteLine("Lowest Grade: " + stats.LowestGrade);
Console.WriteLine("{0} {1}", stats.LetterGrade, stats.Description);