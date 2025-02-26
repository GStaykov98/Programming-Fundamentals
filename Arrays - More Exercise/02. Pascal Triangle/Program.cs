int n = int.Parse(Console.ReadLine());
int[] previousRow = {1};

for (int i = 0; i < n; i++)
{
    int[] currentRow = new int[i + 1];

    if (i == 0)
    {
        Console.WriteLine(1);
        continue;
    }

    for (int j = 0; j < currentRow.Length; j++)
    {
        if (j == 0 || j == currentRow.Length - 1)
        {
            currentRow[j] = 1;
        }
        else
        {
            currentRow[j] = previousRow[j] + previousRow[j - 1];
        }
    }

    previousRow = currentRow;

    Console.WriteLine(string.Join(" ", currentRow));
}