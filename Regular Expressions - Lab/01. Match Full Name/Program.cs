using System.Text.RegularExpressions;

string names = Console.ReadLine();

string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
Regex regex = new Regex(pattern);
MatchCollection matches = regex.Matches(names);

foreach (Match match in matches)
{
    Console.Write(match.Value + " ");
}