using Exercício01.Entities.Enums;
using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace Exercício01.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract (HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract (HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income (int years, int month)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if(years == contract.Date.Year && month ==contract.Date.Month)
                {
                    sum += contract.TotalValue();
                }
            } return sum;
        }
       
    }
}
