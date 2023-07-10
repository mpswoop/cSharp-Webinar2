// square check - is one square of other
Console.WriteLine("Input first number");
int num1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Input second number");
int num2 = Int32.Parse(Console.ReadLine());

if (num1 * num1 == num2)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}