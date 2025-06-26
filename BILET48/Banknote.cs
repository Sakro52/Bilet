using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Banknote
    {
        private string name;
        private double denomination;
        private int quantity;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty!");
                name = value;
            }
        }

        public double Denomination
        {
            get { return denomination; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Denomination must be positive!");
                denomination = value;
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Quantity cannot be negative!");
                quantity = value;
            }
        }

        public Banknote()
        {
            name = "Unknown";
            denomination = 1;
            quantity = 0;
        }

        public Banknote(string name, double denomination)
        {
            Name = name;
            Denomination = denomination;
            quantity = 0;
        }

        public Banknote(string name, double denomination, int quantity)
        {
            Name = name;
            Denomination = denomination;
            Quantity = quantity;
        }

        public void ChangeQuantity(int change)
        {
            Quantity += change;
        }

        public bool CanPay(double cost)
        {
            return denomination * quantity >= cost;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Banknote: {name}");
            Console.WriteLine($"Denomination: {denomination:F2}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Total Amount: {denomination * quantity:F2}");
            Console.WriteLine();
        }
    }
}
