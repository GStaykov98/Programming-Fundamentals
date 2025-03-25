string input = Console.ReadLine();
string output = "";
List<int> numbers = new();
List<char> nonNumbers = new();

for (int i = 0; i < input.Length; i++)
{
	if (char.IsDigit(input[i]))
	{
		numbers.Add(int.Parse(input[i].ToString()));
	}
	else
	{
		nonNumbers.Add(input[i]);
	}
}

List<int> takeList = new();
List<int> skipList = new();

for (int i = 0; i < numbers.Count; i++)
{
	if (i % 2 == 0)
	{
		takeList.Add(numbers[i]);
	}
	else
	{
		skipList.Add(numbers[i]);
	}
}


for (int i = 0; i < takeList.Count; i++)
{
	List<char> currentElements = nonNumbers.Take(takeList[i]).ToList();

	for (int j = 0; j < currentElements.Count; j++)
	{
		output += currentElements[j].ToString();
	}

	nonNumbers = nonNumbers.Skip(skipList[i] + takeList[i]).ToList();
}

Console.WriteLine(output);