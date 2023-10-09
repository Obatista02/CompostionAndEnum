using System;
using System.Globalization;

namespace Interfaces.entities
{
    internal class Rectangle
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Rectangle(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
