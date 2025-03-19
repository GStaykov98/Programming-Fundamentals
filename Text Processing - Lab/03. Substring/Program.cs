string wordToRemove = Console.ReadLine();
string input = Console.ReadLine();

while (input.Contains(wordToRemove))
{
    int index = input.IndexOf(wordToRemove);
    input = input.Remove(index, wordToRemove.Length);
}

Console.WriteLine(input);