int n = int.Parse(Console.ReadLine());
int[] encriptions = new int[n];

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    int sum = 0;

    for (int j = 0; j < input.Length; j++)
    {
        char currentChar = input[j];

        if ("aeiouAEIOU".Contains(currentChar))
        {
            sum += currentChar * input.Length;
        }
        else
        {
            sum += currentChar / input.Length;
        }
    }

    encriptions[i] = sum;
}

Array.Sort(encriptions);

for (int i = 0;i < encriptions.Length; i++)
{
    Console.WriteLine(encriptions[i]);
}