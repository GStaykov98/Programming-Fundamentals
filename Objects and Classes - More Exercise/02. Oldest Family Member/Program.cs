int n = int.Parse(Console.ReadLine());
Family family = new Family();

for (int i = 0; i < n; i++)
{
    string[] tokens = Console.ReadLine().Split();
    string name = tokens[0];
    int age = int.Parse(tokens[1]);

    Person currentPerson = new()
    {
        Name = name,
        Age = age,
    };

    family.AddMember(currentPerson);
}

Person oldestPerson = family.GetOldestMember();

Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Family
{
    public Family()
    {
            this.People = new List<Person>();
    }

    public List<Person> People { get; set;}

    public void AddMember(Person member)
    {
        this.People.Add(member);
    }

    public Person GetOldestMember()
    {
        return this.People.OrderByDescending(x => x.Age).FirstOrDefault();
    }
}