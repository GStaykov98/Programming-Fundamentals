int n = int.Parse(Console.ReadLine());
List<Car> cars = new();

for (int i = 0; i < n; i++)
{
    string[] tokens = Console.ReadLine().Split();
    string model = tokens[0];
    int engineSpeed = int.Parse(tokens[1]);
    int enginePower = int.Parse(tokens[2]);
    int cargoWeight = int.Parse(tokens[3]);
    string cargoType = tokens[4];

    Cargo currentCargo = new(cargoWeight, cargoType);
    Engine currentEngine = new(engineSpeed, enginePower);
    Car currentCar = new(model, currentEngine, currentCargo);

    cars.Add(currentCar);
}

string neededType = Console.ReadLine();

if (neededType == "fragile")
{
    foreach (var car in cars.Where(x => x.Cargo.Type == "fragile"))
    {
        if (car.Cargo.Weight < 1000)
        {
            Console.WriteLine(car.Model);
        }
    }
}
else if (neededType == "flamable")
{
    foreach (var car in cars.Where(x => x.Cargo.Type == "flamable"))
    {
        if (car.Engine.Power > 250)
        {
            Console.WriteLine(car.Model);
        }
    }
}

public class Car
{
    public Car(string model, Engine engine, Cargo cargo)
    {
        this.Model = model;
        this.Engine = engine;
        this.Cargo = cargo;
    }

    public string Model { get; set; }
    public Engine Engine { get; set; }
    public Cargo Cargo { get; set; }
}

public class Engine
{
    public Engine(int engineSpeed, int enginePower)
    {
        this.Speed = engineSpeed;
        this.Power = enginePower;
    }

    public int Speed { get; set; }
    public int Power { get; set; }
}

public class Cargo
{
    public Cargo(int cargoWeight, string cargoType)
    {
        this.Weight = cargoWeight;
        this.Type = cargoType;
    }

    public int Weight { get; set; }
    public string Type { get; set; }

}