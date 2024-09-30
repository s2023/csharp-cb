using GradeBook.Console;
//using System.Speech.Synthesis;
using System;
using System.IO;
using System.Reflection.PortableExecutable;


GradeBookModel book = new GradeBookModel("Tony's Book");
//v3 FileStream stream = null;
//v3y4 StreamReader reader = null;
//book.AddGrade(91f);
//book.AddGrade(89.1f);
//book.AddGrade(75f);
//book.Name = "";

try
{
    //v3 sin using stream = File.Open("Grades.txt", FileMode.Open);
    using (FileStream stream = File.Open("Grades.txt", FileMode.Open))
    using (StreamReader reader = new StreamReader(stream))
    {
        //v4 reader = new StreamReader(stream);
        //v2 FileStream stream = File.Open("Grades.txt", FileMode.Open);
        //v2 StreamReader reader = new StreamReader(stream);
        string line = reader.ReadLine();
        //v1 string[] lines = File.ReadAllLines("Grades.txt");
        //v1 foreach (string line in lines)
        while(line != null)
        {
            float grade = float.Parse(line);
            book.AddGrade(grade);
            line = reader.ReadLine();
        }
    }
    //v2 reader.Close();
    //v2 stream.Close();
}
catch (FileNotFoundException ex)
{
    //v2 if (reader != null)
    //{
    //    reader.Close();
    //    stream.Close();
    //}
    Console.WriteLine("Could not locate the file Grades.txt");
    return;
}
catch (UnauthorizedAccessException ex)
{
    Console.WriteLine("No access");
    return;
}
//v3 finally
//{
//    if (reader != null)
//    {
//        reader.Close();
//    }
//    if (stream != null)
//    {
//        stream.Close();
//    }
//}

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
//Console.WriteLine("Letter Grade: " + stats.LetterGrade);
Console.WriteLine("{0} {1}", stats.LetterGrade, stats.Description);




//Cap 4 ↓ ///////////////////////////
////GradeBookModel book = new GradeBookModel();
//GradeBookModel book = new GradeBookModel("Tony's Book");
//book.AddGrade(91f);
//book.AddGrade(89.1f);
//book.AddGrade(75f);

//GradeStatistics stats = book.ComputeStatistics();

//book.NameChanged += OnNameChanged;
//book.NameChanged += OnNameChanged;
//book.NameChanged += OnNameChanged2;
//book.NameChanged -= OnNameChanged;
////book.NamedChanged = new NamedChangedDelegate(OnNameChanged2);


//book.Name = "Allen's Book 1";
//WriteNames(book.Name);
////book.Name = "";
////WriteNames("Andres", "Maria", "Kike", "Luis");

////int number = 20;
////WriteBytes1(number);
////WriteBytes(stats.AverageGrade);

//Console.WriteLine("Average Grade: " + stats.AverageGrade);
//Console.WriteLine("Highest Grade: " + stats.HighestGrade);
//Console.WriteLine("Lowest Grade: " + stats.LowestGrade);


//void OnNameChanged2(object sender, NameChangedEventArgs args)
//{
//    Console.WriteLine("******");
//}

//void OnNameChanged(object sender, NameChangedEventArgs args)
//{
//    Console.WriteLine("Name changed from {0} to {1}", args.OldValue, args.NewValue);
//}

//void WriteBytes1(int value)
//{
//    Console.Write(value + ": ");
//    byte[] bytes = BitConverter.GetBytes(value);
//    WriteByteArray(bytes);
//}

//void WriteBytes(float value)
//{
//    Console.Write(value + ": ");
//    byte[] bytes = BitConverter.GetBytes(value);
//    WriteByteArray(bytes);
//}

//static void WriteByteArray(byte[] bytes)
//{
//    foreach (byte b in bytes)
//    {
//        Console.Write("0x{0:X} ", b); //Hexadecimal
//        //Console.Write("0x{0:X} {1} {2} ", b, "Scott", "Allen"); //nose
//        //Console.Write("0x{0} ", b); //Decimal
//    }
//    Console.WriteLine();
//}

//static void WriteNames(params string[] names)
//{
//    foreach (string name in names)
//    {
//        Console.WriteLine(name);
//    }
//}



//Cap 3 ↓ /////////////////////////
//Arrays();
////Immutable();
////PassByValueAndRef();
//SpeechSynth();


//void SpeechSynth()
//{
//    // Create an instance of SpeechSynthesizer
//    SpeechSynthesizer synthesizer = new SpeechSynthesizer();
//    // Text that we want to be read aloud
//    string text = "Hello, this is the GradeBook Application";
//    // Voice and volume settings
//    synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
//    synthesizer.Volume = 100; // 0...100
//    // Read the text aloud
//    synthesizer.Speak(text);
//    // Pause so you can listen to the text
//    Console.WriteLine("Press any key to exit...");
//    Console.ReadKey();
//}

//void Arrays()
//{
//    float[] grades;
//    grades = new float[3];

//    AddGrades(grades);

//    foreach (float grade in grades)
//    {
//        Console.WriteLine(grade);
//    }
//}

//static void AddGrades(float[] grades)
//{
//    if (grades.Length >= 3)
//    {
//        grades[0] = 91f;
//        grades[1] = 89.1f;
//        grades[2] = 75f;
//    }
//}

//void Immutable()
//{
//    string name = " Scott ";
//    name = name.Trim();
//    //DateTime date = DateTime.Now;
//    DateTime date = new DateTime(2024, 1, 1);
//    date = date.AddHours(25);

//    Console.WriteLine(name);
//    Console.WriteLine(date);
//}

//void GiveBookAName(ref GradeBookModel book)
//{
//    //book = new GradeBook();
//    //book.Name = "The Gradebook Ex2";
//}

//void IncrementNumber(ref int number)
//{
//    number = 42;
//}

//void PassByVauleAndRef()
//{
//    GradeBookModel g1 = new GradeBookModel();
//    GradeBookModel g2 = g1;

//    //GiveBookAName(g2);
//    GiveBookAName(ref g2);
//    Console.WriteLine(g2.Name);

//    //g1 = new GradeBook();
//    //g1.Name = "Scott's Book";
//    //Console.WriteLine("g2 name is:" + g2.Name);

//    //DateTime d;
//    int x1 = 10;
//    //int x2 = x1;
//    //x1 = 100;
//    //Console.WriteLine(x2);
//    IncrementNumber(ref x1);
//    Console.WriteLine(x1);
//}



//Cap 2↓ ///////////////////////////
//string name1 = "Scott";
//string name2 = "scott";

//bool areEqual = name1.Equals(name2, StringComparison.CurrentCultureIgnoreCase);
//Console.WriteLine(areEqual);


//GradeBook book = new GradeBook();
//book.AddGrade(91f);
//book.AddGrade(89.1f);
//book.AddGrade(75f);

//GradeStatistics stats = book.ComputeStatistics();
//Console.WriteLine("Highest Grade: " + stats.HighestGrade);
//Console.WriteLine("Lowest Grade: " + stats.LowestGrade);
//Console.WriteLine("Average Grade: " + stats.AverageGrade);


//GradeBook book2 = book;
//book2.AddGrade(75.2f);
//Console.WriteLine(book2);
