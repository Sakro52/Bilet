using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    abstract class Tovar
    {
        protected string name;
        protected double price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Tovar(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public abstract double CalcSum();

        public virtual void Print()
        {
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Цена: " + String.Format("{0:F2}", price));
            Console.WriteLine("Стоимость: " + String.Format("{0:F2}", CalcSum()));
        }
    }
}
