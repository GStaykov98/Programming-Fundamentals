int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 0; i < numbers.Length; i++)
{
    int currentNum = numbers[i];
    bool isBigger = true;

    for (int j = i; j < numbers.Length; j++)
    {
        if (numbers[j] > currentNum)
        {
            isBigger = false;
            break;
        }
    }

    if (isBigger)
    {
        Console.Write(numbers[i] + " ");
    }
}