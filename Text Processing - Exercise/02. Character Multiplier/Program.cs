string[] input = Console.ReadLine().Split();
int sumOfStrings = GetStringSum(input[0], input[1]);

Console.WriteLine(sumOfStrings);

static int GetStringSum(string str1, string str2)
{
    int totalSum = 0;
    int shorterString = Math.Min(str1.Length, str2.Length);

    for (int i = 0; i < shorterString; i++)
    {
        totalSum += str1[i] * str2[i];
    }

    if (str1.Length > str2.Length)
    {
        for (int i = shorterString; i < str1.Length; i++)
        {
            totalSum += str1[i];
        }
    }
    else if (str2.Length > str1.Length)
    {
        for (int i = shorterString; i < str2.Length; i++)
        {
            totalSum += str2[i];
        }
    }

    return totalSum;
}