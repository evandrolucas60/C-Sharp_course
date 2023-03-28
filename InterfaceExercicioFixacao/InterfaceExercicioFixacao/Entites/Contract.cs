using System;
using System.Collections.Generic;

namespace InterfaceExercicioFixacao.Entites
{
    class Contract
    {
        //Variáveis de Instância
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        //composição
        public List<Installment> Installments { get; set; } = new List<Installment>();

        //construtores
        public Contract()
        {
        }

        public Contract(int number, DateTime dateTime, double totalValue)
        {
            Number = number;
            Date = dateTime;
            TotalValue = totalValue;
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
