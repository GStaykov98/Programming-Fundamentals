int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int biggestSequence = 0;
int biggestNumber = 0;

for (int i = 0; i < numbers.Length; i++)
{
    int currentSequence = 0;
    int currentNum = numbers[i];

    for (int j = i; j < numbers.Length; j++)
    {
        if (numbers[j] == currentNum)
        {
            currentSequence++;
        }
        else
        {
            break;
        }
    }

    if (currentSequence > biggestSequence)
    {
        biggestSequence = currentSequence;
        biggestNumber = currentNum;
    }
}

Console.WriteLine(string.Concat(Enumerable.Repeat($"{biggestNumber} ", biggestSequence)));