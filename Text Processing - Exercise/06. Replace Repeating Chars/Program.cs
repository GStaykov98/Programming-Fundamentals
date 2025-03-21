string input = Console.ReadLine();
string output = "";

for (int i = 0; i < input.Length; i++)
{
	if (i == 0)
	{
		output += input[i];
	}
    else
    {
        if (input[i] != input[i - 1])
        {
            output += input[i];
        }
    }
}

Console.WriteLine(output);