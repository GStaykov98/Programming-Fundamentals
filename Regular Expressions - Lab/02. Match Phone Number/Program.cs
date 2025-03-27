using System.Text.RegularExpressions;

string input = Console.ReadLine();

string pattern = @"\+359( |-)[2]\1\d{3}\1\d{4}\b";
Regex regex = new Regex(pattern);
var matches = regex.Matches(input);

var phones = matches
    .Cast<Match>()
    .Select(a => a.Value.Trim())
    .ToArray();

Console.WriteLine(string.Join(", ", phones));