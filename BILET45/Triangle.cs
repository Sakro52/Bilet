using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Triangle : IShape
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || b + c <= a || a + c <= b)
            {
                throw new ArgumentException("Невозможно построить треугольник!");
            }
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Perimeter()
        {
            return a + b + c;
        }

        public double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override string ToString()
        {
            return $"Треугольник со сторонами: {a}, {b}, {c}";
        }
    }
}
