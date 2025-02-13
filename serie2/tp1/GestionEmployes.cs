using System;
using System.Collections.Generic;

public class GestionEmployes
{
    private List<Employee> employees = new List<Employee>();

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }

    public void RemoveEmployee(Employee employee)
    {
        employees.Remove(employee);
    }

    public double CalculateTotalSalary()
    {
        double total = 0;
        foreach (var employee in employees)
        {
            total += employee.Salary;
        }
        return total;
    }

    public double CalculateAverageSalary()
    {
        if (employees.Count == 0)
            return 0;

        double total = CalculateTotalSalary();
        return total / employees.Count;
    }

    public List<Employee> GetEmployees()
    {
        return employees;
    }
}
