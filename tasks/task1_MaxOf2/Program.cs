// generate random number between 10 and 99 and find max 78-->8
int random = new Random().Next(10,99);

Console.WriteLine("generated Number:");
Console.WriteLine(random);

int num2 = random % 10;
// int num1 = (random - num2) / 10;
// int num1 = random / 10 % 10;
// int num1 = random / 10;
int num1 = random /= 10;

Console.WriteLine("Digit1:");
Console.WriteLine(num1);
Console.WriteLine("Digit2:");
Console.WriteLine(num2);

if (num1 > num2)
{
    // Console.WriteLine("max = ");
    // Console.WriteLine(num1);
    Console.WriteLine($"max = {num1}");
}
else
{
    Console.WriteLine("max = ");
    Console.WriteLine(num2);
}