// enter two numbers, check if first can be devided by second, if yes show yes, if no show no
// 16, 4 ==> yes
// 18, 4 ==> 2
Console.WriteLine("Input first number");
int num1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Input second number");
int num2 = Int32.Parse(Console.ReadLine());
//int rest = num1 % num2;

if (num1 % num2 == 0)
// if (rest == 0)
{
    Console.WriteLine("");
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("");
    Console.WriteLine("no, rest equals:");
    Console.WriteLine(num1 % num2);  
}
