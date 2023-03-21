using System;
using System.Collections.Generic;
using ComposicaoObjetos.Entities.Enums;

namespace ComposicaoObjetos.Entities
{
    internal class Worker
    {
        public String Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        //composição com a classe Department
        public Department Department { get; set; }
        //Cria uma lista para os contratos
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();   

        public Worker() 
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        //Métodos
        public void AddContract(HourContract contract) 
        {
            Contracts.Add(contract);
        }

       public void RemoveContract(HourContract contract) 
        { 
            Contracts.Remove(contract);
        }

        public double Income(int year, int month) 
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts) 
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }
    }
}
