
Console.WriteLine("Write first number:");
string num1 = Console.ReadLine();
double parseNum1 = double.Parse(num1);

Console.WriteLine("Write second number:");
string num2 = Console.ReadLine();
double parseNum2 = double.Parse(num2);

Console.WriteLine("Enter an operator you want to use: (+, -, *, /):");
string oper = Console.ReadLine();

double result = 0;

switch (oper)
{
    case "+":
        result = parseNum1 + parseNum2;
        break;
    case "-":
        result = parseNum1 - parseNum2;
        break;
    case "*":
        result = parseNum1 * parseNum2;
        break;
    case "/":
        if (parseNum2 != 0)
        {
            result = parseNum1 / parseNum2;
        }
        else
        {
            Console.WriteLine("You can't divide by 0");
            return;
        }
        break;
    default:
        Console.WriteLine("No such operator");
        return;
}

Console.WriteLine(parseNum1 + oper + parseNum2+ "=" + result);