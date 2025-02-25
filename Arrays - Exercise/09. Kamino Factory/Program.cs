int length = int.Parse(Console.ReadLine());
int[] bestDNA = new int[length];
int bestDNALength = 0;
int bestDNAIndex = 0;
int bestDNAStartingIndex = 0;
int bestDNASum = 0;
int DNACount = 0;
string input;

while ((input = Console.ReadLine()) != "Clone them!")
{
    int[] currentSequence = input
        .Split("!", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    DNACount++;
    int currentDNALength = 0;
    int currentDNAIndex = 0;
    int currentDNAStartingIndex = 0;
    int currentDNASum = 0;

    for (int i = 0; i < currentSequence.Length; i++)
    {
        if (currentSequence[i] == 1)
        {
            currentDNASum++;


            if (i + 1 < currentSequence.Length && currentSequence[i + 1] == 1)
            {
                currentDNAIndex = DNACount;
                currentDNAStartingIndex = i;

                for (int j = i; j < currentSequence.Length; j++)
                {
                    if (currentSequence[j] != 1)
                    {
                        break;
                    }

                    currentDNALength++;
                }
            }
        }
    }

    if (currentDNALength > bestDNALength)
    {
        bestDNALength = currentDNALength;
        bestDNAIndex = currentDNAIndex;
        bestDNAStartingIndex = currentDNAStartingIndex;
        bestDNASum = currentDNASum;
        bestDNA = currentSequence;
    }
    else if (currentDNALength == bestDNALength)
    {
        if (currentDNAStartingIndex < bestDNAStartingIndex)
        {
            bestDNALength = currentDNALength;
            bestDNAIndex = currentDNAIndex;
            bestDNAStartingIndex = currentDNAStartingIndex;
            bestDNASum = currentDNASum;
            bestDNA = currentSequence;
        }
        else if (currentDNAStartingIndex == bestDNAStartingIndex)
        {
            if (currentDNASum > bestDNASum)
            {
                bestDNALength = currentDNALength;
                bestDNAIndex = currentDNAIndex;
                bestDNAStartingIndex = currentDNAStartingIndex;
                bestDNASum = currentDNASum;
                bestDNA = currentSequence;
            }
        }
    }
}

Console.WriteLine($"Best DNA sample {bestDNAIndex} with sum: {bestDNASum}.");
Console.WriteLine(string.Join(" ", bestDNA));