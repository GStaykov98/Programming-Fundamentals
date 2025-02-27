int n1 = int.Parse(Console.ReadLine());
string @operator = Console.ReadLine();
int n2 = int.Parse(Console.ReadLine());
double result = GetCalculation(@operator, n1, n2);
Console.WriteLine(result);


static double GetCalculation(string @operator, int n1, int n2)
{
	double result = 0;

	switch (@operator)
	{
		case "+":
			result = n1 + n2;
			break;
		case "-":
			result = n1 - n2;
			break;
		case "*":
			result = n1 * n2;
			break;
		case "/":
			result = n1 / (double)n2;
			break;
	}

	return result;
} 