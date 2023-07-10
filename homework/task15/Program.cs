// holiday or working day
Console.WriteLine("Pease select your day");
Console.WriteLine("");
Console.WriteLine("enter 1 for Monday");
Console.WriteLine("enter 2 for Tuesday");
Console.WriteLine("enter 3 for Wedesday");
Console.WriteLine("enter 4 for Tursday");
Console.WriteLine("enter 5 for Friday");
Console.WriteLine("enter 6 for Saturday");
Console.WriteLine("enter 7 for Sunday");
Console.WriteLine("");

int day = Int32.Parse(Console.ReadLine());

if (day > 0 && day < 6)
{
    Console.WriteLine("this is a working day");
}
else if (day > 5 && day < 8)
{
    Console.WriteLine("this is a holiday");
}
else
{
    Console.WriteLine("wrong input");
}