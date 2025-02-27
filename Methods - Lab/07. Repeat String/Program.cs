string input = Console.ReadLine();
int n = int.Parse(Console.ReadLine());
string output = RepeatString(input, n);
Console.WriteLine(output);

static string RepeatString(string input, int n)
{
    string output = string.Empty;

    for (int i = 0; i < n; i++)
    {
        output += input;
    }

    return output;
}