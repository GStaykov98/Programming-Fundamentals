string input = Console.ReadLine();
PrintMiddleCharacters(input);

static void PrintMiddleCharacters(string input)
{
	if (input.Length % 2 != 0)
	{
        Console.WriteLine(input[input.Length / 2]);
    }
	else
	{
        Console.Write(input[input.Length / 2 - 1]);
        Console.WriteLine(input[input.Length / 2]);
    }
}