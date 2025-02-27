double number = double.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());
double raisedNumber = RaiseToPower(number, power);
Console.WriteLine(raisedNumber);

static double RaiseToPower(double number, int power)
{
    return Math.Pow(number, power);
}