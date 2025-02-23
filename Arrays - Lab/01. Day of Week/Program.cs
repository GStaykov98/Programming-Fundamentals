int day = int.Parse(Console.ReadLine());

string[] daysOfWeek =
{
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
    "Sunday"
};

if (day - 1 >= 0 && day - 1 <= 6)
{
    Console.WriteLine(daysOfWeek[day - 1]);
}
else
{
    Console.WriteLine("Invalid day!");
}