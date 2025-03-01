char c1 = char.Parse(Console.ReadLine());
char c2 = char.Parse(Console.ReadLine());
PrintCharacters(c1, c2);

static void PrintCharacters(char c1, char c2)
{
    int start = c1;
    int end = c2;

    if (c1 > c2)
    {
        start = c2;
        end = c1;
    }

    for (int i = start + 1; i < end; i++)
    {
        char currentChar = (char)i;
        Console.Write($"{currentChar} ");
    }
}