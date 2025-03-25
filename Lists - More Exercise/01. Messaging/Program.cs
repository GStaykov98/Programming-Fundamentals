List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
string input = Console.ReadLine();
string output = "";

foreach (int number in numbers)
{
    string numToString = number.ToString();
    int currentSum = 0;

    for (int i = 0; i < numToString.Length; i++)
    {
        int currentDigit = int.Parse(numToString[i].ToString());
        currentSum += currentDigit;
    }

    while (currentSum >= input.Length)
    {
        currentSum -= input.Length;
    }

    output += input[currentSum];
    input = input.Remove(currentSum, 1);
}

Console.WriteLine(output);