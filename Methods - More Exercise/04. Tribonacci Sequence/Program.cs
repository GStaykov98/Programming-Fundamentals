int n = int.Parse(Console.ReadLine());
int[] numbers = new int[n];
numbers = TribonacciSequence(n);

Console.WriteLine(string.Join(" ", numbers));

static int[] TribonacciSequence(int n)
{
    int[] output = new int[n];

    for (int i = 0; i < n; i++)
    {
        if (i < 2)
        {
            output[i] = 1;
            continue;
        }

        if (i == 2)
        {
            output[i] = output[0] + output[1];
            continue;
        }

        output[i] = output[i - 1] + output[i - 2] + output[i - 3];
    }

    return output;
}