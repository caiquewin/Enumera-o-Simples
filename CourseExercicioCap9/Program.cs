using CourseExercicioCap9.Entities;
using CourseExercicioCap9.Entities.Enums;
using System;
using System.Globalization;

namespace CourseExercicioCap9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department s name: ");
            string dptName = Console.ReadLine();
            Console.WriteLine("Enter worked data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double BaseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dept = new Departament(dptName);
            Worker worker = new Worker(name, level, BaseSalary, dept);
            Console.WriteLine();
            Console.Write("How many contracts to this worker ? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract date: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hors = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hors);
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int mohth = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.departament.Name);
            Console.Write("Income  for "+monthAndYear+" :"+ worker.Income(year,mohth));
            
        }
    }
}
