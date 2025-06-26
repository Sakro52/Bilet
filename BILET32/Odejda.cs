using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Odejda : Tovar
    {
        private string color;
        private int quantity;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Odejda(string name, double price, string color, int quantity)
            : base(name, price)
        {
            this.color = color;
            this.quantity = quantity;
        }

        public override double CalcSum()
        {
            return price * quantity * 1.1; // Налог 10%
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Цвет: " + color);
            Console.WriteLine("Количество: " + quantity);
            Console.WriteLine();
        }
    }

}
