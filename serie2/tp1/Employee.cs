using System;

public class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }
    public string Position { get; set; }
    public DateTime HireDate { get; set; }

    public Employee(string name, double salary, string position, DateTime hireDate)
    {
        Name = name;
        Salary = salary;
        Position = position;
        HireDate = hireDate;
    }
}
