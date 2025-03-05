Console.WriteLine("Write first number to multiply:");
string num1 = Console.ReadLine();
double answer1 = double.Parse(num1);
Console.WriteLine("Write second number:");
string num2 = Console.ReadLine();
double answer2 = double.Parse(num2);
double sum = answer1 + answer2;
Console.WriteLine(answer1 + "+" + answer2 + "=" + sum);