string[] bannedWords = Console.ReadLine().Split(", ");
string text = Console.ReadLine();
bool textContaintsBannedWords = true;

for (int i = 0; i < bannedWords.Length; i++)
{
    string currentBannedWord = bannedWords[i];
    string replacement = new string('*', currentBannedWord.Length);

    if (text.Contains(bannedWords[i]))
    {
        text = text.Replace(currentBannedWord, replacement);
        i--;
    }
}

Console.WriteLine(text);