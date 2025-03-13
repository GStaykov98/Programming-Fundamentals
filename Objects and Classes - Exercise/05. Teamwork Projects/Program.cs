int n = int.Parse(Console.ReadLine());
List<Team> teams = new();

for (int i = 0; i < n; i++)
{
    string[] tokens = Console.ReadLine().Split("-");
    string creator = tokens[0];
    string teamName = tokens[1];

    if (teams.Select(x => x.Creator).Contains(creator))
    {
        Console.WriteLine($"{creator} cannot create another team!");
        continue;
    }

    if (teams.Select(x => x.Name).Contains(teamName))
    {
        Console.WriteLine($"Team {teamName} was already created!");
        continue;
    }

    Team newTeam = new(teamName, creator);
    teams.Add(newTeam);

    Console.WriteLine($"Team {teamName} has been created by {creator}!");
}

string input;

while ((input = Console.ReadLine()) != "end of assignment")
{
    string[] tokens = input.Split("->");
    string user = tokens[0];
    string team = tokens[1];

    if (!teams.Select(x => x.Name).Contains(team))
    {
        Console.WriteLine($"Team {team} does not exist!");
        continue;
    }

    if (CheckIfMemberExists(teams, user))
    {
        Console.WriteLine($"Member {user} cannot join team {team}!");
        continue;
    }

    Team currentTeam = teams.First(x => x.Name == team);
    currentTeam.Members.Add(user);
}

List<Team> disbandedTeams = new();

foreach (Team team in teams)
{
    if (team.Members.Count == 0)
    {
        disbandedTeams.Add(team);
    }
}

teams.RemoveAll(x => x.Members.Count == 0);

teams = teams.OrderByDescending(m => m.Members.Count).ThenBy(n => n.Name).ToList();

foreach (var team in teams)
{
    Console.WriteLine(team.Name);
    Console.WriteLine($"- {team.Creator}");

    foreach (var member in team.Members.OrderBy(x => x))
    {
        Console.WriteLine($"-- {member}");
    }
}

Console.WriteLine("Teams to disband:");
foreach (var team in disbandedTeams.OrderBy(x => x.Name))
{
    Console.WriteLine(team.Name);
}

bool CheckIfMemberExists(List<Team> teams, string user)
{
    bool memberExists = false;

    foreach (var team in teams)
    {
        if (team.Members.Contains(user) || team.Creator == user)
        {
            memberExists = true;
        }
    }

    return memberExists;
}

public class Team
{
    public Team(string name, string creator)
    {
        this.Name = name;
        this.Creator = creator;
        Members = new List<string>();
    }

    public string Name { get; set; }    
    public string Creator { get; set; }
    public List<string> Members { get; set; }
}