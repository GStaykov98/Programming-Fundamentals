double numA = double.Parse(Console.ReadLine());
double numB = double.Parse(Console.ReadLine());
double eps = 0.000001;
double difference = Math.Abs(numA - numB);

if (difference < eps)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}