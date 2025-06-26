using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Obuv : Tovar
    {
        private int size;
        private int quantity;

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Obuv(string name, double price, int size, int quantity)
            : base(name, price)
        {
            this.size = size;
            this.quantity = quantity;
        }

        public override double CalcSum()
        {
            return price * quantity;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Размер: " + size);
            Console.WriteLine("Количество: " + quantity);
            Console.WriteLine();
        }
    }
}
