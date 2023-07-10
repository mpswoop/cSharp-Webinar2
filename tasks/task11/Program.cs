// generate random 3 digit number and remove second digit 456 --> 46
int random = new Random().Next(100,1000 );

Console.WriteLine("generated Number:");
Console.WriteLine(random);
Console.WriteLine();

int num3 = random % 10;
int num2 = random / 10 % 10;
int num1 = random / 100;
// int num3 = random % 100;
// int num2 = (random - num2) / 10;
// int num2 = random / 10 % 10;
// int num2 = random / 10;


Console.WriteLine($"Digit1: {num1}");
Console.WriteLine($"Digit2: {num2}");
Console.WriteLine($"Digit3: {num3}");
Console.WriteLine();
Console.WriteLine($"new number: {num1}{num3}");
