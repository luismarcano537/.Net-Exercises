using System;
using System.Collections.Generic;


namespace ContractSystem.Entities
{
    internal class Contract
    {

        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double totalValue { get; set; }
        public List<Installment> Installments { get; set; } = new List<Installment>();

        public Contract(int number, DateTime date, double totalvalue)
        {
            Number = number;
            Date = date;
            totalValue = totalvalue;
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
