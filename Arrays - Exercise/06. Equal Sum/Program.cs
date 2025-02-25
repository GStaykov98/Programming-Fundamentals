int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
bool isFound = false;

for (int i = 0; i < numbers.Length; i++)
{
	int leftSum = 0;

	for (int j = 0; j < i; j++)
	{
		leftSum += numbers[j];
	}

	int rightSum = 0;

	for (int j = i + 1; j < numbers.Length; j++)
	{
		rightSum += numbers[j];
	}

	if (leftSum == rightSum)
	{
		isFound = true;
        Console.WriteLine(i);
		break;
    }
}

if (!isFound)
{
    Console.WriteLine("no");
}