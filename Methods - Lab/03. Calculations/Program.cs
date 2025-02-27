string command = Console.ReadLine();
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

switch (command)
{
    case "add":
        GetCalculationAdd(number1, number2);
        break;
    case "multiply":
        GetCalculationMultiply(number1, number2);
        break;
    case "subtract":
        GetCalculationSubtract(number1, number2);
        break;
    case "divide":
        GetCalculationDivide(number1, number2);
        break;
}

static void GetCalculationAdd(int n1, int n2)
{
    Console.WriteLine(n1 + n2);
}

static void GetCalculationMultiply(int n1, int n2)
{
    Console.WriteLine(n1 * n2);
}

static void GetCalculationSubtract(int n1, int n2)
{
    Console.WriteLine(n1 - n2);
}

static void GetCalculationDivide(int n1, int n2)
{
    Console.WriteLine(n1 / n2);
}