// input -digital number - output second digit
Console.WriteLine("please input a three digital number");

int num = Int32.Parse (Console.ReadLine());
int length = num.ToString ().Length;

if (length == 3)

{
// int digit3 = num % 10;
int digit2 = num / 10 % 10;
// int digit1 = num /= 100;

// Console.WriteLine($"Digit1: {digit1}");
Console.WriteLine($"Digit2: {digit2}");
// Console.WriteLine($"Digit3: {digit3}");
}
else
{
    Console.WriteLine("wrong input format, try again");
}