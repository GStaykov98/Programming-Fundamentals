List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
int[] bomb = Console.ReadLine().Split().Select(int.Parse).ToArray();
int bombNumber = bomb[0];
int bombPower = bomb[1];

for (int i = 0; i < numbers.Count; i++)
{
	if (numbers[i] == bombNumber)
	{
		for (int j = 0; j < bombPower; j++)
		{
			if (i + 1 >= numbers.Count)
			{
				break;
			}

			numbers.RemoveAt(i + 1);
		}

		for (int j = 0; j < bombPower; j++)
		{
			if (i - 1 < 0)
			{
				break;
			}

			numbers.RemoveAt(i - 1);
			i--;
		}

		numbers.RemoveAt(i);

		i = -1;
	}
}

Console.WriteLine(numbers.Sum());