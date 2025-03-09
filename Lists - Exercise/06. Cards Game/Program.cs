List<int> firstPlayerHand = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> secondPlayerHand = Console.ReadLine().Split().Select(int.Parse).ToList();

while (firstPlayerHand.Count > 0 && secondPlayerHand.Count > 0)
{
	int firstPlayerCard = firstPlayerHand[0];
	int secondPlayerCard = secondPlayerHand[0];

	if (firstPlayerCard > secondPlayerCard)
	{
		firstPlayerHand.Add(secondPlayerCard);
		firstPlayerHand.Add(firstPlayerCard);
		secondPlayerHand.Remove(secondPlayerCard);
		firstPlayerHand.Remove(firstPlayerCard);
	}
	else if (secondPlayerCard > firstPlayerCard)
	{
		secondPlayerHand.Add(firstPlayerCard);
		secondPlayerHand.Add(secondPlayerCard);
		firstPlayerHand.Remove(firstPlayerCard);
        secondPlayerHand.Remove(secondPlayerCard);
    }
	else
	{
		firstPlayerHand.Remove(firstPlayerCard);
		secondPlayerHand.Remove(secondPlayerCard);
	}
}

if (firstPlayerHand.Count == 0)
{
    Console.WriteLine($"Second player wins! Sum: {secondPlayerHand.Sum()}");
}
else
{
    Console.WriteLine($"First player wins! Sum: {firstPlayerHand.Sum()}");
}