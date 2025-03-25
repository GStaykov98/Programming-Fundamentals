List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> outputList = new();
int shorterList = Math.Min(firstList.Count, secondList.Count);

for (int i = 0; i < shorterList; i++)
{
    outputList.Add(firstList[i]);
    outputList.Add(secondList[secondList.Count - 1 - i]);
}

int minNumber = 0;
int maxNumber = 0;

if (firstList.Count > secondList.Count)
{
    minNumber = Math.Min(firstList[firstList.Count - 1], firstList[firstList.Count - 2]);
    maxNumber = Math.Max(firstList[firstList.Count - 1], firstList[firstList.Count - 2]);
}
else
{
    minNumber = Math.Min(secondList[0], secondList[1]);
    maxNumber = Math.Max(secondList[0], secondList[1]);
}

for (int i = 0; i < outputList.Count; i++)
{
    if (outputList[i] <= minNumber ||
        outputList[i] >= maxNumber)
    {
        outputList.RemoveAt(i);
        i--;
    }
}

outputList.Sort();

Console.WriteLine(string.Join(" ", outputList));