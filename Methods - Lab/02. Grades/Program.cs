﻿double grade = double.Parse(Console.ReadLine());

GetGrade(grade);

static void GetGrade(double grade)
{
	if (grade >= 2 && grade < 3)
	{
        Console.WriteLine("Fail");
    }
	else if (grade < 3.5)
	{
        Console.WriteLine("Poor");
    }
	else if (grade < 4.5)
	{
        Console.WriteLine("Good");
    }
	else if (grade < 5.5)
	{
        Console.WriteLine("Very good");
    }
	else if (grade <= 6)
	{
        Console.WriteLine("Excellent");
    }
}