List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
int maxCapacity = int.Parse(Console.ReadLine());
string input;

while ((input = Console.ReadLine()) != "end")
{
    string[] arr = input.Split();

	if (arr[0] == "Add")
	{
		int currentPassengers = int.Parse(arr[1]);
		train.Add(currentPassengers);
	}
	else
	{
		int currentPassengers = int.Parse(arr[0]);

		for (int i = 0; i < train.Count; i++)
		{
			if (train[i] + currentPassengers <= maxCapacity)
			{
				train[i] += currentPassengers;
				break;
			}
		}
	}
}

Console.WriteLine(string.Join(" ", train));