Dictionary<string, Dictionary<string, int>> players = new();
string input;

while ((input = Console.ReadLine()) != "Season end")
{
    if (input.Contains("->"))
    {
        string[] tokens = input.Split(" -> ");
        string player = tokens[0];
        string position = tokens[1];
        int skillPoints = int.Parse(tokens[2]);

        if (!players.ContainsKey(player))
        {
            players.Add(player, new Dictionary<string, int>());
            players[player].Add(position, skillPoints);
        }
        else
        {
            if (!players[player].ContainsKey(position))
            {
                players[player].Add(position, skillPoints);
            }
            else
            {
                if (players[player][position] < skillPoints)
                {
                    players[player][position] = skillPoints;
                }
            }
        }
    }
    else
    {
        string[] tokens = input.Split(" vs ");
        string player1 = tokens[0];
        string player2 = tokens[1];

        if (players.ContainsKey(player1) && players.ContainsKey(player2))
        {
            foreach (var role in players[player1])
            {
                if (players[player2].Keys.Contains(role.Key))
                {
                    int player1Points = players[player1].Values.Sum();
                    int player2Points = players[player2].Values.Sum();

                    if (player1Points > player2Points)
                    {
                        players.Remove(player2);
                    }
                    else if (player2Points > player1Points)
                    {
                        players.Remove(player1);
                    }
                }
            }
        }
    }
}

foreach (var player in players.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
{
    Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");

    foreach (var role in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
    {
        Console.WriteLine($"- {role.Key} <::> {role.Value}");
    }
}