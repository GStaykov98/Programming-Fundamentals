List<Person> people = new();
string input;

while ((input = Console.ReadLine()) != "End")
{
    string[] tokens = input.Split();
    string name = tokens[0];
    string id = tokens[1];
    int age = int.Parse(tokens[2]);

    if (CheckIfPersonExists(people, id))
    {
        people.First(x => x.Id == id).EditData(name, age);
    }
    else
    {
        Person newPerson = new(name, id, age);
        people.Add(newPerson);
    }
}

foreach (Person person in people.OrderBy(a => a.Age))
{
    Console.WriteLine(person);
}

bool CheckIfPersonExists(List<Person> people, string id)
{
    bool personExists = false;

    if (people.Select(x => x.Id).Contains(id))
    {
        personExists = true;
    }

    return personExists;
}

public class Person
{
    public Person(string name, string id, int age)
    {
        this.Name = name;
        this.Id = id;
        this.Age = age;
    }

    public string Name { get; set; }
    public string Id { get; set; }
    public int Age { get; set; }   
    
    public void EditData(string newName, int newAge)
    {
        this.Name = newName;
        this.Age = newAge;
    }

    public override string ToString()
    {
        return $"{this.Name} with ID: {this.Id} is {this.Age} years old.";
    }
}