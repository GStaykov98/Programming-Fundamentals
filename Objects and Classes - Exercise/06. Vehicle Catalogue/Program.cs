using System.Globalization;

string input;
List<Vehicle> vehicles = new();

while ((input = Console.ReadLine()) != "End")
{
    string[] tokens = input.Split();
    string type = tokens[0];
    string model = tokens[1];
    string color = tokens[2];
    int horsepower = int.Parse(tokens[3]);

    Vehicle newVehicle = new(type, model, color, horsepower);
    vehicles.Add(newVehicle);
}

while ((input = Console.ReadLine()) != "Close the Catalogue")
{
    foreach (var vehicle in vehicles.Where(x => x.Model == input))
    {
        Console.WriteLine($"Type: {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(vehicle.Type)}");
        Console.WriteLine($"Model: {vehicle.Model}");
        Console.WriteLine($"Color: {vehicle.Color}");
        Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
    }
}

List<Vehicle> cars = vehicles.Where(x => x.Type == "car").ToList();
List<Vehicle> trucks = vehicles.Where(x => x.Type == "truck").ToList();

if (cars.Count == 0)
{
    Console.WriteLine($"Cars have average horsepower of: 0.00.");
}
else
{
    Console.WriteLine($"Cars have average horsepower of: {GetAverageHorsepower(cars):f2}.");
}

if (trucks.Count == 0)
{
    Console.WriteLine($"Trucks have average horsepower of: 0.00.");
}
else
{
    Console.WriteLine($"Trucks have average horsepower of: {GetAverageHorsepower(trucks):f2}.");
}

double GetAverageHorsepower(List<Vehicle> vehicles)
{
    double average = 0;

    foreach (var vehicle in vehicles)
    {
        average += vehicle.Horsepower;
    }

    average /= (double)vehicles.Count;

    return average;
}

public class Vehicle
{
    public Vehicle(string type, string model, string color, int hp)
    {
        this.Type = type;
        this.Model = model;
        this.Color = color;
        this.Horsepower = hp;
    }

    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int Horsepower { get; set; }
}