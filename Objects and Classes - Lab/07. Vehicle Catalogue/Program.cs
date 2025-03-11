string input;
Catalog catalog = new();

while ((input = Console.ReadLine()) != "end")
{
    string[] inputArr = input.Split('/');
    string type = inputArr[0];
    string brand = inputArr[1];
    string model = inputArr[2];
    
    if (type == "Truck")
    {
        int weight = int.Parse(inputArr[3]);

        Truck currentTruck = new Truck
        {
            Brand = brand,
            Model = model,
            Weight = weight
        };

        catalog.Trucks.Add(currentTruck);
    }
    else
    {
        int horsePower = int.Parse(inputArr[3]);

        Car currentCar = new Car
        {
            Brand = brand,
            Model = model,
            HorsePower = horsePower
        };

        catalog.Cars.Add(currentCar);
    }
}

if (catalog.Cars.Count > 0)
{
    Console.WriteLine("Cars:");
    foreach (var car in catalog.Cars.OrderBy(x => x.Brand))
    {
        Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
    }
}

if (catalog.Trucks.Count > 0)
{
    Console.WriteLine("Trucks:");
    foreach (var truck in catalog.Trucks.OrderBy(x => x.Brand))
    {
        Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
    }
}

class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }

}

class Car
{
    public string Brand {  set; get; }
    public string Model { get; set; }
    public int HorsePower { get; set; }
}

class Catalog
{
    public Catalog()
    {
        Trucks = new List<Truck>();
        Cars = new List<Car>();
    }

    public List<Truck> Trucks { get; set; }
    public List<Car> Cars { get; set; }
}