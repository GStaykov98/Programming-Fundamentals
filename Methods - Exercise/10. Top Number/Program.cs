int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    if (CheckIfTopNumber(i))
    {
        Console.WriteLine(i);
    }
}


static bool CheckIfTopNumber(int n)
{
    if (!CheckIfDigitsAreDivisibleBy8(n))
    {
        return false;
    }
    if (!CheckIfOddDigits(n))
    {
        return false;
    }

    return true;
}

static bool CheckIfDigitsAreDivisibleBy8(int n)
{
    int sum = 0;

    while (n > 0)
    {
        sum += n % 10;
        n /= 10;
    }

    if (sum % 8 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

static bool CheckIfOddDigits(int n)
{
    string numToString = n.ToString();

    for (int i = 0; i < numToString.Length; i++)
    {
        int currentNum = int.Parse(numToString[i].ToString());
        if (currentNum % 2 != 0)
        {
            return true;
        }
    }

    return false;
}