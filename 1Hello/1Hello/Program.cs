// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter your name:");
string name = Console.ReadLine();

Console.WriteLine("How much hours did you sleep last night?");
int hoursOfSleep = int.Parse(Console.ReadLine());

Console.WriteLine("Hello, " + name);

if (hoursOfSleep < 8) {
    Console.WriteLine("You must feel tired.");
}
else {
    Console.WriteLine("You seem well rested.");
}