int number = Math.Abs(int.Parse(Console.ReadLine()));
int evensSum = GetSumOfEvenDigits(number);
int oddsSum = GetSumOfOddDigits(number);
int multiplication = GetMultipleOfEvenAndOdds(evensSum, oddsSum);
Console.WriteLine(multiplication);

static int GetSumOfEvenDigits(int number)
{
    string numToString = number.ToString();
    int sum = 0;

    for (int i = 0; i < numToString.Length; i++)
    {
        int currentDigit = int.Parse(numToString[i].ToString());

        if (currentDigit % 2 == 0)
        {
            sum += currentDigit;
        }
    }

    return sum;
}

static int GetSumOfOddDigits(int number)
{
    string numToString = number.ToString();
    int sum = 0;

    for (int i = 0; i < numToString.Length; i++)
    {
        int currentDigit = int.Parse(numToString[i].ToString());

        if (currentDigit % 2 != 0)
        {
            sum += currentDigit;
        }
    }

    return sum;
}

static int GetMultipleOfEvenAndOdds(int a, int b)
{
    return a * b;
}