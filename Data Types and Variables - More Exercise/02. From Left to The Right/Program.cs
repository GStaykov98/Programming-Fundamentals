int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine().Split(" ");
    long leftNum = long.Parse(input[0]);
    long rightNum = long.Parse(input[1]);
    int sum = 0;

    if (leftNum > rightNum)
    {
        string numToString = leftNum.ToString();

        for (int j = 0; j < numToString.Length; j++)
        {
            int currentDigit = int.Parse(numToString[j].ToString());
            sum += currentDigit;
        }
    }
    else
    {
        string numToString = rightNum.ToString();

        for (int j = 0; j < numToString.Length; j++)
        {
            int currentDigit = int.Parse(numToString[j].ToString());
            sum += currentDigit;
        }
    }

    Console.WriteLine(sum);
}