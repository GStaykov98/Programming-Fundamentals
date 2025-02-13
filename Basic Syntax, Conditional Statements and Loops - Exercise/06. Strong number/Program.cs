int n = int.Parse(Console.ReadLine());
string numberAsString = n.ToString();
int result = 0;

for (int i = 0; i < numberAsString.Length; i++)
{
    int currentDigit = int.Parse(numberAsString[i].ToString());
	int currentDigitFactorial = 1;

	for (int j = 1; j <= currentDigit; j++)
	{
		currentDigitFactorial *= j;
	}

	result += currentDigitFactorial;
}

if (result == n)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}