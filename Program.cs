// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input First number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Second number");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Symbol of Operation");
string operation = Console.ReadLine() ?? "symbol";

if(operation == "+")
{
    Console.WriteLine(num1 + num2);
}
else if(operation == "-")
{
    Console.WriteLine(num1 - num2);
}
else if(operation == "*")
{
    Console.WriteLine(num1 * num2);
}
else if(operation == "/")
{
    Console.WriteLine(num1 / num2);
}
else
{
    Console.WriteLine("Invalid Operation");
}