// combined division check 7 & 23
Console.WriteLine("Input first number");
int num1 = Int32.Parse(Console.ReadLine());

if (num1%7 == 0 && num1%23 == 0)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}