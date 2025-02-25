int n = int.Parse(Console.ReadLine());
int[] arr1 = new int[n];
int[] arr2 = new int[n];

for (int i = 0; i < n; i++)
{
    int[] currentNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int leftNum = currentNumbers[0];
    int rightNum = currentNumbers[1];

    if (i % 2 == 0)
    {
        arr1[i] = leftNum;
        arr2[i] = rightNum;
    }
    else
    {
        arr1[i] = rightNum;
        arr2[i] = leftNum;
    }
}

foreach (int i in arr1)
{
    Console.Write(i + " ");
}

Console.WriteLine();

foreach (int i in arr2)
{
    Console.Write(i + " ");
}