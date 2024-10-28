using GradeBook.ConsoleApp;
using System;
using System.IO;
using System.Reflection.PortableExecutable;

IGradeTracker book = CreateGradebook();
//v1 GradeTracker book = CreateGradebook();
//ThrowAwayGradeBook book = new ThrowAwayGradeBook("Tony's Book");
//GradeBookModel book = new GradeBookModel("Tony's Book");

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

foreach (float grade in book)
{
    Console.WriteLine(grade);
}

try
{
}
catch (ArgumentException ex)
{
    Console.WriteLine("Invalid name");
}

static IGradeTracker CreateGradebook()
{
    GradeTracker book = new ThrowAwayGradeBook("Tony's Book");
    return book;
}

GradeStatistics stats = book.ComputeStatistics();
Console.WriteLine("Average Grade: " + stats.AverageGrade);
Console.WriteLine("Highest Grade: " + stats.HighestGrade);
Console.WriteLine("Lowest Grade: " + stats.LowestGrade);
Console.WriteLine("{0} {1}", stats.LetterGrade, stats.Description);

