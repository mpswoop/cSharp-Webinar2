// input number - output third digit or digit does not exist
Console.WriteLine("please input a number");

int num = Int32.Parse (Console.ReadLine());
int length = num.ToString ().Length;

if (length > 2)

{
int digit3 = num / 100 % 10;
// int digit2 = num / 10 % 10;
// int digit1 = num /= 100;

// Console.WriteLine($"Digit1: {digit1}");
// Console.WriteLine($"Digit2: {digit2}");
Console.WriteLine($"Digit3: {digit3}");
}
else
{
    Console.WriteLine("there is no 3rd digit");
}