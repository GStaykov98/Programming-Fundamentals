string[] peopleArray = Console.ReadLine().Split(';');
string[] productsArray = Console.ReadLine().Split(';');
List<Person> people = new();
List<Product> products = new();

foreach (var person in peopleArray)
{
    if (string.IsNullOrEmpty(person)) continue;

    string[] personTokens = person.Split('=');
    string name = personTokens[0];
    double money = double.Parse(personTokens[1]);

    Person currentPerson = new(name, money);
    people.Add(currentPerson);
}

foreach (var product in productsArray)
{
    if (string.IsNullOrEmpty(product)) continue;

    string[] productTokent = product.Split('=');
    string name = productTokent[0];
    double cost = double.Parse(productTokent[1]);

    Product currentProdut = new(name, cost);
    products.Add(currentProdut);
}

string input;

while ((input = Console.ReadLine()) != "END")
{
    string[] command = input.Split();
    Person person = people.FirstOrDefault(x => x.Name == command[0]);
    Product product = products.FirstOrDefault(x => x.Name == command[1]);

    if (person.Money >= product.Cost)
    {
        person.Money -= product.Cost;
        person.Products.Add(product);
        Console.WriteLine($"{person.Name} bought {product.Name}");
    }
    else
    {
        Console.WriteLine($"{person.Name} can't afford {product.Name}");
    }
}

foreach (var person in people)
{
    if (person.Products.Any())
    {
        Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products.Select(x => x.Name))}");
    }
    else
    {
        Console.WriteLine($"{person.Name} - Nothing bought");
    }
}

public class Person
{
    public Person(string name, double money)
    {
        this.Name = name;
        this.Money = money;
        this.Products = new List<Product>();
    }

    public string Name { get; set; }
    public double Money { get; set; }
    public List<Product> Products { get; set; }
}

public class Product
{
    public Product(string name, double cost)
    {
        this.Name = name;
        this.Cost = cost;
    }

    public string Name { get; set; }
    public double Cost { get; set; }
}