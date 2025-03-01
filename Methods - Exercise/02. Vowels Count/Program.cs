string input = Console.ReadLine();
int vowelsCount = GetVowelsCount(input);
Console.WriteLine(vowelsCount);

static int GetVowelsCount(string word)
{
    int vowelsCount = 0;

    for (int i = 0; i < word.Length; i++)
    {
        if (char.ToLower(word[i]) == 'a' ||
            char.ToLower(word[i]) == 'e' ||
            char.ToLower(word[i]) == 'i' ||
            char.ToLower(word[i]) == 'o' ||
            char.ToLower(word[i]) == 'u')
        {
            vowelsCount++;
        }
    }

    return vowelsCount;
}