string[] initalArray = Console.ReadLine().Split('|');
List<int> outputList = new();

for (int i = initalArray.Length - 1; i >= 0; i--)
{
    int[] currentArrayValues = initalArray[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    for (int j = 0; j < currentArrayValues.Length; j++)
    {
        outputList.Add(currentArrayValues[j]);
    }
}

Console.WriteLine(string.Join(" ", outputList));