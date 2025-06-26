using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Posuda : Tovar
    {
        private double weight;
        private int quantity;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Posuda(string name, double price, double weight, int quantity)
            : base(name, price)
        {
            this.weight = weight;
            this.quantity = quantity;
        }

        public override double CalcSum()
        {
            return price * quantity * (1 + weight * 0.01); // Увеличение цены за вес
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Вес: " + String.Format("{0:F2}", weight));
            Console.WriteLine("Количество: " + quantity);
            Console.WriteLine();
        }
    }
}
