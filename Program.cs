// Console-based calculator project

Console.Write("First Number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Second Number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a Valid Operator: ");

string ope = Console.ReadLine();
if (ope == "+")
{
    int result = num1 + num2;
    Console.WriteLine("The solution is " + result);
}
else if (ope == "-")
{
    int result = num1 - num2;
    Console.WriteLine("The solution is " + result);
}
else if (ope == "*")
{
    int result = num1 * num2;
    Console.WriteLine("The solution is " + result);
}
else if (ope == "/")
{
    int result = num1 / num2;
    Console.WriteLine("The solution is " + result);
}
else
{
    Console.WriteLine("Invalid Operator");
}

Console.ReadLine();
