string[] input = Console.ReadLine().Split();
Random random = new Random();

for (int i = 0; i < input.Length; i++)
{
    string currentWord = input[i];
    int wordToChange = random.Next(input.Length - 1);

    input[i] = input[wordToChange];
    input[wordToChange] = currentWord;
}

foreach (string word in input)
{
    Console.WriteLine(word); 
}