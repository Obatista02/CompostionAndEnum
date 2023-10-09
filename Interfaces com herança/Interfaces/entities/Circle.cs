using System;
using System.Collections.Generic;

namespace Interfaces.entities
{
    internal class Circle
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Rectangle> Installments { get; set; }

        public Circle(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Rectangle>();
        }

        public void AddInstallment(Rectangle installment)
        {
            Installments.Add(installment);
        }
    }
}
