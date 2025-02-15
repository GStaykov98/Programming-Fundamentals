int n = int.Parse(Console.ReadLine());
string output = string.Empty;

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    int digit = int.Parse(input[0].ToString());
    int length = input.Length;
    int offset = (digit - 2) * 3;

    if (digit == 8 || digit == 9)
    {
        offset += 1;
    }

    int index = offset + length - 1 + 97;

    char currentChar = (char)index;

    if (index == 91)
    {
        output += " ";
    }
    else
    {
        output += currentChar;
    }
}

Console.WriteLine(output);