int n = int.Parse(Console.ReadLine());
List<Department> departments = new();
string highestPayedDepartmend = string.Empty;
double highestAverageSalary = 0;

for (int i = 0; i < n; i++)
{
    string[] tokens = Console.ReadLine().Split();
    string name = tokens[0];
    double salary = double.Parse(tokens[1]);
    string department = tokens[2];

    Employee currentEmployee = new Employee
    {
        Name = name,
        Salary = salary
    };

    if (!departments.Any(x => x.Name == department))
    {
        Department newDepartment = new Department
        {
            Name = department
        };

        newDepartment.Employees.Add(currentEmployee);
        departments.Add(newDepartment);
    }
    else
    {
        departments.Find(x => x.Name == department).Employees.Add(currentEmployee);
    }
}

foreach (var department in departments)
{
    department.GetAverageSalary();

    if (department.AverageSalary > highestAverageSalary)
    {
        highestAverageSalary = department.AverageSalary;
        highestPayedDepartmend = department.Name;
    }
}

Department bestDepartment = departments.FirstOrDefault(x => x.Name == highestPayedDepartmend);
bestDepartment.OrderEmployees();

Console.WriteLine($"Highest Average Salary: {highestPayedDepartmend}");

foreach (var employee in bestDepartment.Employees)
{
    Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
}

public class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }
}

public class Department
{
    public Department()
    {
            Employees = new List<Employee>();
    }

    public string Name { get; set; }
    public List<Employee> Employees { get; set; }
    public double AverageSalary { get; set; }

    public void GetAverageSalary()
    {
        double salary = Employees.Sum(x => x.Salary) / Employees.Count;

        this.AverageSalary = salary;
    }

    public void OrderEmployees()
    {
        Employees = Employees.OrderByDescending(x => x.Salary).ToList();
    }
}