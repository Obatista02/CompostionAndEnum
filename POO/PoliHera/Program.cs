using PoliHera.entities;
using System.Collections.Generic;
using System.Globalization;

List<Employee> list = new List<Employee>();

Console.Write("Enter the number of employees: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Outsourced (y/n): ");
    string r = Console.ReadLine();
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valuePerHour = int.Parse(Console.ReadLine());
    
    if (r == "n")
    {
        Employee employee = new Employee(name,hours,valuePerHour);
        list.Add(employee);
    }
    else
    {
        Console.WriteLine("Additional charge: ");
        double add = double.Parse(Console.ReadLine());

        Employee Out = new OutsourcedEmployee(name,hours,valuePerHour,add);
        list.Add(Out);
    }
    Console.WriteLine();
    Console.WriteLine("PAYMENTS:");

    foreach (Employee emp in list)
    {
        Console.WriteLine("Name: " + emp.Name + "Salary: "+ emp.Payment().ToString("F2",CultureInfo.InvariantCulture));
    }
}