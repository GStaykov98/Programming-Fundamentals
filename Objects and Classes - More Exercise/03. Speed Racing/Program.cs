int n = int.Parse(Console.ReadLine());
List<Car> cars = new();

for (int i = 0; i < n; i++)
{
    string[] tokens = Console.ReadLine().Split();
    string model = tokens[0];
    double fuelAmount = double.Parse(tokens[1]);
    double fuelConsumption = double.Parse(tokens[2]);

    Car newCar = new(model, fuelAmount, fuelConsumption);
    cars.Add(newCar);
}

string input;

while ((input = Console.ReadLine()) != "End")
{
    string[] tokens = input.Split();
    string car = tokens[1];
    double distance = double.Parse(tokens[2]);

    cars.First(x => x.Model == car).Drive(distance);
}

foreach (var car in cars)
{
    Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
}

public class Car
{
    public Car(string model, double fuelAmount, double fuelConsumption)
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelConsumption = fuelConsumption;
        this.TravelledDistance = 0;
    }

    public string Model { get; set; }
    public double FuelAmount { get; set; }
    public double FuelConsumption { get; set; }
    public double TravelledDistance { get; private set; }

    public void Drive(double distance)
    {
        double neededFuel = distance * FuelConsumption;

        if (FuelAmount >= neededFuel)
        {
            TravelledDistance += distance;
            FuelAmount -= neededFuel;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }
}