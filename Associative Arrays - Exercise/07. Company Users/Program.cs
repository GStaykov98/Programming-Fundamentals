Dictionary<string, List<string>> companies = new();
string input;

while ((input = Console.ReadLine()) != "End")
{
    string[] tokens = input.Split(" -> ");
    string company = tokens[0];
    string employee = tokens[1];

    if (!companies.ContainsKey(company))
    {
        companies.Add(company, new List<string> { employee });
    }
    else
    {
        if (!companies[company].Contains(employee))
        {
            companies[company].Add(employee);
        }
    }
}

foreach (var company in companies)
{
    Console.WriteLine(company.Key);

    foreach (var employee in company.Value)
    {
        Console.WriteLine($"-- {employee}");
    }
}