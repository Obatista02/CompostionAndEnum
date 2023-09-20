using Atividade.entities;
using Atividade.entities.Enum;
using System;
using System.Globalization;

namespace Atividade
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter department´s name: ");
            string departName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            Department dept = new Department(departName);
            Worker worker = new Worker(name, level, baseSalary, dept);


            Console.WriteLine("How many contractsm to this worker? ");
            int numberContract = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numberContract; i++)
            {
                Console.WriteLine("Enter #"+i+ "Contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hours: ");
                double valuePerHours = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date,valuePerHours,hours);

                worker.AddContract(contract);

            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string MonthAndYear = Console.ReadLine();
            int month = int.Parse(MonthAndYear.Substring(0, 2));
            int year = int.Parse(MonthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: "+ worker.Department.Name);
            Console.WriteLine("Income for " + MonthAndYear + ": " + worker.Income(year, month));
        }
    }
}