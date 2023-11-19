using Exercício01.Entities;
using Exercício01.Entities.Enums;
using System;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament's name: ");
            string nameDp = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("How many contracts to this worker? ");
           
            Departament departament = new Departament(nameDp);
            Worker worker = new Worker(name, level, salary, departament);

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entrer #{i} contract data:");
                Console.Write("Date (DD/MM/YYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Enter value per hour: ");
                double valueHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Dutarion (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract hourContract = new HourContract(date,valueHour,hours);
                worker.AddContract(hourContract);
             }

            Console.WriteLine("\nEnter month and year to calculate income (MM/YYYY): ");
            string dateCalc = Console.ReadLine();
            int mont = int.Parse(dateCalc.Substring(0,2));
            int year = int.Parse(dateCalc.Substring(3));

            Console.WriteLine($"Name: {worker.Name}\nDepartament: {departament.Name}\nIncome for: {mont}/{year}: {worker.Income(year, mont).ToString("F2", CultureInfo.InvariantCulture)}");

            
        }
    }
}
