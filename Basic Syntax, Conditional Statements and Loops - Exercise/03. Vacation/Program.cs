int people = int.Parse(Console.ReadLine());
string groupType = Console.ReadLine();
string day = Console.ReadLine();
double totalPrice = 0;

switch (groupType)
{
    case "Students":

        switch (day)
        {
            case "Friday":
                totalPrice = people * 8.45;
                break;
            case "Saturday":
                totalPrice = people * 9.8;
                break;
            case "Sunday":
                totalPrice = people * 10.46;
                break;
        }

        if (people >= 30)
        {
            totalPrice -= totalPrice * 0.15;
        }

        break;
    case "Business":

        if (people >= 100)
        {
            people -= 10;
        }

        switch (day)
        {
            case "Friday":
                totalPrice = people * 10.9;
                break;
            case "Saturday":
                totalPrice = people * 15.6;
                break;
            case "Sunday":
                totalPrice = people * 16.0;
                break;
        }

        break;
    case "Regular":

        switch (day)
        {
            case "Friday":
                totalPrice = people * 15.0;
                break;
            case "Saturday":
                totalPrice = people * 20.0;
                break;
            case "Sunday":
                totalPrice = people * 22.5;
                break;
        }

        if (people >= 10 && people <= 20)
        {
            totalPrice -= totalPrice * 0.05;
        }

        break;
}

Console.WriteLine($"Total price: {totalPrice:f2}");