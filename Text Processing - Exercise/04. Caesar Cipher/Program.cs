string input = Console.ReadLine();
string output = "";

for (int i = 0; i < input.Length; i++)
{
    char currentChar = input[i];

    output += (char)(currentChar + 3);
}

Console.WriteLine(output);