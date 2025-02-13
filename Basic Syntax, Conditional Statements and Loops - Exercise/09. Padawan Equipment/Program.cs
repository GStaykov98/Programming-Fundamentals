double budget = double.Parse(Console.ReadLine());
int studentsCount = int.Parse(Console.ReadLine());
double lightsabersPrice = double.Parse(Console.ReadLine());
double robesPrice  = double.Parse(Console.ReadLine());
double beltsPrice  = double.Parse(Console.ReadLine());

double totalLightsabersPrice = lightsabersPrice * (Math.Ceiling(studentsCount * 1.1));
double totalRobesPrice = robesPrice * studentsCount;

int beltsCount = 0;

for (int i = 1; i <= studentsCount; i++)
{
	if (i % 6 != 0)
	{
		beltsCount++;
	}
}

double totalBeltsPrice = beltsPrice * beltsCount;
double totalPrice = totalLightsabersPrice + totalRobesPrice + totalBeltsPrice;

if (budget >= totalPrice)
{
    Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
}
else
{
	double neededMoney = totalPrice - budget;

    Console.WriteLine($" John will need {neededMoney:f2}lv more.");
}