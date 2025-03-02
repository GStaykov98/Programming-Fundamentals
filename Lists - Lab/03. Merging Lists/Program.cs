List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
var outputList = new List<int>();
int shorterListCount = Math.Min(firstList.Count, secondList.Count);

for (int i = 0; i < shorterListCount; i++)
{
    outputList.Add(firstList[i]);
    outputList.Add(secondList[i]);
}

if (firstList.Count > secondList.Count)
{
    for (int i = secondList.Count; i < firstList.Count; i++)
    {
        outputList.Add(firstList[i]);
    }
}
else if (secondList.Count > firstList.Count)
{
    for (int i = firstList.Count; i < secondList.Count; i++)
    {
        outputList.Add(secondList[i]);
    }
}

Console.WriteLine(string.Join(" ", outputList));